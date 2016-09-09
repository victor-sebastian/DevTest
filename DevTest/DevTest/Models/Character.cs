using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Models
{
    [Table("Character")]
    public class Character
    {        
        public Character()
        {
            
        }

        [Key]
        public Guid CharacterId { get; set; }

        [Required(ErrorMessage="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Race and Class is required")]
        [DisplayName("Race & Class")]
        public string Race { get; set; }

        [Required(ErrorMessage = "MP is required")]
        [DisplayName("MP")]
        public int ManaPoints { get; set; }

        [Required(ErrorMessage = "HP is required")]
        [DisplayName("HP")]
        public int HitPoints { get; set; }

        [Required(ErrorMessage = "Strength is required")]
        public int Strength { get; set; }

        [Required(ErrorMessage = "Stamina is required")]
        public int Stamina { get; set; }

        [Required(ErrorMessage = "Intellect is required")]
        public int Intellect { get; set; }

        [Required(ErrorMessage = "Agility is required")]
        public int Agility { get; set; }


        public DateTime DateAdded { get; set; }
    }

}
