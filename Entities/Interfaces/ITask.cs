using TasksWithBD.Entities.Enums;

namespace TasksWithBD.Entities.Interfaces
{
    public interface ITask
    {
        int Id { get; set; }
        String Name { get; set; }
        String Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime StartDate { get; set; }
        DateTime? FinishDate { get; set; }
        OrderStatus Status { get; set; }

    }
}
