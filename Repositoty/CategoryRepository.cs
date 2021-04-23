using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Models;

namespace ASP.NETCORE.Repositoty
{
    public class CategoryRepository 
    {
        private GlobalToyzContext _ctx = null;
        
        //DI 
        public CategoryRepository(GlobalToyzContext ctx)
        {
            _ctx = ctx;
        }
        public List<Category> getAllCategories()
        {
            return _ctx.Categories.ToList();
        }
    }
}
