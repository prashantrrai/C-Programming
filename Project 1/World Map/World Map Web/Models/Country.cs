using System.ComponentModel.DataAnnotations;

namespace World_Map_Web.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]

        public string CountryName { get; set; }
        [Required]
            
        public string Abbreviation { get; set; }
        [Required]

        public string Currency { get; set; }
        [Required]

        public int DialingCode { get; set; }
        [Required]

        public string TimeZone { get; set; }
        public string CountryCapital { get; set; }
        [Required]

        public string Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set;} = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
        public bool isActive { get; set;} = false;
    }
}
