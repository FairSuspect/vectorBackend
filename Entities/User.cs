using System;



namespace vectorBackend.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; } 
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public string PhoneNumber { get; set; }
        public string VK { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public DateTime DateCreatedAt { get; set; }

        public User()
        {
            DateCreatedAt = DateTime.UtcNow;
            RoleId = Role.User.Id;
        }
    }
}