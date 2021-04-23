using ASP.NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCORE.Repositoty
{
    public class ToysRepositoty
    {
        //GlobalToyzContext ctx = new GlobalToyzContext();
        //Dependecy Injection
        private GlobalToyzContext ctx = null;
        public ToysRepositoty(GlobalToyzContext _ctx)
        {
            ctx = _ctx;
        }
        public ToysRepositoty()
        {
            ctx = new GlobalToyzContext();
        }
        public List<Toy> getAllToys()
        {
            return ctx.Toys.ToList();
        }
        public List<Toy> getAllSpecial()
        {
            //lamda
            return ctx.Toys.Where(t =>t.MToyRate <13).Take(5).ToList();
            //return ctx.Toys.OrderBy(t => t.MToyRate).Take(5).ToList();
        }
        public List<Toy> filterByCategory(string id)
        {
            return ctx.Toys.Where(t => t.CCategoryId == id).ToList();
        }
        public Toy getDetails(string id)
        {
            // 0 or 1 do id la primary key
            return ctx.Toys.Where(t => t.CToyId == id).SingleOrDefault();
        }
    }
}
