namespace Practice.Contracts.User
{
    public class CreateUserRequest
    {
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public string Password { get; set; } = null!;
        public string? Location { get; set; }

        public int RoleId { get; set; }
    }
}
