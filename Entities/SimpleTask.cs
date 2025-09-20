using TasksWithBD.Entities.Enums;
using TasksWithBD.Entities.Interfaces;

namespace TasksWithBD.Entities
{
    public class SimpleTask : ITask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime? FinishDate { get; set; }
        public OrderStatus Status { get; set; }

        public SimpleTask () { }

        public SimpleTask(string name, string description, DateTime createDate,
                      DateTime startDate, DateTime? finishDate, OrderStatus status)
        {
            Name = name;
            Description = description;
            CreateDate = createDate;
            StartDate = startDate;
            FinishDate = finishDate;
            Status = status;
        }
    }
}
