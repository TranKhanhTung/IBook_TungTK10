#pragma checksum "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ee99fddf46bcd690d288862dfb1920070ddc022a027aecee08dfceed6050b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Index))]
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
#line 1 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\_ViewImports.cshtml"
using IBook

    ;
#line 2 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\_ViewImports.cshtml"
using IBook.Models

    ;
#line 2 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
 using ReflectionIT.Mvc.Paging

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ee99fddf46bcd690d288862dfb1920070ddc022a027aecee08dfceed6050b2d", @"/Areas/Admin/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"13ff5ed9f1de8ec7d33e8a43d977a19d8420d91ead71623a9d1031ba639caf72", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<IBook.Models.Book>>
    {
        private global::AspNetCore.Areas_Admin_Views_Books_Index.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden

            BeginContext(238, 160, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Các đầu sách hiện  có</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(398, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee99fddf46bcd690d288862dfb1920070ddc022a027aecee08dfceed6050b2d5383", async() => {
                BeginContext(442, 47, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Thêm sách mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(493, 30, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n");
            EndContext();
#line 19 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden

            BeginContext(553, 46, true);
            WriteLiteral("    <p class=\"text-right\">\r\n        Tên sách: ");
            EndContext();
            BeginContext(600, 26, false);
            Write(
#line 22 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                   Html.TextBox("findstring")

#line default
#line hidden
            );
            EndContext();
            BeginContext(626, 107, true);
            WriteLiteral("\r\n        <input type=\"submit\" class=\"btn btn-outline-success my-2 my-sm-0\" value=\"Tìm kiếm\" />\r\n    </p>\r\n");
            EndContext();
#line 25 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
}

#line default
#line hidden

            BeginContext(736, 105, true);
            WriteLiteral("<table class=\"table table-striped border\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(842, 41, false);
            Write(
#line 30 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Title)

#line default
#line hidden
            );
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(939, 46, false);
            Write(
#line 33 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Quantities)

#line default
#line hidden
            );
            EndContext();
            BeginContext(985, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1041, 46, false);
            Write(
#line 36 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.CreateDate)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1087, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1143, 48, false);
            Write(
#line 39 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.ModifiedDate)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1191, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1247, 49, false);
            Write(
#line 42 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.NumberOfPages)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1352, 41, false);
            Write(
#line 45 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Price)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1449, 44, false);
            Write(
#line 48 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.ImageUrl)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1493, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1549, 46, false);
            Write(
#line 51 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.IsPurchase)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1595, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1651, 42, false);
            Write(
#line 54 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Author)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1693, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1749, 44, false);
            Write(
#line 57 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Category)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1793, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1849, 45, false);
            Write(
#line 60 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                 Html.DisplayNameFor(model => model.Publisher)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1894, 109, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden

            BeginContext(2052, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2113, 40, false);
            Write(
#line 71 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Title)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2153, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2221, 45, false);
            Write(
#line 74 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Quantities)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2266, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2334, 45, false);
            Write(
#line 77 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.CreateDate)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2379, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2447, 47, false);
            Write(
#line 80 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.ModifiedDate)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2494, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2562, 48, false);
            Write(
#line 83 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.NumberOfPages)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2610, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2678, 40, false);
            Write(
#line 86 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Price)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2718, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2835, 85, true);
            WriteLiteral("                    <a>\r\n                        <img style=\"width:50px; height:75px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2920, "\"", 2940, 1);
            WriteAttributeValue("", 2926, 
#line 91 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                                                                   item.ImageUrl

#line default
#line hidden
            , 2926, 14, false);
            EndWriteAttribute();
            BeginContext(2941, 96, true);
            WriteLiteral(" />\r\n                    </a>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3038, 45, false);
            Write(
#line 95 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.IsPurchase)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3083, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3151, 46, false);
            Write(
#line 98 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Author.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3265, 48, false);
            Write(
#line 101 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Category.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3313, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3381, 49, false);
            Write(
#line 104 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Publisher.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3430, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3497, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ee99fddf46bcd690d288862dfb1920070ddc022a027aecee08dfceed6050b2d19504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#line 107 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                                                               item.BookID

#line default
#line hidden
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3555, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 110 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
        }

#line default
#line hidden

            BeginContext(3610, 69, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav hidden class=\"col-12 text-center\">\r\n    ");
            EndContext();
            BeginContext(3680, 74, false);
            Write(
#line 114 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
     await this.Component.InvokeAsync("Pager", new { pagingList = this.Model })

#line default
#line hidden
            );
            EndContext();
            BeginContext(3754, 73, true);
            WriteLiteral("\r\n</nav>\r\n<nav class=\"col-12 text-center\" style=\"font-size: 27px;\">\r\n    ");
            EndContext();
            BeginContext(3827, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ee99fddf46bcd690d288862dfb1920070ddc022a027aecee08dfceed6050b2d22214", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Admin_Views_Books_Index.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
            __PagerViewComponentTagHelper.pagingList = 
#line 117 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Index.cshtml"
                            Model

#line default
#line hidden
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3860, 10, true);
            WriteLiteral("\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<IBook.Models.Book>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
