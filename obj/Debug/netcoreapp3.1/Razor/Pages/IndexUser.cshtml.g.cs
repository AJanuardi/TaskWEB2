#pragma checksum "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1db3f6aa646889b973ac39eae10be3f2474d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaskWEB2.Pages.Pages_IndexUser), @"mvc.1.0.razor-page", @"/Pages/IndexUser.cshtml")]
namespace TaskWEB2.Pages
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
#line 1 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\_ViewImports.cshtml"
using TaskWEB2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\_ViewImports.cshtml"
using TaskWEB2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1db3f6aa646889b973ac39eae10be3f2474d2e", @"/Pages/IndexUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9c456a8f89763cee0853179378815b2c5bf91c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_IndexUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
  
    ViewBag.items = ViewData["Data"];
    var x = ViewBag.items;
    foreach (var i in x)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>");
#nullable restore
#line 12 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
       Write(i.judul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5>");
#nullable restore
#line 13 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
       Write(i.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6>By ");
#nullable restore
#line 14 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
          Write(i.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 14 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
                          Write(i.created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <button id=\"btn\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 335, "\"", 382, 3);
            WriteAttributeValue("", 345, "window.location.href=\'/View?id=", 345, 31, true);
#nullable restore
#line 15 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
WriteAttributeValue("", 376, i.id, 376, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 381, "\'", 381, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Details</button>\r\n");
#nullable restore
#line 16 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\IndexUser.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexUserModel>)PageContext?.ViewData;
        public IndexUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
