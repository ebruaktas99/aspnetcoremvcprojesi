using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoremMvcDepartman.Models
{
    public class Context :DbContext
    {
        //Veritabındaki tabloların oluşmasını sağlayan sınıf.

        //Aspnetcore da bağlantı adresini bu şekilde yapıyoruz. Normalde web.configde yapıyorduk.(2 tane \ ister.)

        //Projeye migration ekle : add-migration deneme(ismi)
        //update-database adımı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-81USL0I\\SQLEXPRESS; database=corepersonel; integrated security=true");
        }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }


    }
}
