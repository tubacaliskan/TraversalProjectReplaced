using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // normalde her entity için bunu tanımlamak zorunda değiliz fakat olurda IGenericService içerisinde bulunan
    // metotların dışında bir metot kullanılmak istenildiğinde ayrı interfaceler açmak zorunda kalıcaz.  
    public interface IAboutService : IGenericService<About>
    {
    }
}
