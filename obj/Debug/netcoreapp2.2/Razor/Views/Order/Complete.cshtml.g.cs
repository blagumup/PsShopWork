#pragma checksum "C:\Users\blagu\Source\Repos\PSShopWork\Views\Order\Complete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b2162f63b97297d88e98fc2646130b044f72e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Complete), @"mvc.1.0.view", @"/Views/Order/Complete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Complete.cshtml", typeof(AspNetCore.Views_Order_Complete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b2162f63b97297d88e98fc2646130b044f72e5", @"/Views/Order/Complete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cdaf264bee6f30363e67bbf3ae002f8bfedc64c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Complete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(5, 15, false);
#line 1 "C:\Users\blagu\Source\Repos\PSShopWork\Views\Order\Complete.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(20, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
