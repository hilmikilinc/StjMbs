#pragma checksum "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2abc0237bd57ea84232140eb94d68e31388e02c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI;

#line default
#line hidden
#line 2 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2abc0237bd57ea84232140eb94d68e31388e02c", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49c025ac10c31b13e794665d09e67fc92ea6ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abis.Mbs.MvcWebUI.Models.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 208, true);
            WriteLiteral("<div>\r\n    <table class=\"table table-responsive\">\r\n        <tr>\r\n            <td>Product Name</td>\r\n            <td>Unit Price</td>\r\n            <td>Units In Stock</td>\r\n            <td></td>\r\n        </tr>\r\n");
            EndContext();
#line 14 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(372, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(411, 19, false);
#line 17 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(430, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(458, 17, false);
#line 18 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(475, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(503, 20, false);
#line 19 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(523, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(550, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2abc0237bd57ea84232140eb94d68e31388e02c6129", async() => {
                BeginContext(670, 11, true);
                WriteLiteral("add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
                                                                                                            WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(685, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(722, 41, true);
            WriteLiteral("    </table>\r\n</div>\r\n<product-list-pager");
            EndContext();
            BeginWriteAttribute("current-category", " current-category=\"", 763, "\"", 804, 1);
#line 25 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 782, Model.CurrentCategory, 782, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("current-page", "\r\n                    current-page=\"", 805, "\"", 859, 1);
#line 26 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 841, Model.CurrentPage, 841, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("page-count", "\r\n                    page-count=\"", 860, "\"", 910, 1);
#line 27 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 894, Model.PageCount, 894, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("page-size", "\r\n                    page-size=\"", 911, "\"", 959, 1);
#line 28 "C:\Users\Casper\Documents\MBS_FINAL\Abis.Mbs.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 944, Model.PageSize, 944, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(960, 22, true);
            WriteLiteral("></product-list-pager>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abis.Mbs.MvcWebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
