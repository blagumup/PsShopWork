#pragma checksum "C:\Users\blagu\Source\Repos\PSShopWork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c9314acb9becb63d73813d6db144445f18a49e"
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
#line 1 "C:\Users\blagu\Source\Repos\PSShopWork\Views\_ViewImports.cshtml"
using PlayStation_Shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\blagu\Source\Repos\PSShopWork\Views\_ViewImports.cshtml"
using PlayStation_Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c9314acb9becb63d73813d6db144445f18a49e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cdaf264bee6f30363e67bbf3ae002f8bfedc64c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 55, true);
            WriteLiteral("\r\n<h1>Лучшие товары</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "C:\Users\blagu\Source\Repos\PSShopWork\Views\Home\Index.cshtml"
      
        foreach (Product product in Model.FavProducts)
        {
            

#line default
#line hidden
            BeginContext(165, 36, false);
#line 8 "C:\Users\blagu\Source\Repos\PSShopWork\Views\Home\Index.cshtml"
       Write(Html.Partial("AllProducts", product));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\blagu\Source\Repos\PSShopWork\Views\Home\Index.cshtml"
                                                 
        }
    

#line default
#line hidden
            BeginContext(221, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
