using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature2
    {
        [Key]
        public int Feature2ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public bool Status { get; set; }
    }
}
