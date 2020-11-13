using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace vectorBackend.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonIgnore] 
        [MinLength(6)]
        public string Password { get; set; } 
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName  { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string VK { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [JsonIgnore]
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