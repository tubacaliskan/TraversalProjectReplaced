using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    // normalde her bir entitiy için de manager tanımlanabilir ama biz şuan bu proje için ihtiyaç oldulça tanımlama yapacağız. 

    public class AboutManager : IAboutService
    {
        // service' i implemen etmemizi istedi ve bizde ettik. 

        // şuan burada bir şekilde IAboutDal'a ulaşmamız gerekiyor çünkü interface'de değerler IAboutDal'da.
        //bundan kaynaklı maanger içeriisnde bu IAbout'dal'ı tanımlamamız gerekir.
        // bunub da contructor ile yapabiliriz

        IAboutDal _aboutDal; // burada dependency injection kullanacağız.
                            // amaç, gelen entitiy'i karşılamak
                            // hangi etnitiy geldiyse o entitiy'e ait repolara(sanırsam reposity) ulaşmak için 
                            // dependency injection dedğimiz kod bloğunu kullanacağız.
                            // bunun için constructor bloğuna ihtiyacımız var

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        // 22 ile 32 arası dependeny injection olarak adlandırılıyor.
        // bu injection sayesinde IAboutDal'ın miras aldığı, IGenericDal interface'inin metotolarını da kullanabiliyoruz.
        // IAboutDal'ı çağırdığımızda yani nokta koyduğumuzda IGenericDal'daki insert, delete metottlarına ulaşabilcez 


        //burada yazan metotlar IGenericService'deki metotlar ama neden 

        public void Tadd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
