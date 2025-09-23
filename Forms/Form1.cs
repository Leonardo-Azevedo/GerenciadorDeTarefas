using System.Windows.Forms;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Entities.Interfaces;
using TasksWithBD.Forms;
using TasksWithBD.Services;

namespace TasksWithBD
{
    public partial class Form1 : Form
    {
        private TaskService _taskService;
        private int _currentTaskId;
        public Form1()
        {
            InitializeComponent();
            var repository = new TaskRepository();
            _taskService = new TaskService(repository);
            dtgView.AutoGenerateColumns = false;
            listStatus.DataSource = Enum.GetValues(typeof(OrderStatus));

        }

        public void Clear()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtStartDate.Text = string.Empty;
            listStatus.Text = string.Empty;
        }

        private IEnumerable<ITask> LoadTasks()
        {
            IEnumerable<ITask> listTasks = new List<ITask>();
            listTasks = _taskService.ListAll();

            return listTasks;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dtgView.DataSource = (List<ITask>)LoadTasks();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int outIdTask;
            //int.TryParse(txtIdSelect.Text, out outIdTask);

            _taskService.DeleteTask(_currentTaskId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            //int outIdTask;
            //int.TryParse(txtIdSelect.Text, out outIdTask);

            ITask taskUp = _taskService.GetTaskById(_currentTaskId);

            taskUp.Id = _currentTaskId;
            taskUp.Name = txtName.Text;
            taskUp.Description = txtDescription.Text;
            taskUp.StartDate = dtStartDate.Value;
            taskUp.Status = (OrderStatus)listStatus.SelectedItem;

            _taskService.UpdateTask(taskUp);

            Clear();

        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dtgView.Rows[index];
                _currentTaskId = (int)selectedRow.Cells[0].Value;
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtDescription.Text = selectedRow.Cells[2].Value.ToString();
                dtStartDate.Text = selectedRow.Cells[4].Value.ToString();
                listStatus.Text = selectedRow.Cells[6].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;


            }


        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
