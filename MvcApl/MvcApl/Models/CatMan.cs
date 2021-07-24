using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApl.Models
{
    public class CatMan
    {
        [Key]        
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        public CatMan(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }


}