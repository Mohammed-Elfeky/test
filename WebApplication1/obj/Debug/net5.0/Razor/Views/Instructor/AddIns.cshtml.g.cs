#pragma checksum "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ba10443a7ca644772b573d4ce90f306bbbfc90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_AddIns), @"mvc.1.0.view", @"/Views/Instructor/AddIns.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ba10443a7ca644772b573d4ce90f306bbbfc90", @"/Views/Instructor/AddIns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8bf045fc77d7267a7f635ee5fe4bb5453c7a78", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Instructor_AddIns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddInsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Instructor/SaveIns/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
  
    ViewData["Title"] = "AddIns";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ba10443a7ca644772b573d4ce90f306bbbfc905489", async() => {
                WriteLiteral("\r\n\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputEmail1\">name</label>\r\n    <input name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 257, "\"", 276, 1);
#nullable restore
#line 16 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
WriteAttributeValue("", 265, Model.Name, 265, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" id=""exampleInputEmail1""
    aria-describedby=""emailHelp"" 
    >
    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
  </div>
  <div class=""form-group"">
    <label  for=""exampleInputPassword1"">address</label>
    <input name=""address""");
                BeginWriteAttribute("value", " value=\"", 609, "\"", 631, 1);
#nullable restore
#line 23 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
WriteAttributeValue("", 617, Model.address, 617, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" id=\"exampleInputPassword1\" >\r\n  </div>\r\n\r\n  <div class=\"form-group\">\r\n    <label  for=\"exampleInputPassword1\">salary</label>\r\n    <input name=\"salary\"");
                BeginWriteAttribute("value", " value=\"", 816, "\"", 837, 1);
#nullable restore
#line 28 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
WriteAttributeValue("", 824, Model.salary, 824, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" id=\"exampleInputPassword1\" >\r\n  </div>\r\n\r\n\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleFormControlFile1\">Example file input</label>\r\n    <input name=\"image\"");
                BeginWriteAttribute("value", " value=\"", 1036, "\"", 1056, 1);
#nullable restore
#line 34 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
WriteAttributeValue("", 1044, Model.image, 1044, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""file"" class=""form-control-file"" id=""exampleFormControlFile1"">
  </div>
  <div class=""form-group"">
    <label for=""exampleFormControlSelect1"">Example select</label>
    <select name=""dept_id""  class=""form-control"" id=""depts"" onchange=""whenChangeDept()"">
");
#nullable restore
#line 39 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
       foreach ( Department d in @Model.depts)
       {
                if (@Model.dept_id == d.Id)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ba10443a7ca644772b573d4ce90f306bbbfc908814", async() => {
#nullable restore
#line 43 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                                                Write(d.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                                 WriteLiteral(d.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ba10443a7ca644772b573d4ce90f306bbbfc9011313", async() => {
#nullable restore
#line 47 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                                        Write(d.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                         WriteLiteral(d.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 48 "F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\Views\Instructor\AddIns.cshtml"
                }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </select>
  </div>

  <div class=""form-group"">
    <label for=""exampleFormControlSelect1"">Example select</label>
    <select    name=""crs_id""  class=""form-control"" id=""courses"">
    
    </select>
  </div>

  <input type=""submit"" class=""btn btn-primary"">Submit</input>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ba10443a7ca644772b573d4ce90f306bbbfc9015067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function whenChangeDept(){
        console.log(""hi"")
        $(""#courses"").html("""")
        $.ajax({
                  url:""/Course/coursesAsJson/""+$(""#depts"").val(),
                  success: function(result){
                      console.log(result);
                          for(var i=0;i<result.length;i++){
                              $(""#courses"").append(""<option value=""+result[0].id+"" >""+result[0].name+""</option>"")
                          }
                    }
             });
    }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddInsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
