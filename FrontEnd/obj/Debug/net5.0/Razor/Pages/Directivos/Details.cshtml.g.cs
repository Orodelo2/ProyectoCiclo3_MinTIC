#pragma checksum "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8cca3e0228c2e8480e3710cced0e36bda67f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd_Web.Pages.Directivos.Pages_Directivos_Details), @"mvc.1.0.razor-page", @"/Pages/Directivos/Details.cshtml")]
namespace FrontEnd_Web.Pages.Directivos
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
#line 1 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd_Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8cca3e0228c2e8480e3710cced0e36bda67f04", @"/Pages/Directivos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c870a9bc1f5062e4c2344a06f02089ba4288a433", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Directivos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
  
    ViewData["Title"] = "Detalle del Directivo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Información Detallada</h1>\r\n<br/>\r\n<br/>\r\n\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 14 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 20 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 26 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 32 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 35 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 38 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 41 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 44 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 47 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 50 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 53 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 56 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 59 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 62 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 65 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 68 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.CantidadEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 71 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Directivos\Details.cshtml"
       Write(Html.DisplayFor(model => model.directivo.CantidadEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8cca3e0228c2e8480e3710cced0e36bda67f0410508", async() => {
                WriteLiteral("\r\n        <i class=\"fas fa-angle-double-left\">Regresar</i>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.Directivos.DetailsModelDirectivo> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Directivos.DetailsModelDirectivo> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Directivos.DetailsModelDirectivo>)PageContext?.ViewData;
        public MyApp.Namespace.Directivos.DetailsModelDirectivo Model => ViewData.Model;
    }
}
#pragma warning restore 1591
