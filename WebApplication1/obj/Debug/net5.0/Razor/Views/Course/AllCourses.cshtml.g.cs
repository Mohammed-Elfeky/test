#pragma checksum "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5692ce4d4c303c7ccd23d21b1add93f3892ca702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_AllCourses), @"mvc.1.0.view", @"/Views/Course/AllCourses.cshtml")]
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
#line 1 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5692ce4d4c303c7ccd23d21b1add93f3892ca702", @"/Views/Course/AllCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8bf045fc77d7267a7f635ee5fe4bb5453c7a78", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_AllCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
  
    ViewData["Title"] = "AllCourses";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">id</th>
      <th scope=""col"">name</th>
      <th scope=""col"">degree</th>
      <th scope=""col"">minDegree</th>
      <th scope=""col"">deartment</th>
    </tr>
  </thead>
  <tbody>
   
   
");
#nullable restore
#line 19 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
         foreach (allcoursesVM c in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              <td>");
#nullable restore
#line 22 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
             Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 23 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
             Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 24 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
             Write(c.degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 25 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
             Write(c.minDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 26 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
             Write(c.dept_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("              <td>\r\n                  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 743, "\"", 769, 3);
            WriteAttributeValue("", 753, "whenClick(", 753, 10, true);
#nullable restore
#line 29 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
WriteAttributeValue("", 763, c.Id, 763, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 768, ")", 768, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n                     edit\r\n                  </button>\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Course\AllCourses.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<a href=""/Course/AddCourse/""  class=""btn btn-success"">Add</a>


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body py-4"">
        
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
      </div>
    </div>
  </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5692ce4d4c303c7ccd23d21b1add93f3892ca7027726", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function whenClick(id){
       $.ajax({
                  url:""/Course/updateCourseAsPartial/""+id,
                  success: function(result){
                      console.log(result)
                          $("".modal-body"").html(result)
                    }
             });
    }
</script>");
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
