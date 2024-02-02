namespace TaskList.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public void Active() => IsActive = true;
        public void Inactive() => IsActive = false;
        public void LogicalDelete()
        {
            Inactive();
            UpdatedAt = DateTimeOffset.UtcNow;
        }
    }
}
