#pragma checksum "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de02f5230452115f4e58482a775a45f6cf5fd8d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TuristickiVodic_Index), @"mvc.1.0.view", @"/Views/TuristickiVodic/Index.cshtml")]
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
#line 1 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\_ViewImports.cshtml"
using Seminarski_Turisticka_Agencija_Rs1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\_ViewImports.cshtml"
using Seminarski_Turisticka_Agencija_Rs1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de02f5230452115f4e58482a775a45f6cf5fd8d1", @"/Views/TuristickiVodic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6994151c0fe008ac422a089836b70f8b035c847d", @"/Views/_ViewImports.cshtml")]
    public class Views_TuristickiVodic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seminarski_Turisticka_Agencija_Rs1.Models.TuristickiVodicIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Podaci o turistickim vodicima:</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Ime</th>
            <th>Prezime</th>
            <th>Datum rodjenja</th>
            <th>Telefon</th>
            <th>Email</th>
            <th>Grad</th>
            <th>Drzava</th>
            <th>Jezik koji govori</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
         foreach (var x in Model.rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.DatumRodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
           Write(x.NazivGrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
                 foreach (var jezik in x.Jezik)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <td>  ");
#nullable restore
#line 35 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
                   Write(x.Jezik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            <td>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\TuristickiVodic\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seminarski_Turisticka_Agencija_Rs1.Models.TuristickiVodicIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
