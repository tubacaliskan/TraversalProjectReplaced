using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ana sayfada bulunan mail adresini yazma kısmı
namespace EntityLayer.Concrete
{
    public class NewsLetter
    {
        [Key]
        public int NesaLetterID { get; set; }
        public string Mail { get; set; }
    }
}
