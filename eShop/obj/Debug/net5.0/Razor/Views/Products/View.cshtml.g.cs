#pragma checksum "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869dd9eeabff6570cc3314aad9483c80849f8892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_View), @"mvc.1.0.view", @"/Views/Products/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869dd9eeabff6570cc3314aad9483c80849f8892", @"/Views/Products/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679f7e604f38096cc79c48db948f8070f3ef9de2", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShop.ViewModels.ProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
  
    ViewData["Title"] = "View Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    input {
        height: 25px;
        width: 50px;
        text-align: center;
        font-size: 16px;
        border: 1px solid #ddd;
        border-radius: 2px;
        display: inline-block;
    }
</style>

<section class=""inner_page_head"">
    <div class=""container_fuild"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""full"">
                    <h3>View Product</h3>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""product_section layout_padding"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869dd9eeabff6570cc3314aad9483c80849f88924821", async() => {
                WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"img-box\" style=\"float:left;\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869dd9eeabff6570cc3314aad9483c80849f88925193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 874, "~/images/", 874, 9, true);
#nullable restore
#line 35 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
AddHtmlAttributeValue("", 883, Model.Product.Image, 883, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 39 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 42 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 45 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 48 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Category.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 51 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 54 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 57 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 60 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 63 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 66 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 69 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayNameFor(model => model.Product.Material));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 72 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
               Write(Html.DisplayFor(model => model.Product.Material));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    Quantity\r\n                </dt>\r\n                <dd class=\"col-sm-2\">\r\n                    <input hidden");
                BeginWriteAttribute("value", " value=\"", 2728, "\"", 2745, 1);
#nullable restore
#line 78 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
WriteAttributeValue("", 2736, Model.Id, 2736, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\r\n                    <input hidden");
                BeginWriteAttribute("value", " value=\"", 2794, "\"", 2813, 1);
#nullable restore
#line 79 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
WriteAttributeValue("", 2802, Model.Name, 2802, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" />\r\n                    <input hidden");
                BeginWriteAttribute("value", " value=\"", 2864, "\"", 2884, 1);
#nullable restore
#line 80 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
WriteAttributeValue("", 2872, Model.Price, 2872, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Price"" />
                    <input id=""quantity"" type=""number"" value=""1"" min=""1"" name=""Quantity"" />
                </dd>
            </dl>
            <div class=""row float-right"">
                <button type=""submit"" style=""width:150px;height:50px;color:white;background-color:#f7444e;border:0px;border-radius:0px;text-align:center;"">
                    Add to Cart
                </button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "H:\Downloads\Website (1)\Website\eShop\Views\Products\View.cshtml"
AddHtmlAttributeValue("", 708, Url.Action("AddToCart","Products"), 708, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShop.ViewModels.ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
