#pragma checksum "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2584b8c68e9be90489d8b1dc540c085b976d47fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Delete), @"mvc.1.0.view", @"/Views/Role/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Delete.cshtml", typeof(AspNetCore.Views_Role_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2584b8c68e9be90489d8b1dc540c085b976d47fb", @"/Views/Role/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f538a30628a657311f90b890b132aad0b664b688", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Continental.CUP.Business.ViewModel.Base.RoleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(102, 138, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>¿ Estás seguro de eliminar el usuario ?</h3>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(241, 40, false);
#line 13 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(325, 36, false);
#line 16 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(361, 121, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n");
            EndContext();
#line 22 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                  
                    var columnNameList = Model?.RoleActionModelList.Select(p => p.Name).Distinct();
                

#line default
#line hidden
            BeginContext(622, 152, true);
            WriteLiteral("                <table class=\"table table-bordered\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th></th>\r\n");
            EndContext();
#line 29 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                              
                                foreach (var item in columnNameList)
                                {

#line default
#line hidden
            BeginContext(911, 40, true);
            WriteLiteral("                                    <th>");
            EndContext();
            BeginContext(952, 4, false);
#line 32 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(956, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 33 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1029, 90, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 38 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                          
                            var typesNameList = Model?.RoleActionModelList.Select(p => p.TypeName).Distinct();
                            foreach (var itemTypeName in typesNameList)
                            {

#line default
#line hidden
            BeginContext(1363, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1442, 12, false);
#line 43 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                   Write(itemTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1454, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                     foreach (var itemName in columnNameList)
                                    {
                                        var existsItem = Model?.RoleActionModelList.FirstOrDefault(p => p.Name == itemName && p.TypeName == itemTypeName);
                                        if (null != existsItem)
                                        {

#line default
#line hidden
            BeginContext(1843, 111, true);
            WriteLiteral("                                            <td><input id=\"IDParamList\" name=\"IDParamList\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1954, "\"", 2001, 3);
#line 49 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
WriteAttributeValue("", 1962, existsItem.RoleID, 1962, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1980, "|", 1980, 1, true);
#line 49 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
WriteAttributeValue("", 1981, existsItem.ActionID, 1981, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2002, 17, true);
            WriteLiteral(" type=\"checkbox\" ");
            EndContext();
            BeginContext(2021, 42, false);
#line 49 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                                                                                                                                                            Write(existsItem.Active ? "checked=checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2064, 74, true);
            WriteLiteral(" readonly=\"readonly\" onclick=\"return false;\" disabled=\"disabled\" /></td>\r\n");
            EndContext();
#line 50 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2270, 201, true);
            WriteLiteral("                                            <td><input id=\"IDParamList\" name=\"IDParamList\" class=\"form-control\" type=\"checkbox\" readonly=\"readonly\" onclick=\"return false;\" disabled=\"disabled\" /></td>\r\n");
            EndContext();
#line 54 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(2553, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 57 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2650, 108, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(2758, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb42e37a1f1a402b8ace579a3819fe2c", async() => {
                BeginContext(2784, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2794, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bae702e5c4d245859019e34dd11c06be", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2830, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2916, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147e046ddd374419a85c2e0309f42b27", async() => {
                    BeginContext(2938, 19, true);
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
                BeginContext(2961, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2974, 10, true);
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
