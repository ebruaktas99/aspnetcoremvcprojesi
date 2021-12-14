using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoremMvcDepartman.Models
{
    // Projeye Entity Core, Core Design, SQL Server, Core Tools eklendi Nugetten.
    public class Departman
    {
        /*Buraya yeni bir prop eklemek için :
           ***Prop yazılır
           ***add-migration yenisutun
           ***update-database
           */

        /*
         Buradan bir prop silmek için :

        prop silinir ve kaydedilir
        yeni migration eklenir.
        update database
         
         
         */
     [Key]
        public int ID { get; set; }
        public string DepartmanAd { get; set; }

        //1-n ilişki : Bir departmanda birden fazla personel olabilir.
        //Bu ilişkiyi migrationa bildirmek gerekiyor. add-migration test1
         public List<Personel> personels { get; set; }

    }
}
