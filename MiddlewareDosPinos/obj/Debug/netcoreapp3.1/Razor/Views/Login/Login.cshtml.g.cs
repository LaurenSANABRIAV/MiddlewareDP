#pragma checksum "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c666f0f5dc513bd496f05b4eed6d83bd60eca13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\_ViewImports.cshtml"
using MiddlewareDosPinos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\_ViewImports.cshtml"
using MiddlewareDosPinos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c666f0f5dc513bd496f05b4eed6d83bd60eca13", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d588c82ab846753a1064929f74441e25dd0dbb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Login\Login.cshtml"
   ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_login.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-lg-5"">
            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Login</h3></div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c666f0f5dc513bd496f05b4eed6d83bd60eca133902", async() => {
                WriteLiteral(@"
                        <div class=""form-floating mb-3"">
                            <input class=""form-control"" id=""inputEmail"" type=""email"" placeholder=""name@example.com"" />
                            <label for=""inputEmail"">Email </label>
                        </div>
                        <div class=""form-floating mb-3"">
                            <input class=""form-control"" id=""inputPassword"" type=""password"" placeholder=""Password"" />
                            <label for=""inputPassword"">Contrase??a</label>
                        </div>
                        <div class=""form-check mb-3"">
                            <input class=""form-check-input"" id=""inputRememberPassword"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1128, "\"", 1136, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <label class=""form-check-label"" for=""inputRememberPassword"">Recordar Contrase??a</label>
                        </div>
                        <div class=""d-flex align-items-center justify-content-between mt-4 mb-0"">

                            <a");
                BeginWriteAttribute("href", " href=\"", 1417, "\"", 1464, 1);
#nullable restore
#line 26 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Login\Login.cshtml"
WriteAttributeValue("", 1424, Url.Action("Olvido_Contrase??a","Login"), 1424, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                               class=\"small\">Olvido Contrase??a</a>\n                            <button class=\"btn btn-outline-primary\">");
#nullable restore
#line 28 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Login\Login.cshtml"
                                                               Write(Html.ActionLink("Login", "index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n                            \n\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"card-footer text-center py-3\">\n                    <div class=\"small\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 1929, 1);
#nullable restore
#line 36 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Login\Login.cshtml"
WriteAttributeValue("", 1897, Url.Action("Registrar","Login"), 1897, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                           class=\"small\">Registrarse</a>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n\n</div>\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />\n");
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
