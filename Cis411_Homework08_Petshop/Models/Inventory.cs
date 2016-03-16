using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cis411_Homework08_Petshop.Models
{
    public class Inventory
    {
        public Int32 InventoryID { get; set; }

        [Required()]
        public virtual Animal Animal { get; set; }

        public DateTime DateIn { get; set; }

        public DateTime DateOut { get; set; }

        [Required()]
        public Boolean Available { get; set; }
    }
}