namespace BreakpointApp.Core.Entities
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }

    }
}
