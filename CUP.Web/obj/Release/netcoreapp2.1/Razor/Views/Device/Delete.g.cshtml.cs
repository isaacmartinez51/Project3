#pragma checksum "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a8fb6c1f0fe6bcac1c3a2200b3ce56c922d4e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Delete), @"mvc.1.0.view", @"/Views/Device/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/Delete.cshtml", typeof(AspNetCore.Views_Device_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a8fb6c1f0fe6bcac1c3a2200b3ce56c922d4e3", @"/Views/Device/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f538a30628a657311f90b890b132aad0b664b688", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Continental.CUP.Business.ViewModel.Base.DeviceModel>
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(104, 155, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>¿ Esta seguro de eliminar este Dispositivo de Estación ?</h3>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(260, 39, false);
#line 13 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Key));

#line default
#line hidden
            EndContext();
            BeginContext(299, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(343, 35, false);
#line 16 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Key));

#line default
#line hidden
            EndContext();
            BeginContext(378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(422, 40, false);
#line 19 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(462, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(506, 36, false);
#line 22 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 41, false);
#line 25 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(671, 37, false);
#line 28 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(752, 48, false);
#line 31 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(844, 44, false);
#line 34 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SerialNumber));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(932, 45, false);
#line 37 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IpAddress));

#line default
#line hidden
            EndContext();
            BeginContext(977, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1021, 41, false);
#line 40 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IpAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1106, 40, false);
#line 43 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Port));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1190, 36, false);
#line 46 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Port));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1270, 51, false);
#line 49 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AntennaQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1365, 47, false);
#line 52 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AntennaQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1450, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30defe1964d9435d886ab286e4c094f4", async() => {
                BeginContext(1476, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1486, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3ba2228ce604b1fb9fb4fe7f0667ee6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 57 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Device\Delete.cshtml"
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
                BeginContext(1522, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1608, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "052756573a9e46a194cea216f84c78da", async() => {
                    BeginContext(1630, 19, true);
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
                BeginContext(1653, 6, true);
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
            BeginContext(1666, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Continental.CUP.Business.ViewModel.Base.DeviceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591