#pragma checksum "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4909d93e217b78992a1b4e10b8e22e5627669df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publicacions_DetailsInmueble), @"mvc.1.0.view", @"/Views/Publicacions/DetailsInmueble.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publicacions/DetailsInmueble.cshtml", typeof(AspNetCore.Views_Publicacions_DetailsInmueble))]
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
#line 1 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria;

#line default
#line hidden
#line 2 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4909d93e217b78992a1b4e10b8e22e5627669df", @"/Views/Publicacions/DetailsInmueble.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Publicacions_DetailsInmueble : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inmobiliaria.Models.Inmueble>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inmuebles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "htmlpage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 2756, true);
            WriteLiteral(@"


<h2>Detalles Inmueble</h2>


<div>
    <h4>Inmueble</h4>

    <!--
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""item active"">
                <img src=""~/images/banner1.svg"" alt=""ASP.NET"" class=""img-responsive"" />
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        Learn how to build ASP.NET apps that can run anywhere.
                        <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                            Learn More
                        </a>
                    </p>
                ");
            WriteLiteral(@"</div>
            </div>
            <div class=""item"">
                <img src=""~/images/banner2.svg"" alt=""Visual Studio"" class=""img-responsive"" />
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        There are powerful new features in Visual Studio for building modern web apps.
                        <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                            Learn More
                        </a>
                    </p>
                </div>
            </div>
            <div class=""item"">
                <img src=""~/images/banner3.svg"" alt=""Microsoft Azure"" class=""img-responsive"" />
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                        <a class=""btn btn-default"" href=""https://go.microsoft.com/fwli");
            WriteLiteral(@"nk/?LinkID=525027&clcid=0x409"">
                            Learn More
                        </a>
                    </p>
                </div>
            </div>
        </div>
        <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    -->

    ");
            EndContext();
            BeginContext(2838, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d79e8835e23b41828e9e63e42de859dd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2848, "~/images/", 2848, 9, true);
#line 69 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
AddHtmlAttributeValue("", 2857, Html.DisplayFor(model => model.imagen), 2857, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2900, 72, true);
            WriteLiteral("\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2973, 47, false);
#line 73 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(3020, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3064, 43, false);
#line 76 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(3107, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3151, 42, false);
#line 79 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.imagen));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3237, 38, false);
#line 82 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.imagen));

#line default
#line hidden
            EndContext();
            BeginContext(3275, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3319, 45, false);
#line 85 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(3364, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3408, 41, false);
#line 88 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(3449, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3493, 42, false);
#line 91 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.barrio));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3579, 38, false);
#line 94 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.barrio));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3661, 45, false);
#line 97 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.ambientes));

#line default
#line hidden
            EndContext();
            BeginContext(3706, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3750, 41, false);
#line 100 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.ambientes));

#line default
#line hidden
            EndContext();
            BeginContext(3791, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3835, 41, false);
#line 103 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.banos));

#line default
#line hidden
            EndContext();
            BeginContext(3876, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3920, 37, false);
#line 106 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.banos));

#line default
#line hidden
            EndContext();
            BeginContext(3957, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4001, 43, false);
#line 109 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.cochera));

#line default
#line hidden
            EndContext();
            BeginContext(4044, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4088, 39, false);
#line 112 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.cochera));

#line default
#line hidden
            EndContext();
            BeginContext(4127, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4171, 42, false);
#line 115 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayNameFor(model => model.precio));

#line default
#line hidden
            EndContext();
            BeginContext(4213, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4257, 38, false);
#line 118 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
       Write(Html.DisplayFor(model => model.precio));

#line default
#line hidden
            EndContext();
            BeginContext(4295, 94, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n\r\n<div>\r\n    <!--<a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(4390, 8, false);
#line 127 "C:\Users\Nahuel\source\repos\Inmobiliaria\Inmobiliaria\Views\Publicacions\DetailsInmueble.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4398, 21, true);
            WriteLiteral("\">Edit</a> |-->\r\n    ");
            EndContext();
            BeginContext(4419, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f028cc27db334635b0609dcdc228b256", async() => {
                BeginContext(4471, 17, true);
                WriteLiteral("Volver a la Lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(4492, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inmobiliaria.Models.Inmueble> Html { get; private set; }
    }
}
#pragma warning restore 1591
