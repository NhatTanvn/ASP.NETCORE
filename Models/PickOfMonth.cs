using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCORE.Models
{
    public partial class PickOfMonth
    {
        public string CToyId { get; set; }
        public short SiMonth { get; set; }
        public int IYear { get; set; }
        public int? ITotalSold { get; set; }

        public virtual Toy CToy { get; set; }
    }
}
