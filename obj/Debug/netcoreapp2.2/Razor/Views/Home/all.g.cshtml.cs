#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7daf01fe976b2a105b67c33c7498ac8699f97e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_all), @"mvc.1.0.view", @"/Views/Home/all.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/all.cshtml", typeof(AspNetCore.Views_Home_all))]
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/_ViewImports.cshtml"
using crudelicious;

#line default
#line hidden
#line 4 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
using crudelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7daf01fe976b2a105b67c33c7498ac8699f97e5b", @"/Views/Home/all.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1344efeabb6281de7249210f4b4c13df6c6eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_all : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(87, 546, true);
            WriteLiteral(@"<style>
    .jumbotron{
            background-image: url(""img/foody2.png"");
            background-size: cover;
            text-align: center;
        }
    .card{
        display: inline-block;
    }

</style>
<div class=""jumbotron"">
    <h1 class=""display-4 text-info"">crudelicious.</h1>
</div>

<table class=""table-striped table"">
    <thead>
        <tr>
            <th>Dish</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 32 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
         foreach(Dish dish in Model)
        {

#line default
#line hidden
            BeginContext(680, 57, true);
            WriteLiteral("            <tr>\n                <td><a class=\"text-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 737, "\"", 753, 2);
            WriteAttributeValue("", 744, "/", 744, 1, true);
#line 35 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
WriteAttributeValue("", 745, dish.id, 745, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(754, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(756, 9, false);
#line 35 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
                                                     Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(765, 30, true);
            WriteLiteral("</a></td>\n                <td>");
            EndContext();
            BeginContext(796, 9, false);
#line 36 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
               Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(805, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(832, 14, false);
#line 37 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
               Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(846, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(873, 13, false);
#line 38 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
               Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(886, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(913, 16, false);
#line 39 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
               Write(dish.Description);

#line default
#line hidden
            EndContext();
            BeginContext(929, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 41 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/crudelicious/Views/Home/all.cshtml"
        }

#line default
#line hidden
            BeginContext(963, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
