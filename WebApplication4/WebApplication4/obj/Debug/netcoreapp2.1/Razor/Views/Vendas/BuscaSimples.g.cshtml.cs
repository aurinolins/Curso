#pragma checksum "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d28721e3cf552fc519f59709aabb4566200c121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendas_BuscaSimples), @"mvc.1.0.view", @"/Views/Vendas/BuscaSimples.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendas/BuscaSimples.cshtml", typeof(AspNetCore.Views_Vendas_BuscaSimples))]
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
#line 1 "C:\Curso\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#line 2 "C:\Curso\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d28721e3cf552fc519f59709aabb4566200c121", @"/Views/Vendas/BuscaSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendas_BuscaSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication4.Models.Entidades.Vendas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 71, true);
            WriteLiteral("<nav class=\"navbar navbar-inversa\">\r\n\t<div class=\"container.fluid\">\r\n\t\t");
            EndContext();
            BeginContext(132, 530, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f1485f746f54e37b0c809b9030c0e47", async() => {
                BeginContext(184, 167, true);
                WriteLiteral("\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"datamin\">Data Minima</label>\r\n\t\t\t\t\t<input type=\"date\" class=\"form-control\" name=\"datamin\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 351, "", 378, 1);
#line 8 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
WriteAttributeValue("", 358, ViewData["datamin"], 358, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(378, 153, true);
                WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"datamax\">Data Maxima</label>\r\n\t\t\t\t\t<input type=\"date\" class=\"form-control\" name=\"datamax\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 531, "", 558, 1);
#line 12 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
WriteAttributeValue("", 538, ViewData["datamax"], 538, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(558, 97, true);
                WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Filtro</button>\r\n\t\t\t</div>\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(662, 123, true);
            WriteLiteral("\r\n\t</div>\r\n</nav>\r\n<div class=\"panel-primary\">\r\n\t<div class=\"panel-heading\">\r\n\t\t<h3 class=\"panel-title\">Total das Vendas = ");
            EndContext();
            BeginContext(786, 42, false);
#line 21 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                                              Write(Model.Sum(obj => obj.Valor).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(828, 149, true);
            WriteLiteral("</h3>\r\n\t</div>\r\n\t<div class=\"panel-body\">\r\n\t\t<table class=\"table table-striped table-hover\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr class=\"success\">\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(978, 38, false);
#line 28 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1048, 40, false);
#line 31 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1120, 44, false);
#line 34 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1196, 57, false);
#line 37 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1285, 41, false);
#line 40 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1358, 42, false);
#line 43 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 50, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
            EndContext();
#line 48 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                 foreach (var elemento in Model)
				{


#line default
#line hidden
            BeginContext(1497, 30, true);
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1528, 41, false);
#line 53 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1604, 43, false);
#line 56 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1682, 52, false);
#line 59 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1769, 65, false);
#line 62 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Vendedor.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1869, 44, false);
#line 65 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1948, 45, false);
#line 68 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelitem => elemento.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 27, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 71 "C:\Curso\WebApplication4\WebApplication4\Views\Vendas\BuscaSimples.cshtml"
				}

#line default
#line hidden
            BeginContext(2027, 68, true);
            WriteLiteral("\t\t\t</tbody>\r\n\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication4.Models.Entidades.Vendas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
