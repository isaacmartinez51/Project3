#pragma checksum "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f68d70cd228d3970bde0c2df52b9bdec4e125966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\_ViewImports.cshtml"
using ContinentalCUP;

#line default
#line hidden
#line 2 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\_ViewImports.cshtml"
using Continental.CUP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68d70cd228d3970bde0c2df52b9bdec4e125966", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f538a30628a657311f90b890b132aad0b664b688", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Continental.CUP.Repositories.ViewModels.UserVModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 133, true);
            WriteLiteral("\r\n<h2>Detalles de usuario</h2>\r\n\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(285, 45, false);
#line 15 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirtsName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 41, false);
#line 18 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirtsName));

#line default
#line hidden
            EndContext();
            BeginContext(415, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(459, 44, false);
#line 21 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(547, 40, false);
#line 24 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(587, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(631, 44, false);
#line 27 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(675, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(719, 40, false);
#line 30 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(759, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(803, 44, false);
#line 33 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(891, 40, false);
#line 36 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(931, 408, true);
            WriteLiteral(@"
        </dd>
    </dl>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>Perfil</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 50 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
                         foreach (var item in Model.UserRoleModelList)
                        {

#line default
#line hidden
            BeginContext(1438, 133, true);
            WriteLiteral("                            <tr>\r\n                                <td><input id=\"IDParamList\" name=\"IDParamList\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1571, "\"", 1604, 3);
#line 53 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
WriteAttributeValue("", 1579, item.UserID, 1579, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1591, "|", 1591, 1, true);
#line 53 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
WriteAttributeValue("", 1592, item.RoleID, 1592, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1605, 17, true);
            WriteLiteral(" type=\"checkbox\" ");
            EndContext();
            BeginContext(1624, 36, false);
#line 53 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
                                                                                                                                                  Write(item.Active ? "checked=checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1661, 151, true);
            WriteLiteral(" readonly=\"readonly\" disabled=\"disabled\" /></td>\r\n                                <td>\r\n                                    <span class=\"form-control\">");
            EndContext();
            BeginContext(1813, 9, false);
#line 55 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1822, 83, true);
            WriteLiteral("</span>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1932, 123, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2055, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe730d339974401a5d722de219cf99b", async() => {
                BeginContext(2105, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\angel.martinez\Desktop\Conti.v2\ContinentalCups.v2\CUP.Web\Views\User\Details.cshtml"
                           WriteLiteral(Model.UserID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2115, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2123, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b0bfef4b2f48c0887508342f6488c7", async() => {
                BeginContext(2145, 19, true);
                WriteLiteral("Regresar a la lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2168, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Continental.CUP.Repositories.ViewModels.UserVModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
