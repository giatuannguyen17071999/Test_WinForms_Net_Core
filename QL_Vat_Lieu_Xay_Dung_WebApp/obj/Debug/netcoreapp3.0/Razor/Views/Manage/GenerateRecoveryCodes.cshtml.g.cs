#pragma checksum "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce496d1e3284d838aa3325276d7ff45e906d2ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_GenerateRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
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
#line 1 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce496d1e3284d838aa3325276d7ff45e906d2ca", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e40dcd6b611074ec3c6452503badeec1605a60", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenerateRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>");
#nullable restore
#line 8 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#nullable restore
#line 20 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Count(); row += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <code>");
#nullable restore
#line 22 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code>");
#nullable restore
#line 22 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br />\n");
#nullable restore
#line 23 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Manage\GenerateRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenerateRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
