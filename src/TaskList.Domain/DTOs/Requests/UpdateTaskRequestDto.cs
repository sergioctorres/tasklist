namespace TaskList.Domain.DTOs.Requests
{
    public class UpdateTaskRequestDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int? UserAssignedId { get; set; }
    }
}
