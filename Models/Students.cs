using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HustlerNation.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First name:", Prompt = "Enter first name")]
        [DataType(DataType.Text)]

        public string F_name { get; set; }
        [Required]
        [Display(Name = "Second name:", Prompt = "Enter second name")]
        [DataType(DataType.Text)]
        public string S_name { get; set; }
        [Required]
        [Display(Name = "Age:", Prompt = "Enter age")]
        [DataType(DataType.Text)]
        public int Age { get; set; }
    }
}
