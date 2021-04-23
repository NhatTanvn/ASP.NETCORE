using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCORE.Models
{
    public partial class VwHoadon
    {
        public string COrderNo { get; set; }
        public DateTime DOrderDate { get; set; }
        public decimal? MTotalCost { get; set; }
        public string CShopperId { get; set; }
        public string CCartId { get; set; }
        public string VFirstName { get; set; }
        public string VLastName { get; set; }
        public string CToyId { get; set; }
        public short SiQty { get; set; }
        public string VToyName { get; set; }
        public decimal MToyRate { get; set; }
        public decimal? LineTotal { get; set; }
    }
}
