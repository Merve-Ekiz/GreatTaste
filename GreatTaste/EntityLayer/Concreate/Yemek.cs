using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class Yemek
    {
        [Key]
        public int YemekId { get; set; }
        public string YemekName { get; set; }
        public string YemekContent { get; set; }
        public int SebzeId { get; set; }
        public Sebze Sebze { get; set; }
    }
}
