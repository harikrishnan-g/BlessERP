namespace BlessERP.API.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AssignedTo { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Employees AssignedToNavigation { get; set; }
        public virtual Employees CreatedByNavigation { get; set; }
    }
}
