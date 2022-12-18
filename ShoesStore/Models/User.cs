using System.ComponentModel.DataAnnotations;

namespace ShoesStore.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        public string Origine_User { get; set; }
       
        [Required, EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Parola { get; set; }
        

    }
}
