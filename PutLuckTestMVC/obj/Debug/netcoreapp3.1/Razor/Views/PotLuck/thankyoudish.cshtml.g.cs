#pragma checksum "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa29afd269ef416eedb3fea3108162c8791d6a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PotLuck_thankyoudish), @"mvc.1.0.view", @"/Views/PotLuck/thankyoudish.cshtml")]
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
#line 1 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\_ViewImports.cshtml"
using PutLuckTestMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\_ViewImports.cshtml"
using PutLuckTestMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa29afd269ef416eedb3fea3108162c8791d6a4c", @"/Views/PotLuck/thankyoudish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f7dd657028048dad8c44d9b7a5d101cacf75da", @"/Views/_ViewImports.cshtml")]
    public class Views_PotLuck_thankyoudish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
  
    ViewData["Title"] = "Dish chosen, thank you!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    Thank you <b>");
#nullable restore
#line 6 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
            Write(Model.TMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> for choosing to bring a dish<br />\r\n</h1>\r\n<h5>\r\n    We will contact you using this phone number: <b>");
#nullable restore
#line 9 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
                                               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    <br />\r\n    The dish we have you bringing is: <b>");
#nullable restore
#line 11 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
                                    Write(Model.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    <br />\r\n    Dish Category: <b>");
#nullable restore
#line 13 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
                 Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    <br />\r\n    Dish Description: <b>");
#nullable restore
#line 15 "C:\Devbuild2021\PutLuckTestMVC\PutLuckTestMVC\Views\PotLuck\thankyoudish.cshtml"
                    Write(Model.DishDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</h5>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
