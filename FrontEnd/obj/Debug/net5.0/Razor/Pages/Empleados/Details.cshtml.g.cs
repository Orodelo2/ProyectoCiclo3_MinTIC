#pragma checksum "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7f8ed861e883148336d3da4f9ad1574ef08f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd_Web.Pages.Empleados.Pages_Empleados_Details), @"mvc.1.0.razor-page", @"/Pages/Empleados/Details.cshtml")]
namespace FrontEnd_Web.Pages.Empleados
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7f8ed861e883148336d3da4f9ad1574ef08f45", @"/Pages/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c870a9bc1f5062e4c2344a06f02089ba4288a433", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleados_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Detalle Empleado";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Información Detallada</h1>\r\n<br/>\r\n<br/>\r\n\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 13 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 16 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 19 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 25 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 28 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 31 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 34 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 37 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 43 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 46 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 49 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 52 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 55 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empleado.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 58 "D:\MT_Project\ProyectoCiclo3_MinTIC\FrontEnd\Pages\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.empleado.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7f8ed861e883148336d3da4f9ad1574ef08f459133", async() => {
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.Empleados.DetailsModelEmpleado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Empleados.DetailsModelEmpleado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Empleados.DetailsModelEmpleado>)PageContext?.ViewData;
        public MyApp.Namespace.Empleados.DetailsModelEmpleado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
