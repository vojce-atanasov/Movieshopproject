#pragma checksum "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9552a7bb13fb6b833a5080b740d121bc7b00f624"
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
#line 1 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\_ViewImports.cshtml"
using Movieshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\_ViewImports.cshtml"
using Movieshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9552a7bb13fb6b833a5080b740d121bc7b00f624", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0def39c751d7a6c97ca2ea0f4dcab62d38aa395e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movieshop.Entities.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:500px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/movie/movie.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n\n<!-- Banner Section -->\n<div");
            BeginWriteAttribute("id", " id=\"", 119, "\"", 124, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"container-fluid banner m-0 pl-0 pr-0\">\n    <!-- SEARCH SECTION -->\n    <div class=\"container\" >\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9552a7bb13fb6b833a5080b740d121bc7b00f6245236", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-12 "">
                    <div class=""p-3 search-main search-minus-85"">
                        <button class=""btn"">
                            <i class=""fas fa-search search-btn-icon""></i>
                        </button>
                        <input id=""searchBook"" type=""text"" placeholder=""Search"" class=""form-control search-box-style"" />
                        <button id=""searchButton"" class=""btn btn-success search-button"">Search</button>
                    </div>
                </div>
            </div>          
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-12 col-md-7 quote-section"">
            <blockquote class=""quote-text-quote"" id=""quote"">
                <p class=""quote-text-actor"" id=""quote_Actor""></p>
                <p class=""quote-text-tags"" id=""quote_tags""></p>
            </blockquote>
        </div>
    </div>
</div>

<!-- All Books Section -->
<div class=""container-fluid text-center m-0 p-0"">
    <h2 class=""mt-5"" style=""font-family: fantasy"">MOVIES</h2>  
    <div class=""row"">
");
#nullable restore
#line 47 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
         foreach (var movie in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-6 col-md-3 col-lg-2 mt-5\">\n                <div class=\"card background1\" ");
            WriteLiteral(" >\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9552a7bb13fb6b833a5080b740d121bc7b00f6248238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1861, "~/photos/", 1861, 9, true);
#nullable restore
#line 51 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1870, movie.URL, 1870, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"card-body\" style=\"height:300px !important\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 53 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <hr />\n                        <h6");
            BeginWriteAttribute("class", " class=\"", 2166, "\"", 2174, 0);
            EndWriteAttribute();
            WriteLiteral("><em>Cast:&nbsp;</em>");
#nullable restore
#line 55 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => movie.ActersName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n                        <p class=\"card-text\">Category:&nbsp;");
#nullable restore
#line 56 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => movie.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                        <p class=\"card-text\">Rating:&nbsp;");
#nullable restore
#line 57 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => movie.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                        <button");
            BeginWriteAttribute("id", " id=\"", 2503, "\"", 2508, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-block\">\n                            <i class=\"fas fa-plus\"></i>&nbsp;Add to Wishlist\n                        </button>\n                        <button");
            BeginWriteAttribute("id", " id=\"", 2689, "\"", 2694, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-block\">\n                            <i class=\"fas fa-cart-plus\"></i>&nbsp;Add to Cart\n                        </button>\n                    </div>\n                </div>\n           </div>              \n");
#nullable restore
#line 67 "C:\Users\User\Desktop\MovieShop\Movieshop\Views\Home\Index.cshtml"
         }     

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> \n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9552a7bb13fb6b833a5080b740d121bc7b00f62412543", async() => {
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
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movieshop.Entities.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
