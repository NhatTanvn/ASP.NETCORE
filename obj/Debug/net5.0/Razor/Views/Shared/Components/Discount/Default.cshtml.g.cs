#pragma checksum "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\Shared\Components\Discount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df7de147c3d7650f53a46e22033afa1a2aed7d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Discount_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Discount/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\_ViewImports.cshtml"
using ASP.NETCORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\_ViewImports.cshtml"
using ASP.NETCORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7de147c3d7650f53a46e22033afa1a2aed7d2d", @"/Views/Shared/Components/Discount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04246c682ecc3bdc2b987f9a29e3ff02f063e3c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Discount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Discount-->\r\n<div class=\"left-side\">\r\n    <h3 class=\"agileits-sear-head\">Discount</h3>\r\n    <ul>\r\n");
#nullable restore
#line 6 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\Shared\Components\Discount\Default.cshtml"
         foreach (var items in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 9 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\Shared\Components\Discount\Default.cshtml"
       Write(Html.CheckBox(items.ToString(), false, new { @class = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"span\">");
#nullable restore
#line 10 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\Shared\Components\Discount\Default.cshtml"
                          Write(items);

#line default
#line hidden
#nullable disable
            WriteLiteral("% or more</span>\r\n        </li>\r\n");
#nullable restore
#line 12 "E:\NIIT\ASP.NET\ASP.NETCORE\ASP.NETCORE\Views\Shared\Components\Discount\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
