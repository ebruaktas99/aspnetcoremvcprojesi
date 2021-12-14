using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoremMvcDepartman.Models
{
    public class Personel
    {
        [Key]
        public int PerID { get; set; }
        public string PerAd { get; set; }
        public string PerSoyad { get; set; }
        public string PerSehir { get; set; }
        
        //1-n ilişki için 
        public Departman depart { get; set; }
    }
}
