#pragma checksum "/Users/viniciusyamaguti/Documents/GitHub/Maketub/Maktub.Portal.Web/Views/ControleAcesso/FormUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d167ad7f456f177fcb8ddd8b952045b36e3071cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControleAcesso_FormUsuario), @"mvc.1.0.view", @"/Views/ControleAcesso/FormUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControleAcesso/FormUsuario.cshtml", typeof(AspNetCore.Views_ControleAcesso_FormUsuario))]
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
#line 1 "/Users/viniciusyamaguti/Documents/GitHub/Maketub/Maktub.Portal.Web/Views/_ViewImports.cshtml"
using Maktub.Portal.Web;

#line default
#line hidden
#line 2 "/Users/viniciusyamaguti/Documents/GitHub/Maketub/Maktub.Portal.Web/Views/_ViewImports.cshtml"
using Maktub.Portal.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d167ad7f456f177fcb8ddd8b952045b36e3071cc", @"/Views/ControleAcesso/FormUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e62e22e5e7fce06cd537f5e98323a65a0c9f6d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ControleAcesso_FormUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/viniciusyamaguti/Documents/GitHub/Maketub/Maktub.Portal.Web/Views/ControleAcesso/FormUsuario.cshtml"
  
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1012c1b3e0324fb9b67ae1d05607cf08", async() => {
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
            BeginContext(150, 2360, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Novo Usuário</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                        <li class=""breadcrumb-item active"">Novo Usuário</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>



    <div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Nome:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5");
            WriteLiteral(@" ml-2"">
                <spam class=""ml-2"">Sobrenome:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Data de Nascimento:</spam><input type=""date"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">CEP:</spam><input type=""number"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-10 ml-2"">
                <spam class=""ml-2"">Logradouro:</spam><input type=""text"" class=""form-control form-control-sm ml-2"">
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Número:</spam><input type=""number"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Complemento:</spam><");
            WriteLiteral(@"input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Estado:</spam><select class=""form-control form-control-sm ml-2"">
                                                    ");
            EndContext();
            BeginContext(2510, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3135c5710a324f39990fd33f088c5b9c", async() => {
                BeginContext(2518, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2528, 1074, true);
            WriteLiteral(@"   
                                                 </select>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Telefone Fixo:</spam><input type=""tel"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Telefone Celular:</spam><input type=""number"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">CPF:</spam><input type=""number"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">RG:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Gênero:</spam><select class=""form-control form-control-sm ml-2"">
  ");
            WriteLiteral("                                                  ");
            EndContext();
            BeginContext(3602, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4351692a9f40a88d50b9e2535b514a", async() => {
                BeginContext(3610, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3620, 53, true);
            WriteLiteral("\n                                                    ");
            EndContext();
            BeginContext(3673, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b367c9d567e24919bd51ab467bc2a6f2", async() => {
                BeginContext(3681, 8, true);
                WriteLiteral("Feminino");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3698, 53, true);
            WriteLiteral("\n                                                    ");
            EndContext();
            BeginContext(3751, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1f8f74162af43f2b299f82911b57798", async() => {
                BeginContext(3759, 9, true);
                WriteLiteral("Masculino");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3777, 876, true);
            WriteLiteral(@"
                                                 </select>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">E-mail:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Login:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Senha:</spam><input type=""text"" class=""form-control form-control-sm ml-2""/>
            </p>
        </div>
        <div class=""form-row"">
            <p class=""col-5 ml-2"">
                <spam class=""ml-2"">Perfil de acesso</spam><select class=""form-control form-control form-control-sm ml-2"">
                                                            ");
            EndContext();
            BeginContext(4653, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5252d18a0940708bf10e570b437204", async() => {
                BeginContext(4661, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4671, 267, true);
            WriteLiteral(@"
                                                          </select>
            </p>
            <p class=""col-5 ml-3 pt-4"">
                <input type=""checkbox"" name=""A"" value=""A""><spam class=""ml-2""> Ativo</spam>
            </p>
        </div>
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