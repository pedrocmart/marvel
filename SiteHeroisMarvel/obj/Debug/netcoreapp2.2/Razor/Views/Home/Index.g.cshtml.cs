#pragma checksum "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca85a8c586d59895ee6d5c322c1ca67586ef3e7c"
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
#line 1 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\_ViewImports.cshtml"
using SiteHeroisMarvel;

#line default
#line hidden
#line 2 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\_ViewImports.cshtml"
using SiteHeroisMarvel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca85a8c586d59895ee6d5c322c1ca67586ef3e7c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d4df4741fcc8ec8d19e640c96319d0e15bf561", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SiteHeroisMarvel.Models.Personagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(94, 222, true);
            WriteLiteral("<style>\r\n    .row, .group {\r\n    }\r\n\r\n        .row:nth-child(odd) {\r\n            background-color: white;\r\n        }\r\n\r\n        .row:nth-child(even) {\r\n            background-color: lightgray;\r\n        }\r\n</style>\r\n<div>\r\n");
            EndContext();
#line 18 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(354, 344, true);
            WriteLiteral(@"        <fieldset>
            <legend>Pesquisa</legend>
            <label for=""pesquisa""> Digite o nome do Herói:</label>
            <input type=""text"" name=""nomeHeroi"" id=""nomeHeroi"" />
            <br />
            <input type=""submit"" id=""submit"" />
            <br />
            <br />
            <br />
        </fieldset>
");
            EndContext();
#line 30 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(705, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(748, 165, true);
            WriteLiteral("        <div class=\"row group subgroup\">\r\n            <div class=\"wrap\" style=\"display: contents;\">\r\n                <div class=\"col-md-4\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 913, "\"", 934, 1);
#line 37 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
WriteAttributeValue("", 919, item.UrlImagem, 919, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(935, 120, true);
            WriteLiteral(" height=\"200\" width=\"200\" />\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1075, 1);
#line 40 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
WriteAttributeValue("", 1062, item.UrlWiki, 1062, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1076, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1094, 9, false);
#line 40 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                                                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 11, true);
            WriteLiteral("</a> - ID: ");
            EndContext();
            BeginContext(1115, 7, false);
#line 40 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                                                                                Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 48, true);
            WriteLiteral("</h2>\r\n                    <b>Descrição:</b> <p>");
            EndContext();
            BeginContext(1171, 14, false);
#line 41 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                                    Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 47, true);
            WriteLiteral("</p>\r\n\r\n                    <b>Histórias:</b>\r\n");
            EndContext();
#line 44 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                     foreach (var historia in item.Historias)
                    {
                        

#line default
#line hidden
            BeginContext(1343, 8, false);
#line 46 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                   Write(historia);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 48 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1408, 100, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <br />\r\n            <br />\r\n        </div>\r\n");
            EndContext();
#line 54 "C:\Users\pcunha\Downloads\ASP.NET-Core-2.2_Marvel-API-master\ASP.NET-Core-2.2_Marvel-API-master\SiteHeroisMarvel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1515, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SiteHeroisMarvel.Models.Personagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591