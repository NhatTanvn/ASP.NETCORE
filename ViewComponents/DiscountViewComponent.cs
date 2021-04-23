using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCORE.ViewComponents
{
    public class DiscountViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int[] item = { 5, 10, 20, 30, 40, 60 };
            return View(item);
        }
    }
}
