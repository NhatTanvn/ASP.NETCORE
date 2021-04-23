using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCORE.Models
{
    public partial class ShoppingCart
    {
        public string CCartId { get; set; }
        public string CToyId { get; set; }
        public short SiQty { get; set; }

        public virtual Toy CToy { get; set; }
    }
}
