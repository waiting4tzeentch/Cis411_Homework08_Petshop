using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cis411_Homework08_Petshop.Models
{
    public class Animal
    {
        public Int32 AnimalID { get; set; }

        [Required()]
        public String AnimalName { get; set; }

        [DisplayName("Animal Species")]
        [Required()]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public String AnimalSpecies { get; set; }

        [DisplayName("Animal Description")]
        public String AnimalDescription { get; set; }

        [Required()]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        [DisplayName("Subspecies")]
        public String SubSpecies { get; set; }

        [Required()]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public float Price { get; set; }
    }
}