using System.ComponentModel.DataAnnotations;

namespace ShoesStore.Models
{
    public class Produs
    {
        [Key]
        public int Id_Produs { get; set; }
        public string Nume_Model { get; set; }
        public string Tip { get; set; }
        public string? ImageURL { get; set; }

        public Brand? Brand { get; set; }
        public int Id_Brand { get; set; }

    }
}
