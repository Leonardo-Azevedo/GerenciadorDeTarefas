//Classe que aplica a regra de negócio do sistema


using System.Threading.Tasks;
using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Entities.Interfaces;
using TasksWithBD.Utils__Helpers_;

namespace TasksWithBD.Services
{
    public class TaskService
    {
        private readonly TaskRepository _taskRepository;
        public TaskService(TaskRepository  taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ServiceResult CreateTask(ITask task)
        {
            task.CreateDate = DateTime.Now.Date;

            if (string.IsNullOrWhiteSpace(task.Name))
            {
                //proibido task com nome vazio
                return new ServiceResult(false, "Task name can not be null or empty.");
            }

            if (task.StartDate > task.FinishDate)
            {
                //não pode criar uma task onde o star começa depois do finish
                return new ServiceResult(false, "Start date can't be greater than the finish date.");
            }

            try
            {
                _taskRepository.Add(task);
                return new ServiceResult(true, "Task created!");
            }
            catch (Exception ex)
            {
                return new ServiceResult(false, $"Error updating task: {ex.Message}");
            }
            
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

        public ServiceResult UpdateTask(ITask task)
        {
            if (task.Status == OrderStatus.Finished && task.FinishDate == null)
            {
                //Se data inicio for maior que data final, data final será a mesma da data inicio
                //Criar mensageria ao invés de atribuir automaticamente a data
                if(task.StartDate > DateTime.Now.Date)
                {
                    return new ServiceResult(false, "The end date is before the start date.");
                }
                else
                { 
                    task.FinishDate = DateTime.Now.Date;
                }
                   
            }

            try
            {
                _taskRepository.Update(task);
                return new ServiceResult(true, "Task updated successfully!");
            }
            catch (Exception ex)
            {
                return new ServiceResult(false, $"Error updating task: {ex.Message}");
            }
        }

        public ITask GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);

        }

        public IEnumerable<ITask> ListWithFilter(string name = null, OrderStatus? status = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return _taskRepository.ListWithFilter(name, status, startDate, endDate);
        }

        public void ExportToExcel(IEnumerable<ITask> listTasks)
        {
            _taskRepository.ExportToExcel(listTasks);
        }


    }
}
