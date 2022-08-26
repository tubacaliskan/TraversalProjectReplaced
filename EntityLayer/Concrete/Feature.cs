using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ana sayfada öne çıkan bilgiler için bu classı oluşturduk
namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public String Title { get; set; }
        public String Post1Description { get; set; }
        public String Post1Image { get; set; }
        public bool Status { get; set; }
    }
}
