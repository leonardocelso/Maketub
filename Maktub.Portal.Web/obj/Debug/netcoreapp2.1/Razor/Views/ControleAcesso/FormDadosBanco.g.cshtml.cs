#pragma checksum "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\ControleAcesso\FormDadosBanco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d744ebe8009e27c5116cd22a2430bf2a30a6db7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControleAcesso_FormDadosBanco), @"mvc.1.0.view", @"/Views/ControleAcesso/FormDadosBanco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControleAcesso/FormDadosBanco.cshtml", typeof(AspNetCore.Views_ControleAcesso_FormDadosBanco))]
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
#line 1 "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\_ViewImports.cshtml"
using Maktub.Portal.Web;

#line default
#line hidden
#line 2 "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\_ViewImports.cshtml"
using Maktub.Portal.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d744ebe8009e27c5116cd22a2430bf2a30a6db7b", @"/Views/ControleAcesso/FormDadosBanco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e62e22e5e7fce06cd537f5e98323a65a0c9f6d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ControleAcesso_FormDadosBanco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dataTables.bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\ControleAcesso\FormDadosBanco.cshtml"
  
    ViewData["Title"] = "Novo Cliente";

#line default
#line hidden
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(67, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(75, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "735c698f0c7c4bc9b2d23983a546ca0d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(139, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
            BeginContext(150, 2208, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Dados Bancários</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                        <li class=""breadcrumb-item active"">Dados Bancários</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>



    <div>
            <div class=""form-row"">
                <p class=""col-10"">
                    <spam class=""ml-2"">Nome do Técnico</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
                </p>");
            WriteLiteral(@"
            </div>
            <div class=""form-row"">
                <p class=""col-3"">
                    <spam class=""ml-2"">Banco:</spam> <input type=""text"" class=""form-control form-control-sm ml-2""/>
                </p>
                <p class=""col-3"">
                    <spam class=""ml-2"">Agência:</spam> <input type=""number"" class=""form-control form-control-sm ml-2""/>
                </p>
                <p class=""col-4"">
                    <spam class=""ml-2"">Conta:</spam> <input type=""number"" class=""form-control form-control-sm ml-2""/>
                </p>
            </div>
            <div class=""form-row"">
                <p class=""col-10"">
                    <spam class=""ml-2"">Nome do Titular:</spam> <input type=""text"" class=""form-control form-control-sm ml-2""/>
                </p>
            </div>
            <div class=""form-row"">
                <p class=""col-4 ml-2"">
                    CPF: <input type=""number"" class=""form-control form-control-sm""/>
                </p>
            </d");
            WriteLiteral("iv>\n            <p class=\"col-10\">\n                <input type=\"checkbox\" name=\"A\" value=\"A\"><spam class=\"ml-2\"> Ativo</spam>\n            </p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
