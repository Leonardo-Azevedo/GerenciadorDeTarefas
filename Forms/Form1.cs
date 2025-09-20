using System.Windows.Forms;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Entities.Interfaces;
using TasksWithBD.Services;

namespace TasksWithBD
{
    public partial class Form1 : Form
    {
        private TaskService _taskService;
        public Form1()
        {
            InitializeComponent();
            var repository = new TaskRepository();
            _taskService = new TaskService(repository);
            dtgView.AutoGenerateColumns = false;

        }

        public void limpaCampos()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private IEnumerable<ITask> LoadTasks()
        {
            IEnumerable<ITask> listTasks = new List<ITask>();
            listTasks = _taskService.ListAll();

            return listTasks;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var task = new SimpleTask
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StartDate = dtStartDate.Value,
                Status = OrderStatus.Pending

            };

            _taskService.CreateTask(task);

            limpaCampos();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dtgView.DataSource = (List<ITask>)LoadTasks();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int outIdTask;
            int.TryParse(txtIdTaskDelete.Text, out outIdTask);
            _taskService.DeleteTask(outIdTask);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            limpaCampos();

            int outIdTask;
            int.TryParse(txtIdSelect.Text, out outIdTask);

            ITask task = _taskService.GetTaskById(outIdTask);

            if (task != null)
            {
                txtName.Text = task.Name;
                txtDescription.Text = task.Description;
                dtStartDate.Value = task.StartDate;
            }
        }
    }
}
