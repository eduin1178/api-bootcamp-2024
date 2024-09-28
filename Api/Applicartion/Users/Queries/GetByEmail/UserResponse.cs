namespace Api.Applicartion.Users.Queries
{

    public record UserResponse
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
    }
}
