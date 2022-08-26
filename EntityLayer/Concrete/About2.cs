using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// about sayfasının en alt kısmı ile ilk kısmı part part ayırdık.
// syafanın en alt kısmında 3 image, 3 büyük başlık,3 küçük başlık, 3 açıklama mevcut 
namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2ID { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
