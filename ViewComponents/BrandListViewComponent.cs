using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NETCORE.Repositoty;
using ASP.NETCORE.Models;

namespace ASP.NETCORE.ViewComponents
{
    public class BrandListViewComponent : ViewComponent
    {
        private BrandRepository _brandRepository = null;

        public BrandListViewComponent(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        // do cac component rieng biet nen chay theo co che dong bo ca trang index se cham
        // chay theo bat dong bo thi cho nao xong thi tuong tac duoc, k xong thi trang cho do
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //call method to get data  
            var items = await getAllToyBrands();
            return View(items);
        }
        public Task<List<ToyBrand>> getAllToyBrands()
        {
            return Task.Run(() => _brandRepository.getAllBrands());
        }

    }
}
