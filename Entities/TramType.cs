using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace vectorBackend.Entities
{
    public class TramType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // public string PhoneNumber { get; set; }
        // public string VK { get; set; }
        // [EmailAddress]
        // [Required]
        // public string Email { get; set; }
        // [JsonIgnore]
        // public int RoleId { get; set; }
        // public virtual Role Role { get; set; }
        // public DateTime DateCreatedAt { get; set; }


    }
}