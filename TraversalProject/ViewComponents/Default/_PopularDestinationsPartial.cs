using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal()); // şurad ne oluyor en ufak bir fikrim yok
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
