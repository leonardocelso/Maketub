#pragma checksum "C:\Users\leonardo\Desktop\Maketub-master\Maketub-master\Maktub.Portal.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20fc1f4f3844ee01bd73ce68a2d88fc8f7900f88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\leonardo\Desktop\Maketub-master\Maketub-master\Maktub.Portal.Web\Views\_ViewImports.cshtml"
using Maktub.Portal.Web;

#line default
#line hidden
#line 2 "C:\Users\leonardo\Desktop\Maketub-master\Maketub-master\Maktub.Portal.Web\Views\_ViewImports.cshtml"
using Maktub.Portal.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fc1f4f3844ee01bd73ce68a2d88fc8f7900f88", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e62e22e5e7fce06cd537f5e98323a65a0c9f6d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\leonardo\Desktop\Maketub-master\Maketub-master\Maktub.Portal.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(45, 23919, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Dashboard</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item active"">Dashboard</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-3 col-6"">
                    <!-- small card -->
                    <div class=""small-box bg-info"">
                        <di");
            WriteLiteral(@"v class=""inner"">
                            <h3>138</h3>
                            <p>Novas OS's</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-shopping-cart""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">
                            Mais Informações <i class=""fas fa-arrow-circle-right""></i>
                        </a>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-3 col-6"">
                    <!-- small card -->
                    <div class=""small-box bg-success"">
                        <div class=""inner"">
                            <h3>53<sup style=""font-size: 20px"">%</sup></h3>

                            <p>OS's Concluídas</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-chart-bar""></i>
                     ");
            WriteLiteral(@"   </div>
                        <a href=""#"" class=""small-box-footer"">
                            Mais Informações <i class=""fas fa-arrow-circle-right""></i>
                        </a>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-3 col-6"">
                    <!-- small card -->
                    <div class=""small-box bg-warning"">
                        <div class=""inner"">
                            <h3>287</h3>

                            <p>OS's em andamento</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-truck-moving""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">
                            Mais Informações <i class=""fas fa-arrow-circle-right""></i>
                        </a>
                    </div>
                </div>
                <!-- ./col -->
                <div cla");
            WriteLiteral(@"ss=""col-lg-3 col-6"">
                    <!-- small card -->
                    <div class=""small-box bg-danger"">
                        <div class=""inner"">
                            <h3>15</h3>

                            <p>OS's Canceladas</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-ban""></i>
                        </div>
                        <a href=""#"" class=""small-box-footer"">
                            Mais Informações <i class=""fas fa-arrow-circle-right""></i>
                        </a>
                    </div>
                </div>
                <!-- ./col -->
            </div>
            <!-- /.row -->
            <!-- TABLE: LATEST ORDERS -->
            <div class=""card"">
                <div class=""card-header border-transparent"">
                    <h3 class=""card-title"">Últimas OS's</h3>

                    <div class=""card-tools"">
                        <button type=""butt");
            WriteLiteral(@"on"" class=""btn btn-tool"" data-card-widget=""collapse"">
                            <i class=""fas fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                            <i class=""fas fa-times""></i>
                        </button>
                    </div>
                </div>
                <!-- /.card-header -->
                <div class=""card-body p-0"">
                    <div class=""table-responsive"">
                        <table class=""table m-0"">
                            <thead>
                                <tr>
                                    <th>OS Nº</th>
                                    <th>Cliente</th>
                                    <th>Filial</th>
                                    <th>Técnico</th>
                                    <th>Status</th>
                                    <th>Local</th>
                                    <th>Serviço</th>
 ");
            WriteLiteral(@"                                   <th>Data Atendimento</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR9842</a></td>
                                    <td>EFATHA</td>
                                    <td>2211</td>
                                    <td>Gilmar Ferreira de Sousa Junior</td>
                                    <td><span class=""badge badge-success"">Concluída</span></td>
                                    <td>IMPERATRIZ - MA</td>
                                    <td>Inauguração de Loja - 3º dia</td>
                                    <td>10/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR7429</a></td>
                                    <td>EFATHA</td>
                 ");
            WriteLiteral(@"                   <td>2211</td>
                                    <td>Gilmar Ferreira de Sousa Junior</td>
                                    <td><span class=""badge badge-success"">Concluída</span></td>
                                    <td>IMPERATRIZ - MA</td>
                                    <td>Inauguração de Loja - 2º dia</td>
                                    <td>09/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1748</a></td>
                                    <td>TECNOCOMP</td>
                                    <td>TCP010</td>
                                    <td>Olivar De Oliveira Batista</td>
                                    <td><span class=""badge badge-warning"">Em Andamento</span></td>
                                    <td>BELÉM - PA</td>
                                    <td>TECNOCOMP - Field Service</td>
                                    <t");
            WriteLiteral(@"d>21/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1799</a></td>
                                    <td>VIAVAREJO</td>
                                    <td>1635</td>
                                    <td>Elisandre Ferreira Filho</td>
                                    <td><span class=""badge badge-success"">Concluída</span></td>
                                    <td>CUIABÁ - MT</td>
                                    <td></td>
                                    <td>24/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1853</a></td>
                                    <td>EFATHA</td>
                                    <td>1200</td>
                                    <td>Elisandre Ferreira Filho</td>
                                    <td><span cla");
            WriteLiteral(@"ss=""badge badge-info"">Nova</span></td>
                                    <td>IMPERATRIZ - MA</td>
                                    <td>CONTRATO SINERGIA</td>
                                    <td>24/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1866</a></td>
                                    <td>VIAVAREJO</td>
                                    <td>1500</td>
                                    <td>Igor Cruz</td>
                                    <td><span class=""badge badge-success"">Concluída</span></td>
                                    <td>São Bernardo do Campo - SP</td>
                                    <td>ATENDIMENTO FIELD</td>
                                    <td>10/01/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1923</a></td>
   ");
            WriteLiteral(@"                                 <td>
                                        GPA2071
                                    </td>
                                    <td>1200</td>
                                    <td>
                                        Ubirajara Dias da Silva
                                    </td>
                                    <td><span class=""badge badge-danger"">Cancelada</span></td>
                                    <td>SÃO PAULO - SP</td>
                                    <td>
                                        GPA Avulso
                                    </td>
                                    <td>24/01/2020</td>
                                </tr>
                                <tr>

                                    <td><a href=""pages/examples/invoice.html"">OR1905</a></td>
                                    <td>
                                        TECNOCOMP
                                    </td>
                               ");
            WriteLiteral(@"     <td>
                                        TCP041
                                    </td>
                                    <td>Jairo da Rocha Pires</td>
                                    <td><span class=""badge badge-info"">Nova</span></td>
                                    <td>JI-PARANÁ - RO</td>
                                    <td>VERFICAR PROBLEMA NA MAQUINA</td>
                                    <td>03/03/2020</td>
                                </tr>
                                <tr>
                                    <!--a-->
                                    <td><a href=""pages/examples/invoice.html"">OR1781</a></td>
                                    <td>EFATHA</td>
                                    <td>
                                        1751
                                    </td>
                                    <td>
                                        Egivaldo de Souza Silva
                                    </td>
                     ");
            WriteLiteral(@"               <td><span class=""badge badge-warning"">Em Andamento</span></td>
                                    <td>
                                        ARAGUAÍNA - TO
                                    </td>
                                    <td>
                                        TROCA DE PINPAD
                                    </td>
                                    <td>21/02/2020</td>
                                </tr>
                                <tr>
                                    <td><a href=""pages/examples/invoice.html"">OR1925</a></td>
                                    <td>
                                        TECNOCOMP
                                    </td>
                                    <td>
                                        GPA1193
                                    </td>
                                    <td>
                                        Frederick Augustus Barbosa Rocha Fantoni
                                    </t");
            WriteLiteral(@"d>
                                    <td><span class=""badge badge-success"">Concluída</span></td>
                                    <td>
                                        SÃO PAULO - SP
                                    </td>
                                    <td>
                                        GPA Avulso
                                    </td>
                                    <td>18/01/2020</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <!-- /.table-responsive -->
                </div>
                <!-- /.card-body -->
                <div class=""card-footer clearfix"">
                    <a href=""javascript:void(0)"" class=""btn btn-sm btn-info float-left"">Nova OS</a>
                    <a href=""javascript:void(0)"" class=""btn btn-sm btn-secondary float-right"">Ver todas OS's</a>
                </div>
                <!-- /.card-footer -->
       ");
            WriteLiteral(@"     </div>
            <!-- /.card -->
            <!-- Map card -->
            <section class=""connectedSortable"">
                <div class=""row"">
                    <!--card map-->
                    <div class=""col-lg-5 col-6"">
                        <div class=""card bg-gradient-primary"">
                            <div class=""card-header border-0"">
                                <h3 class=""card-title"">
                                    <i class=""fas fa-map-marker-alt mr-1""></i>
                                    Mapa da OS's Brasil
                                </h3>
                                <!-- card tools -->
                                <div class=""card-tools"">
                                    <button type=""button""
                                            class=""btn btn-primary btn-sm""
                                            data-card-widget=""collapse""
                                            data-toggle=""tooltip""
                                 ");
            WriteLiteral(@"           title=""Collapse"">
                                        <i class=""fas fa-minus""></i>
                                    </button>
                                </div>
                            </div>
                            <!-- /.card-tools -->
                            <div class=""card-body"">
                                <div id=""vmap"" style=""height: 250px; width: 100%;""></div>
                            </div>

                        </div>
                    </div>
                    <!-- ./card map -->
                    <!-- card info-->
                    <div class=""col-lg-4 col-6"">
                        <div class=""card bg-gradient-success"">
                            <div class=""card-header border-0"""">
                                <h3 class=""card-title"">
                                    <i class=""fas fa-info-circle mr-1""></i>
                                    Informações OS's
                                </h3>
                      ");
            WriteLiteral(@"          <!-- card tools -->
                                <div class=""card-tools"">
                                    <button type=""button""
                                            class=""btn btn-success btn-sm""
                                            data-card-widget=""collapse""
                                            data-toggle=""tooltip""
                                            title=""Collapse"">
                                        <i class=""fas fa-minus""></i>
                                    </button>
                                </div>
                                <!-- /.card-tools -->
                            </div>
                            <div class=""card-body"">
                                <div id=""info-estado"" style=""height: 250px; width: 100%;"">
                                    <div class=""row m-0"">
                                        <div class=""col-lg-6"">
                                            <div class=""description-block"">

  ");
            WriteLiteral(@"                                              <div class=""sparkbar pad"" data-color=""#fff"">São Paulo</div>
                                                <h5 class=""description-header"">495</h5>
                                                <i class=""fas fa-globe-americas fa-4x mt-2""></i>
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""sparkbar pad"" data-color=""#fff"">
                                                <div class=""icon"">
                                                    <i class=""fas fa-shopping-cart m-3""></i>
                                                    Novas: <span class=""font-weight-bold"">45</span>
                                                </div>
                                            </div>
                                            <div class=""sparkbar pad"" data-color=""#fff"">
               ");
            WriteLiteral(@"                                 <div class=""icon"">
                                                    <i class=""fas fa-chart-bar m-3""></i>
                                                    Em Andamento: <span class=""font-weight-bold"">163</span>
                                                </div>
                                            </div>
                                            <div class=""sparkbar pad"" data-color=""#fff"">
                                                <div class=""icon"">
                                                    <i class=""fas fa-truck-moving m-3""></i>
                                                    Concluídas: <span class=""font-weight-bold"">268</span>
                                                </div>
                                            </div>

                                            <div class=""sparkbar pad"" data-color=""#fff"">
                                                <div class=""icon"">
                                      ");
            WriteLiteral(@"              <i class=""fas fa-ban m-3""></i>
                                                    Canceladas: <span class=""font-weight-bold"">19</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.card-body-->
                        </div>
                    </div>
                    <!--.card info-->
                    <!-- box indicativos-->
                    <div class=""col-lg-3 col-6"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h3 class=""card-title"">
                                    <i class=""fas fa-chart-line mr-1""></i>
                                    Ranking OS's
                                </h3>
                                ");
            WriteLiteral(@"<div class=""card-tools"">
                                    <button type=""button"" 
                                            class=""btn btn-tool btn-sm m-0"" 
                                            data-card-widget=""collapse""
                                            data-toggle=""tooltip""
                                            title=""Collapse"">
                                        <i class=""fas fa-minus""></i>
                                    </button>
                                </div>
                            </div>
                            <!-- /.card-header -->
                            <div class=""card-body"">
                                <div class=""col-md-12"" style=""height: 250px; width: 100%;"">
                                    <p class=""text-center"">
                                        <strong>OS's x Estado (2020)</strong>
                                    </p>
                                    <div class=""progress-group"">
                  ");
            WriteLiteral(@"                      São Paulo
                                        <span class=""float-right""><b>1422</b>/3950</span>
                                        <div class=""progress progress-sm"">
                                            <div class=""progress-bar bg-primary"" style=""width: 36%""></div>
                                        </div>
                                    </div>
                                    <!-- /.progress-group -->

                                    <div class=""progress-group"">
                                        Minas Gerais
                                        <span class=""float-right""><b>671</b>/3950</span>
                                        <div class=""progress progress-sm"">
                                            <div class=""progress-bar bg-danger"" style=""width: 17%""></div>
                                        </div>
                                    </div>

                                    <!-- /.progress-group -->
         ");
            WriteLiteral(@"                           <div class=""progress-group"">
                                        <span class=""progress-text"">Rio de Janiero</span>
                                        <span class=""float-right""><b>514</b>/3950</span>
                                        <div class=""progress progress-sm"">
                                            <div class=""progress-bar bg-success"" style=""width: 13%""></div>
                                        </div>
                                    </div>

                                    <!-- /.progress-group -->
                                    <div class=""progress-group"">
                                        Bahia
                                        <span class=""float-right""><b>355</b>/3950</span>
                                        <div class=""progress progress-sm"">
                                            <div class=""progress-bar bg-warning"" style=""width: 9%""></div>
                                        </div>
           ");
            WriteLiteral(@"                         </div>
                                    <!-- /.progress-group -->
                                </div>
                            </div>
                            <!-- /.card -->
                        </div>
                    </div>
                    <!-- /.box indicativos -->
                </div>
            </section>
        </div>
    </div>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->

<script>
    jQuery(document).ready(function () {

        dadosMapa = [
            {
                ""UF"": ""SP"",
                ""Estado"": ""São Paulo"",
                ""QtdeOS"": ""261""
            },
            {
                ""UF"": ""MG"",
                ""Estado"": ""Minas Gerais"",
                ""QtdeOS"": ""132""
            },
            {
                ""UF"": ""RJ"",
                ""Estado"": ""Rio de Janeiro"",
                ""QtdeOS"": ""189""
            }
        ];
        JSON.stringify(dadosMapa);

       

        jQuery('#");
            WriteLiteral(@"vmap').vectorMap({
            map: 'brazil_br',
            onRegionClick: function (element, code, region) {
                var message = 'You clicked ""'
                    + region
                    + '"" which has the code: '
                    + code.toUpperCase();

                alert(message);

            }
        });
    });
</script>
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
