namespace TaskList.Domain.DTOs.Requests
{
    public class CreateTaskRequestDto
    {
        public required string Name { get; set; }
        public int? UserAssignedId { get; set; }
    }
}
