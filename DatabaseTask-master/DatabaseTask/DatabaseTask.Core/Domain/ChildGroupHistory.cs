namespace DatabaseTask.Core.Domain
{
    public class ChildGroupHistory
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<Child> Childs { get; set; }
            = new List<Child>();
        public IEnumerable<Group> Groups { get; set; }
            = new List<Group>();
    }
}
