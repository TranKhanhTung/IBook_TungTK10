#pragma checksum "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "122fe4a2417222cbb0e41b072676793f3e68592629fab92dddf5bc12742d159c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_ShoppingCarts_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/ShoppingCarts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/ShoppingCarts/Details.cshtml", typeof(AspNetCore.Areas_Customer_Views_ShoppingCarts_Details))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\_ViewImports.cshtml"
using IBook

    ;
#line 2 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\_ViewImports.cshtml"
using IBook.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"122fe4a2417222cbb0e41b072676793f3e68592629fab92dddf5bc12742d159c", @"/Areas/Customer/Views/ShoppingCarts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"13ff5ed9f1de8ec7d33e8a43d977a19d8420d91ead71623a9d1031ba639caf72", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_ShoppingCarts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IBook.Models.OrderBookDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Customer/Views/Shared/_Layout.cshtml";

#line default
#line hidden

            BeginContext(144, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>OrderBookDetail</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(274, 40, false);
            Write(
#line 15 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
             Html.DisplayNameFor(model => model.Book)

#line default
#line hidden
            );
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(358, 45, false);
            Write(
#line 18 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
             Html.DisplayFor(model => model.Book.ImageUrl)

#line default
#line hidden
            );
            EndContext();
            BeginContext(403, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(447, 45, false);
            Write(
#line 21 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
             Html.DisplayNameFor(model => model.OrderBook)

#line default
#line hidden
            );
            EndContext();
            BeginContext(492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(536, 57, false);
            Write(
#line 24 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
             Html.DisplayFor(model => model.OrderBook.CustomerAddress)

#line default
#line hidden
            );
            EndContext();
            BeginContext(593, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(641, 68, false);
            Write(
#line 29 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\ShoppingCarts\Details.cshtml"
     Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ })

#line default
#line hidden
            );
            EndContext();
            BeginContext(709, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(717, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122fe4a2417222cbb0e41b072676793f3e68592629fab92dddf5bc12742d159c6720", async() => {
                BeginContext(739, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(755, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IBook.Models.OrderBookDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
