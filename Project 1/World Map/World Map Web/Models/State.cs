using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace World_Map_Web.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        public string StateName { get; set; }

        [Required]
        public string Abbreviation { get; set; }

        [Required]
        public string StateCapital { get; set; }

        [Required]
        [ForeignKey("country")]
        public int CountryId { get; set; }

        public Country country { get; set; }

        //public virtual Country Country { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set;} = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set;} = DateTime.Now;
        public bool IsActive { get; set; } = false;

        public State()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            IsActive = false;
        }
    }
}
