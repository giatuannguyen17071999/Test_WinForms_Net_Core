#pragma checksum "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\Role\Permission_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db370fe6bc55699ca9b5af316bf370cfd8282c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Permission_Modal), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Permission_Modal.cshtml")]
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
#line 1 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lockh\Desktop\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db370fe6bc55699ca9b5af316bf370cfd8282c1", @"/Areas/Admin/Views/Role/Permission_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10214bc65770daa23f4d292c05b20277ead16a9f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_Permission_Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""modal-grantpermission"" class=""bootbox modal fade modal-darkorange in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""bootbox-close-button close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Assign Permission</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-xs-12 col-md-12"">
                        <input type=""hidden"" id=""hidRoleId"" />
                        <table class=""table table-hover tree"" id=""tblFunction"">
                            <thead class=""bordered-darkorange"">
                                <tr>
                                    <th>Function name</th>
                                    <th>
                                        <label>
           ");
            WriteLiteral(@"                                 <input type=""checkbox"" id=""ckCheckAllView"" value=""{{Id}}"">
                                            <span class=""text"">View</span>
                                        </label>
                                    </th>
                                    <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllCreate"" value=""{{Id}}"">
                                            <span class=""text"">Create</span>
                                        </label>
                                    </th>
                                    <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllEdit"" value=""{{Id}}"">
                                            <span class=""text"">Update</span>
                                        </label>
                                    </th>
                            ");
            WriteLiteral(@"        <th>
                                        <label>
                                            <input type=""checkbox"" id=""ckCheckAllDelete"" value=""{{Id}}"">
                                            <span class=""text"">Delete</span>
                                        </label>
                                    </th>
                                </tr>
                            </thead>
                            <tbody id=""lst-data-function""></tbody>
                        </table>
                        <script id=""result-data-function"" type=""x-tmpl-mustache"">
                            <tr class=""treegrid-{{Id}} {{treegridparent}}"" data-id=""{{Id}}"">
                                <td>{{Name}}</td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckView"">
                                        <span class=""text"">Allow</span>
                          ");
            WriteLiteral(@"          </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckAdd"">
                                        <span class=""text"">Allow</span>
                                    </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckEdit"">
                                        <span class=""text"">Allow</span>
                                    </label>
                                </td>
                                <td>
                                    <label>
                                        <input type=""checkbox"" value=""{{Id}}"" class=""ckDelete"">
                                        <span class=""text"">Allow</span>
                                    </lab");
            WriteLiteral(@"el>
                                </td>
                            </tr>
                        </script>
                    </div>
                </div>


            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button type=""button"" id=""btnSavePermission"" class=""btn btn-success"">Save</button>
                        <button type=""button"" data-dismiss=""modal"" class=""btn btn-default"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
