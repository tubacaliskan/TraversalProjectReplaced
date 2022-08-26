using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// contact us kısmı iki bölümden oluşturuluyor 
// 1 - bilgiler
// 2 - mail atma 
// şu anlık ikisi için de iki tan econtact us class ı açacakmışız gibi duruyor
// fata şuan sadece 1 tanesini yaptık.
// neden contact us sayfasındaki image ve title ı koymadık onu nalayamadım
namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
