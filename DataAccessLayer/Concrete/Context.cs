using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext 
    {
        // bu metodun bu şekilde yazılması genel bir syntext kuralı gibi düşünülebilir 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // kendi sql adresimi kopyalarken arada bulunan \ ın yanına bir tane daha \ koydum. aralara ; koymak farz
            // database yazan sql de oluşturulacak database'in ismi
            // integrated security olan kısım ise dbye şifreli giriş için. bizim ki şuan şifresiz 
            optionsBuilder.UseSqlServer("server= ZEYNEP\\SQLEXPRESS;database=TraversalDB;integrated security = true;");
        }
        // property'leri tanımlama nedenimiz: entityleri sql e yansıtmamız için gerekli olan köprü
        //DbSet<Entity parametresi(açılan classlar)>
        // abouts olarak yazılan yer tablo ismi olarak create edilir. 
        // abouts  -> tablonun ismi about -> (yalın hal) entity ismi
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
