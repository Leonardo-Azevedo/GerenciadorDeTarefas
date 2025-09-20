//Classe que aplica a regra de negócio do sistema


using System.Threading.Tasks;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Interfaces;

namespace TasksWithBD.Services
{
    public class TaskService
    {
        private readonly TaskRepository _taskRepository;
        public TaskService(TaskRepository  taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void CreateTask(ITask task)
        {
            if(string.IsNullOrWhiteSpace(task.Name))
            {
                //proibido task com nome vazio
                throw new ArgumentException("Task name can not be null or empty.");
            }

            task.CreateDate = DateTime.Now.Date;

            _taskRepository.Add(task);
        }

        public IEnumerable<ITask> ListAll()
        {
            //aplica regras de negócio
            return _taskRepository.ListAll();
        }

        public void DeleteTask(int id)
        {
            _taskRepository.Delete(id);
        }

        public ITask GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);

        }
    
    }
}
