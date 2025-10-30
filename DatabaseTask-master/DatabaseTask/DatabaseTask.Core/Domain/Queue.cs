namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        public Guid Id { get; set; }
        public DateTime RegDate { get; set; }

        public IEnumerable<Child> Childs { get; set; }
            = new List<Child>();

        public IEnumerable<Group> Groups { get; set; }
            = new List<Group>();
    }
}
