#pragma checksum "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff919011777569f5ce7e82aa805feb5ff79447a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\_ViewImports.cshtml"
using MVC_Razor_Example;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\_ViewImports.cshtml"
using MVC_Razor_Example.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff919011777569f5ce7e82aa805feb5ff79447a0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a74c19751487c9807310efbd03ec378310bffff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Razor Syntax Example</h1>\r\n\r\n<h2>today is ");
#nullable restore
#line 6 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
        Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>today is ");
#nullable restore
#line 7 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
        Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 9 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
  
    var name = "Giri Babu ";
    var message = " Weclcome to asp.net core MVC class ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Name :");
#nullable restore
#line 14 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
      Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2> ");
#nullable restore
#line 15 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 17 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
 if(DateTime.IsLeapYear(DateTime.Now.Year))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" is a leap year\r\n");
#nullable restore
#line 20 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
}
else
{
     

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" is not a leap year\r\n");
#nullable restore
#line 24 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n\r\n\r\n");
#nullable restore
#line 28 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
 for(int i=0; i<10;i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 31 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
  
    var principleamount = 100000;
    var IntrestRate = 4;
    var numOfTerms = 12;

    var emi = principleamount / 100 * IntrestRate * numOfTerms;




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Principle amount :");
#nullable restore
#line 44 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
                  Write(principleamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Intrest Rate :");
#nullable restore
#line 45 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
             Write(IntrestRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Num Of TErms :");
#nullable restore
#line 46 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
             Write(numOfTerms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>EMI to be paid :");
#nullable restore
#line 47 "D:\ASP.NET\MVC_Razor_Example\MVC_Razor_Example\Views\Home\Index.cshtml"
               Write(emi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
