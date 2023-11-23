using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace World_Map_Web.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public string CityName { get; set; }

        public string Coordinates { get; set; }

        [Required]
        [ForeignKey("State")]
        public int StateId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = false;

        public City()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            IsActive = false;
        }
    }
}
