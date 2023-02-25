using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Sebze
    {
        [Key]
        public int SebzeId { get; set; }
        public string SebzeName { get; set; }
        public string SebzeFoto { get; set; }
        public List<Yemek> Yemeks { get; set; }
  
    }
}
