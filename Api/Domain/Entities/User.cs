namespace Api.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Status { get; set; }
    }
}
