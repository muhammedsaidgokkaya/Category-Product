#pragma checksum "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d32dc5db758ff83eae21f46b9df311f992664c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryDetails), @"mvc.1.0.view", @"/Views/Home/CategoryDetails.cshtml")]
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
#line 1 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\_ViewImports.cshtml"
using Kategori;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
using Kategori.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d32dc5db758ff83eae21f46b9df311f992664c", @"/Views/Home/CategoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8c3ec66de15d5a2ff2e799b13bb8f838fbf701", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urunler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
  
    ViewData["Title"] = "Ürün Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
     foreach (var a in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "75d32dc5db758ff83eae21f46b9df311f992664c4561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 378, "~/Image/", 378, 8, true);
#nullable restore
#line 15 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
AddHtmlAttributeValue("", 386, a.ImgName, 386, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <br />\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
                                      Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
                                     Write(a.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h6>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
                                    Write(a.Description.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n                    <p class=\"card-text\">\r\n                        <a class=\"btn btn-danger read-m\"");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 778, 3);
            WriteAttributeValue("", 754, "/Home/UrunDetails/", 754, 18, true);
#nullable restore
#line 21 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
WriteAttributeValue("", 772, a.Id, 772, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 777, "/", 777, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Ürün Detay</a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Home\CategoryDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urunler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
