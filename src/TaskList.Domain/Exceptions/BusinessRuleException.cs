namespace TaskList.Domain.Exceptions
{
    public class BusinessRuleException : ApplicationException
    {
        public BusinessRuleException(string message) : base(message)
        {
        }
    }
}
