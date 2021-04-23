using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Models;
using ASP.NETCORE.Repositoty;

namespace ASP.NETCORE.Services
{
    public class LayoutModelService : ILayoutModelService
    {
        private CategoryRepository _catagoryrepository = null;

        //DI
        public LayoutModelService(CategoryRepository catagoryrepository)
        {
            _catagoryrepository = catagoryrepository;
        }
        public List<Category> getAllCategories()
        {
            return _catagoryrepository.getAllCategories();
        }

    }
}
