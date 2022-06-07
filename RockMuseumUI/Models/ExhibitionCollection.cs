using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// SEBASTIAN
namespace RockMuseumUI.Models
{
    public class ExhibitionCollection
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter proper Title name")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="Please enter Title name at min 3 characters and at max 60 characters")]
        public string Title { get; set; }

        [Display(Name ="Length of Exhibition")]
        public int Length { get; set; }

        [Display(Name ="Release date")]
        [DataType(DataType.Date)]
        public DateTime Releasedate { get; set; }

        [RegularExpression(@"[1-5]+$",ErrorMessage ="Rating Must be between 1 to 5")]
        [Required(ErrorMessage = "Please enter a Rating of the Exhibiton")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Please enter Title name at min 3 characters and at max 60 characters")]
        public string Rating { get; set; }

    }
}

