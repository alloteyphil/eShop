#pragma checksum "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f70c30987c210700e44566cbca3d8e3f1ead62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "H:\Downloads\Website (1)\Website\eShop\Views\_ViewImports.cshtml"
using eShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Downloads\Website (1)\Website\eShop\Views\_ViewImports.cshtml"
using eShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f70c30987c210700e44566cbca3d8e3f1ead62", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679f7e604f38096cc79c48db948f8070f3ef9de2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShop.ViewModels.OrdersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""inner_page_head"">
    <div class=""container_fuild"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""full"">
                    <h3>Orders</h3>
                </div>
            </div>
        </div>
    </div>
</section>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Order Id
            </th>
            <th>
                Placed By
            </th>
            <th>
                Delivery Address
            </th>
            <th>
                Date and Time
            </th>
            <th>
                Action
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 40 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
         foreach (var order in Model.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
               Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
               Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
               Write(order.DeliveryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
               Write(order.DateTime.ToString("dd/MM/yyyy hh:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1340, 1);
#nullable restore
#line 56 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1291, Url.Action("View","Orders",new { Id = order.Id}), 1291, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "H:\Downloads\Website (1)\Website\eShop\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShop.ViewModels.OrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591