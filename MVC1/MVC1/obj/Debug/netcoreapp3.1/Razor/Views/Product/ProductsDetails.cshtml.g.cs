#pragma checksum "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59bb7500e531941515e3ef33eca4a4f815aacc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductsDetails), @"mvc.1.0.view", @"/Views/Product/ProductsDetails.cshtml")]
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
#line 1 "D:\ASP.NET\MVC1\MVC1\Views\_ViewImports.cshtml"
using MVC1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\MVC1\MVC1\Views\_ViewImports.cshtml"
using MVC1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59bb7500e531941515e3ef33eca4a4f815aacc64", @"/Views/Product/ProductsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b061b4c5514280911abcc8f1d494d06908ee8c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_ProductsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>This is the details of the product </h1>\r\n");
#nullable restore
#line 2 "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml"
  
	var pro = ViewData["product"] as Product;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Product Id   : ");
#nullable restore
#line 7 "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml"
              Write(pro.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Product Name : ");
#nullable restore
#line 8 "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml"
              Write(pro.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h1>Product Cost : ");
#nullable restore
#line 9 "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml"
              Write(pro.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Category     : ");
#nullable restore
#line 10 "D:\ASP.NET\MVC1\MVC1\Views\Product\ProductsDetails.cshtml"
              Write(pro.proCate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
