#pragma checksum "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8390d6faeb93aa848bb17cd9f49b6c8be6fc9445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Details), @"mvc.1.0.view", @"/Views/Role/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Details.cshtml", typeof(AspNetCore.Views_Role_Details))]
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
#line 1 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\_ViewImports.cshtml"
using ContinentalCUP;

#line default
#line hidden
#line 2 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\_ViewImports.cshtml"
using Continental.CUP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8390d6faeb93aa848bb17cd9f49b6c8be6fc9445", @"/Views/Role/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f538a30628a657311f90b890b132aad0b664b688", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Continental.CUP.Business.ViewModel.Base.RoleModel>
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
#line 2 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 129, true);
            WriteLiteral("<h2>Detalles de Perfiles</h2>\r\n<div>\r\n    <h4>Perfil</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 40, false);
#line 11 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(315, 36, false);
#line 14 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 121, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n");
            EndContext();
#line 20 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                  
                    var columnNameList = Model?.RoleActionModelList.Select(p => p.Name).Distinct();
                

#line default
#line hidden
            BeginContext(612, 152, true);
            WriteLiteral("                <table class=\"table table-bordered\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th></th>\r\n");
            EndContext();
#line 27 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                              
                                foreach (var item in columnNameList)
                                {

#line default
#line hidden
            BeginContext(901, 40, true);
            WriteLiteral("                                    <th>");
            EndContext();
            BeginContext(942, 4, false);
#line 30 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(946, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 31 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1019, 90, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                          
                            var typesNameList = Model?.RoleActionModelList.Select(p => p.TypeName).Distinct();
                            foreach (var itemTypeName in typesNameList)
                            {

#line default
#line hidden
            BeginContext(1353, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1432, 12, false);
#line 41 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                   Write(itemTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                     foreach (var itemName in columnNameList)
                                    {
                                        var existsItem = Model?.RoleActionModelList.FirstOrDefault(p => p.Name == itemName && p.TypeName == itemTypeName);
                                        if (null != existsItem)
                                        {

#line default
#line hidden
            BeginContext(1833, 111, true);
            WriteLiteral("                                            <td><input id=\"IDParamList\" name=\"IDParamList\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1944, "\"", 1991, 3);
#line 47 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
WriteAttributeValue("", 1952, existsItem.RoleID, 1952, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1970, "|", 1970, 1, true);
#line 47 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
WriteAttributeValue("", 1971, existsItem.ActionID, 1971, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1992, 17, true);
            WriteLiteral(" type=\"checkbox\" ");
            EndContext();
            BeginContext(2011, 42, false);
#line 47 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                                                                                                                                                            Write(existsItem.Active ? "checked=checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2054, 74, true);
            WriteLiteral(" readonly=\"readonly\" onclick=\"return false;\" disabled=\"disabled\" /></td>\r\n");
            EndContext();
#line 48 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2260, 201, true);
            WriteLiteral("                                            <td><input id=\"IDParamList\" name=\"IDParamList\" class=\"form-control\" type=\"checkbox\" readonly=\"readonly\" onclick=\"return false;\" disabled=\"disabled\" /></td>\r\n");
            EndContext();
#line 52 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(2543, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 55 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2640, 125, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2765, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c6ce1754724e4690eb654d2fb785c5", async() => {
                BeginContext(2811, 6, true);
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
#line 65 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(2821, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2829, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64a23be69f343668b4f12e318ef5834", async() => {
                BeginContext(2851, 19, true);
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
            BeginContext(2874, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Continental.CUP.Business.ViewModel.Base.RoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
