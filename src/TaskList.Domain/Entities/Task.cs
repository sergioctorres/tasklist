namespace TaskList.Domain.Entities
{
    public class Task : BaseEntity
    {
        public required string Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int? UserAssignedId { get; set; }
        public User? UserAssigned { get; set; }

        public void Start() => StartDate = DateTimeOffset.UtcNow;
        public void End() => EndDate = DateTimeOffset.UtcNow;
        public void AssignUser(int userId) => UserAssignedId = userId;
    }
}
