#pragma checksum "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\ControleAcesso\FormPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4947a287204c5f65533ceabba6cc1a1514ec148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControleAcesso_FormPerfil), @"mvc.1.0.view", @"/Views/ControleAcesso/FormPerfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControleAcesso/FormPerfil.cshtml", typeof(AspNetCore.Views_ControleAcesso_FormPerfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4947a287204c5f65533ceabba6cc1a1514ec148", @"/Views/ControleAcesso/FormPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e62e22e5e7fce06cd537f5e98323a65a0c9f6d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ControleAcesso_FormPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Desenvolvimento\Maktub\Maketub\Maktub.Portal.Web\Views\ControleAcesso\FormPerfil.cshtml"
  
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46dc93462bf84c2a8aac9ba5fdb01130", async() => {
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
            BeginContext(150, 2867, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Novo Perfil</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                        <li class=""breadcrumb-item active"">Novo Perfil</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>



    <div>
        <div class=""form-row"">
            <p class=""col-10"">
                <spam class=""ml-2"">Nome Tipo Perfil:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
      ");
            WriteLiteral(@"  <div class=""form-row"">
            <p class=""col-10"">
                <spam class=""ml-2"">Descrição:</spam><textarea class=""form-control form-control-sm ml-2""></textarea>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-4"">
                <spam class=""ml-2"">Despesa:</spam><input type=""number"" class=""form-control form-control-sm ml-2"">
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Cliente</spam>
            </p>
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Tecnico</spam>
            </p>
            <p class=""col-4"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Relatorios</spam>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Fi");
            WriteLiteral(@"lial</spam>
            </p>
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro OS</spam>
            </p>
            <p class=""col-4"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Tipo de Perfil</spam>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Bandeira</spam>
            </p>
            <p class=""col-3"">
                <input type=""checkbox"" class=""ml-2""><spam class=""ml-2""> Cadastro Tipo de Serviço</spam>
            </p>
        </div>
        <p class=""col-10"">
            <input type=""checkbox"" name=""A"" value=""A""><spam class=""ml-2""> Ativo</spam>
        </p>
    </div>
</div>

");
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
