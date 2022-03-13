using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2.Models
{
    public class Empl
    {
        [Key]
        [Required]
        public int  id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        
        public int Age { get; set; }
        [Required]
        public int Phone { get; set; }

        [Required]
        public int Address { get; set; }

    }
}
