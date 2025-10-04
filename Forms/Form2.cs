using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Services;

namespace TasksWithBD.Forms
{
    public partial class Form2 : Form
    {
        private TaskService _taskService;
        private int _currentTaskId;
        public Form2()
        {
            InitializeComponent();
            var repository = new TaskRepository();
            _taskService = new TaskService(repository);
            listCStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
        }
        public void Clear()
        {
            txtCName.Text = string.Empty;
            txtCDescription.Text = string.Empty;
            dtCStartDate.Text = string.Empty;
            listCStatus.Text = string.Empty;
        }

        private void btnCCreate_Click(object sender, EventArgs e)
        {
            var task = new SimpleTask
            {
                Name = txtCName.Text,
                Description = txtCDescription.Text,
                StartDate = dtCStartDate.Value,
                Status = OrderStatus.Pending

            };

            var result = _taskService.CreateTask(task);
            if(result.Success == false)
            {
                MessageBox.Show(result.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }

            Clear();

            
        }
    }
}
