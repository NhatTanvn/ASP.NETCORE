using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Models;

namespace ASP.NETCORE.Services
{
    public interface ILayoutModelService
    {
        List<Category> getAllCategories();     

    }
}
