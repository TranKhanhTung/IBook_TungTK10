#pragma checksum "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7d1ee7d383eb0cfe7144d80f95ef3f01b7ed1662c5a1992fcf2afa0699af0273"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IBook.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(IBook.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace IBook.Areas.Identity.Pages.Account
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\_ViewImports.cshtml"
using IBook.Areas.Identity

    ;
#line 3 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

    ;
#line 1 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using IBook.Areas.Identity.Pages.Account

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d1ee7d383eb0cfe7144d80f95ef3f01b7ed1662c5a1992fcf2afa0699af0273", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4e4ab3f95362833f47f73de20ef0113f0ed71c2d483099abfbae642e17e8ff53", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ec8753bf33838a9db0d1ceea73eb5054c7bb252a0ba05229e2e1147597d13645", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden

            BeginContext(82, 40, true);
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(123, 17, false);
            Write(
#line 8 "D:\BaoCao\zFile2\Website bán sách online\DoAnWeb - Final\IBook\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                             ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(140, 91, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591