#pragma checksum "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "862b427cf1dde6af27e88119865c2e212db8998a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Korisnik_Index), @"mvc.1.0.view", @"/Views/Korisnik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862b427cf1dde6af27e88119865c2e212db8998a", @"/Views/Korisnik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6994151c0fe008ac422a089836b70f8b035c847d", @"/Views/_ViewImports.cshtml")]
    public class Views_Korisnik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seminarski_Turisticka_Agencija_Rs1.Models.KorisnikIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rezervacija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "862b427cf1dde6af27e88119865c2e212db8998a4096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AdministratorId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
                            WriteLiteral(Model.AdministratorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h1>Podaci o korisnicima turisticke agencije:</h1>
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
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
         foreach (var x in Model.rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.DatumRodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.NazivGrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
               Write(x.NazivDrzave);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "862b427cf1dde6af27e88119865c2e212db8998a9613", async() => {
                WriteLiteral("Pregled rezervacija");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
                                                                         WriteLiteral(x.KorisnikId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Korisnik\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seminarski_Turisticka_Agencija_Rs1.Models.KorisnikIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
