using System.ComponentModel.DataAnnotations;

namespace CoreMvcCodeFirst.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        public string RollNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please Enter Numeric Value")]
        public int Class { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Transport { get; set; }

        public bool Cricket { get; set; }

        // [Display(Name ="VollyBall")]
        public bool Football { get; set; }

        public bool Kabadi { get; set; }

        public bool Coco { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public byte[] Photo { get; set; }
    }
}
