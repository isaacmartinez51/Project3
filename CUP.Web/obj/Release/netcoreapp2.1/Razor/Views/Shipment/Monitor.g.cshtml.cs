#pragma checksum "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Shipment\Monitor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2b16c39f17567ea57baf648d990ea3f6dafc5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shipment_Monitor), @"mvc.1.0.view", @"/Views/Shipment/Monitor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shipment/Monitor.cshtml", typeof(AspNetCore.Views_Shipment_Monitor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2b16c39f17567ea57baf648d990ea3f6dafc5a", @"/Views/Shipment/Monitor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f538a30628a657311f90b890b132aad0b664b688", @"/Views/_ViewImports.cshtml")]
    public class Views_Shipment_Monitor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Continental.CUP.Business.ViewModel.Base.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("smart-form client-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Shipment\Monitor.cshtml"
  
    ViewData["Title"] = "Monitor de Embarques";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(162, 166, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row center-block\">\r\n        <div class=\"col-md-10 center-block\">\r\n            <div class=\"well no-padding\">\r\n                ");
            EndContext();
            BeginContext(328, 550, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab7bc2f792044ef08ad7bc7d96d50f4c", async() => {
                BeginContext(385, 70, true);
                WriteLiteral("\r\n                    <header>\r\n                        No. Embarque: ");
                EndContext();
                BeginContext(456, 20, false);
#line 12 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Shipment\Monitor.cshtml"
                                 Write(Model.ShipmentNumber);

#line default
#line hidden
                EndContext();
                BeginContext(476, 395, true);
                WriteLiteral(@"
                    </header>
                    <fieldset>
                        <section id=""dataShip"">
                            <p class=""text-align-center"">
                                Esperando lectura de pallet...
                            </p>
                        </section>
                    </fieldset>
                    <footer></footer>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(878, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(958, 180, true);
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n\r\n\r\n            setInterval(function () {\r\n\r\n                $.getJSON(\"/Shipment/RefreshPortal?orderID=");
                EndContext();
                BeginContext(1139, 13, false);
#line 36 "C:\ARepoIsaac\Repo\Continental.CUP\CUP.Web\Views\Shipment\Monitor.cshtml"
                                                      Write(Model.OrderID);

#line default
#line hidden
                EndContext();
                BeginContext(1152, 762, true);
                WriteLiteral(@""", function (data) {

                    let str = data.Success;
                    if (data.Success == 1) {
                        str = ""<p>VALIDO</p><p class='text-align-center'>No. de Parte: "" + data.PartNumber + ""; Cantidad: "" + data.Quantity + ""</p><p class='text-align-center'><img src='../img/ok.png' width='382' /></p>"";
                    } else {
                        str = ""<p>NO VALIDO</p><p class='text-align-center'>No. de Parte: "" + data.PartNumber + ""; Cantidad: "" + data.Quantity + ""</p><p class='text-align-center'><img src='../img/cancel.jpg' width='382' /></p>"";
                    }
                    $(""#dataShip"").html(str);
                    

                });

            }, 1000);
        });
</script>
");
                EndContext();
            }
            );
            BeginContext(1917, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Continental.CUP.Business.ViewModel.Base.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
