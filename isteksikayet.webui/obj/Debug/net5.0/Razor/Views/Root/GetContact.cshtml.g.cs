#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8ba5ede8a5f6b42e43f0a62edc8cce48899510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Root_GetContact), @"mvc.1.0.view", @"/Views/Root/GetContact.cshtml")]
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
#line 1 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using isteksikayet.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using isteksikayet.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using isteksikayet.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\_ViewImports.cshtml"
using isteksikayet.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa8ba5ede8a5f6b42e43f0a62edc8cce48899510", @"/Views/Root/GetContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661a020172472c0ade1eab325056dc85aaf744ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Root_GetContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserContact>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
  
    ViewData["Title"] = "GetContact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Contacts</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Contacts</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">

        <!-- Default box -->
        <div class=""card card-solid"">
            <div class=""card-body pb-0"">
                <div class=""row"">
");
#nullable restore
#line 32 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                     foreach (var item in Model)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column"">
                            <div class=""card bg-light d-flex flex-fill"">
                                <div class=""card-header text-muted border-bottom-0"">
                                    ");
#nullable restore
#line 37 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                               Write(item.User.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""card-body pt-0"">
                                    <div class=""row"">
                                        <div class=""col-7"">
                                            <h2 class=""lead""><b>");
#nullable restore
#line 42 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                           Write(item.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                                           Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                                            <p class=\"text-muted text-sm\"><b>Rolles: </b> ");
#nullable restore
#line 43 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                                                           foreach (var role in item.Roles)
                                                                                         {
                                                                                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                                                         Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("/ \r\n");
#nullable restore
#line 46 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                                                             
                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                            <ul class=\"ml-4 mb-0 fa-ul text-muted\">\r\n                                                <li class=\"small\"><span class=\"fa-li\"><i class=\"fas fa-lg fa-phone\"></i></span> Dahili : ");
#nullable restore
#line 49 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                                                                                                                    Write(item.User.LocalNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                        <div class=\"col-5 text-center\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa8ba5ede8a5f6b42e43f0a62edc8cce4889951010263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2721, "~/files/", 2721, 8, true);
#nullable restore
#line 53 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
AddHtmlAttributeValue("", 2729, item.User.ImgUrl, 2729, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"card-footer\">\r\n                                    <div class=\"text-right\">\r\n");
#nullable restore
#line 59 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                         if(User.IsInRole("Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\" class=\"btn btn-sm btn-primary\">\r\n                                                <i class=\"fas fa-user\"></i> View Profile\r\n                                            </a>\r\n");
#nullable restore
#line 63 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\GetContact.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <!-- /.card-body -->\r\n           \r\n            <!-- /.card-footer -->\r\n        </div>\r\n        <!-- /.card -->\r\n\r\n    </section>\r\n    <!-- /.content -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserContact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591