#pragma checksum "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccaaec80a3c31f115ae05626f0499d0824b7fcef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_studet), @"mvc.1.0.view", @"/Views/My/studet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccaaec80a3c31f115ae05626f0499d0824b7fcef", @"/Views/My/studet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b061b4c5514280911abcc8f1d494d06908ee8c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_My_studet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>my details</h1>\r\n");
#nullable restore
#line 2 "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml"
  
	

	var Stu = ViewData["studentData"] as Student;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>ID  : ");
#nullable restore
#line 9 "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml"
     Write(Stu.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><br>\r\n\r\n<h2>Name : ");
#nullable restore
#line 11 "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml"
      Write(Stu.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml"
                     Write(Stu.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br>\r\n\r\n<h2>Marks  : ");
#nullable restore
#line 14 "D:\ASP.NET\MVC1\MVC1\Views\My\studet.cshtml"
        Write(Stu.marks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br>\r\n");
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