using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.BingMaps.Models
{
    public class Houses
    {
        [Key]
        public int IDHouse { get; set; }

        public string LabelHouse { get; set; }

        [Required]
        public int TypeHouse { get; set; }

        [Required]
        public string Address { get; set; }

    }
}