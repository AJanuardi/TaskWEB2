#pragma checksum "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f92d81354deaeee5110103cfe6c7eb7282beda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaskWEB2.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f92d81354deaeee5110103cfe6c7eb7282beda", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9c456a8f89763cee0853179378815b2c5bf91c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
  
  Layout = "_LayoutAdmin";
  ViewData["Title"] = "Administrator Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<br>\r\n\r\n<button id=\"btn\" class=\"btn btn-primary\" onclick=\"location.href=\'/Add\'\">Add</button>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\"></div>\r\n        <div class=\"col-md-8\">\r\n<div class=\"text-center\">\r\n<h1>");
#nullable restore
#line 17 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<br>\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Judul</th>\r\n        <th>Highlight</th>\r\n        <th>Body</th>\r\n        <th>Publisher</th>\r\n        <th>Created</th>\r\n        <th>Action</th>\r\n    </tr>\r\n");
#nullable restore
#line 30 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
  
    ViewBag.data = ViewData["Data"];
    ViewBag.warning = ViewData["Warning"];
    var x = ViewBag.data;
    var y = ViewBag.warning;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
Write(y);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
      
    if (ViewBag.data != null)
    {
    foreach (var i in x)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 41 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.judul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
           Write(i.created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f92d81354deaeee5110103cfe6c7eb7282beda6620", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1131, "\"", 1151, 2);
                WriteAttributeValue("", 1139, "remove-", 1139, 7, true);
#nullable restore
#line 49 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
WriteAttributeValue("", 1146, i.id, 1146, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <button id=\"btn\" class=\"btn btn-danger\">Delete</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <button data-id=\"");
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
                            Write(i.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-warning\"");
            BeginWriteAttribute("id", " id=\"", 1316, "\"", 1331, 2);
            WriteAttributeValue("", 1321, "edit-", 1321, 5, true);
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
WriteAttributeValue("", 1326, i.id, 1326, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-judul=\"");
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
                                                                                       Write(i.judul);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-highlight=\"");
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
                                                                                                                 Write(i.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-body=\"");
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
                                                                                                                                          Write(i.body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-publisher=\"");
#nullable restore
#line 52 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
                                                                                                                                                                   Write(i.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\">Edit</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "D:\Users\bsi50130\Downloads\TaskWEB2\Pages\Admin.cshtml"
    }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
</div>
</div>
</div>

<div class=""modal"" id=""exampleModal"" tabindex=""-1"" role=""dialog"">
      <div class=""modal-dialog"" role=""document"" >
        <div class=""modal-content"" style=""width:500px;height:640px"">
          <div class=""modal-header"">
            <h4 class=""modal-title""><b>Update Data</b></h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f92d81354deaeee5110103cfe6c7eb7282beda11446", async() => {
                WriteLiteral("\r\n          <div class=\"modal-body text-center\">\r\n            <label for=\"title\"><b>Title</b></label><br>\r\n            <input type=\"text\" name=\"edit\" value=\"edit-\" hidden>\r\n            <input type=\"text\" name=\"id\" id=\"id1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2331, "\"", 2339, 0);
                EndWriteAttribute();
                WriteLiteral(@" hidden>
            <input type=""text"" name=""judul"" id=""title1"" class=""form-control"">
            <br><br>
            <label for=""description""><b>Highlight</b></label><br>
            <input type=""text""  name=""highlight"" id=""highlight1"" class=""form-control"">
            <br><br>
            <label for=""image""><b>Body</b></label><br>
            <input type=""text"" name=""body"" id=""body1"" class=""form-control"">
            <br><br>
            <label for=""image""><b>Published</b></label><br>
            <input type=""text"" name=""publisher"" id=""published1"" class=""form-control"">
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color: red;color:white;"">Close</button>
            <button type=""submit"" class=""btn btn-primary"" id=""savechanges"">Save changes</button>
          </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
    integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n""
    crossorigin=""anonymous"">
    </script>
<script>
    $(document).ready(function(){
        console.log('Masuk Sini')
        $('#exampleModal').on('show.bs.modal', function (e) {
        $('#id1').val($(e.relatedTarget).data('id'))
        $('#title1').val($(e.relatedTarget).data('judul'))
        $('#highlight1').val($(e.relatedTarget).data('highlight'))
        $('#body1').val($(e.relatedTarget).data('body'))
        $('#published1').val($(e.relatedTarget).data('publisher'))
    })
})
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel>)PageContext?.ViewData;
        public AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
