//Classe que aplica a regra de negócio do sistema


using System.Threading.Tasks;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
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
            task.CreateDate = DateTime.Now.Date;

            if (string.IsNullOrWhiteSpace(task.Name))
            {
                //proibido task com nome vazio
                throw new ArgumentException("Task name can not be null or empty.");
            }

            if (task.StartDate > task.FinishDate)
            {
                //não pode criar uma task onde o star começa depois do finish
                throw new ArgumentException("Start date can't be greater than the finish date.");
            }


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

        public void UpdateTask(ITask task)
        {
            if (task.Status == OrderStatus.Finished && task.FinishDate == null)
            {
                //Se data inicio for maior que data final, data final será a mesma da data inicio
                //Criar mensageria ao invés de atribuir automaticamente a data
                if(task.StartDate > DateTime.Now.Date)
                {
                    task.FinishDate = task.StartDate;
                }
                else
                {
                    task.FinishDate = DateTime.Now.Date;
                }
                   
            }

                _taskRepository.Update(task);
        }

        public ITask GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);

        }

        public IEnumerable<ITask> ListSearchName(string name)
        {
            return _taskRepository.ListSearchName(name);
        }
    
    }
}
