#pragma checksum "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e898741d55715d4a547c2a552c996ce661337b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateUrun), @"mvc.1.0.view", @"/Views/Admin/UpdateUrun.cshtml")]
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
#line 1 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
using Kategori.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e898741d55715d4a547c2a552c996ce661337b19", @"/Views/Admin/UpdateUrun.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8c3ec66de15d5a2ff2e799b13bb8f838fbf701", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateUrun : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Urunler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/UpdateUrun"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
  
    ViewData["Title"] = "UpdateUrun";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Ürün Düzenle</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e898741d55715d4a547c2a552c996ce661337b194570", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label>Id</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 346, "\"", 363, 1);
#nullable restore
#line 14 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
WriteAttributeValue("", 354, Model.Id, 354, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" readonly />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ürün İsmi</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 511, "\"", 530, 1);
#nullable restore
#line 18 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
WriteAttributeValue("", 519, Model.Name, 519, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ürün Fiyatı</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 673, "\"", 693, 1);
#nullable restore
#line 22 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
WriteAttributeValue("", 681, Model.Price, 681, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Price\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ürün Açıklaması</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 841, "\"", 867, 1);
#nullable restore
#line 26 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
WriteAttributeValue("", 849, Model.Description, 849, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Description\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ürün Kategori Numarası</label>\r\n        ");
#nullable restore
#line 30 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
   Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.Category, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Resim Uzantısı</label>\r\n        <input type=\"file\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1232, "\"", 1254, 1);
#nullable restore
#line 34 "C:\Users\gokka\Desktop\Yeni klasör\Kategori\Kategori\Views\Admin\UpdateUrun.cshtml"
WriteAttributeValue("", 1240, Model.ImgFile, 1240, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ImgFile\" />\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\" value=\"kaydet\">Kaydet</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Urunler> Html { get; private set; }
    }
}
#pragma warning restore 1591
