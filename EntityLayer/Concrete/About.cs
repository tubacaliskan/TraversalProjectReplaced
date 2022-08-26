using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // sayfada ekranda gördüğümüz her bir elemanı teket teker buraya yazıyoruz 
    public class About
    {
        // key'i kullanarak ID'nin primary key olduğunu belirttik.
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image1 { get; set; }
        public bool Status { get; set; }
    }
}
