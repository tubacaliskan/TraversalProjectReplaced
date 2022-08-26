using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{

    // concrete tarafında yapılacak business methodlarının imzalarını burada tanımlıyoruz 
    // ne alaka yani ?????

    public interface IGenericService<T>
    {
        void Tadd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
            // business tarafında tanımlayacağımız bütün methodlar, business tarafına gelmeden
            // burda generic service den geçecek sonra business'da concrete'e gelecek
    }
}
