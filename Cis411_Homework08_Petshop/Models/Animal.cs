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


        [DisplayName("Animal Species")]
        [Required()]
        [StringLength(maximumLength: 20, MinimumLength =3)]
        public String AnimalSpecies { get; set; }

        [DisplayName("Animal Description")]
        public String AnimalDescrition { get; set; }

        [Required()]
        public List<SubSpecies> SubSpecies { get; set; }
    }

    public class SubSpecies : Animal
    {
        public Int32 SpeciesID { get; set; }

        [Required()]
        [DisplayName("Breed Name")]
        public String SpeciesName { get; set; }

        [Required()]
        [DisplayName("Species Description")]
        public String SpeciesDescription { get; set; }
    }
}