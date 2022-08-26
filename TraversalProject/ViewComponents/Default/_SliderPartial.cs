using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// w3layout sitesinden aldığımız html dosyalarında index çok kalabalık.
// biz ana sayfa üzerindeki verileri datalardan seçeçecğimiz için bu şekilde view componentslar oluşturduk.
// bu aşağıdaki yazım şşekli de yazım sitili gibi bir şey 
namespace TraversalProject.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
