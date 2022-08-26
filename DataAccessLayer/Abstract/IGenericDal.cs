
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        // normalde bu insert metotlarını her bir interface'in içine kendis parametresine göre yapabiliriz ama bu saçma bir hareket
        // çünkü aralarındaki tek fark parametre. ondan kaynaklı bir tane generic interface i oluşturulur ve kod tekrarı önlerni.
        // bu metotlara diğer interfacelerin ulaşabilmesi için ise bu diğerlerine miras verir.
        // // for ex : IGuideDal.
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
    }
}
