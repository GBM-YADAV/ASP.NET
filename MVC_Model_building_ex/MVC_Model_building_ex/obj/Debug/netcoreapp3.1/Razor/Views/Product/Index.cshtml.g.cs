#pragma checksum "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e695c4121c4e5f86e3a4d12e81b9cc11d13f6647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\_ViewImports.cshtml"
using MVC_Model_building_ex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\_ViewImports.cshtml"
using MVC_Model_building_ex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e695c4121c4e5f86e3a4d12e81b9cc11d13f6647", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccdc3fc439837705e587664242ef64374ce91910", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Model_building_ex.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>This is the details of the product </h1>\r\n\r\n<table border=\"1\">\r\n\t<thead>\r\n\t\t<th>Product id</th>\r\n\t\t<th>Product Name</th>\r\n\t\t<th>Product Cost</th>\r\n\t\t<th>Category</th>\r\n\t</thead>\r\n\t\r\n");
#nullable restore
#line 14 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
         foreach(var i in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t<td> ");
#nullable restore
#line 17 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
            Write(i.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td> ");
#nullable restore
#line 18 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
            Write(i.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td> ");
#nullable restore
#line 19 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
            Write(i.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td> ");
#nullable restore
#line 20 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
            Write(i.proCate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 22 "D:\ASP.NET\MVC_Model_building_ex\MVC_Model_building_ex\Views\Product\Index.cshtml"
		
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Model_building_ex.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
