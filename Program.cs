using TasksWithBD.Data;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Services;

namespace TasksWithBD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //// Testes
            //var repository = new TaskRepository();
            //var service = new TaskService(repository);

            //// Cria uma task de teste
            //var task = new SimpleTask
            //{
            //    Name = "Teste Task",
            //    Description = "Teste de inserção",
            //    StartDate = DateTime.Now,
            //    Status = OrderStatus.Pending
            //};

            //// Chama o método da Service
            //service.CreateTask(task);




            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}