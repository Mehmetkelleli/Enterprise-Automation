#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fedf4a794d6fe2aeccfab18e10f34e114b044fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Root_RoleUpdate), @"mvc.1.0.view", @"/Views/Root/RoleUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fedf4a794d6fe2aeccfab18e10f34e114b044fd", @"/Views/Root/RoleUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661a020172472c0ade1eab325056dc85aaf744ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Root_RoleUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Root", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Role Ad?? Ekle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
  
    ViewData["Title"] = "RoleDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
 if(TempData["Message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">");
#nullable restore
#line 8 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                       Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 9 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
        }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fedf4a794d6fe2aeccfab18e10f34e114b044fd8269", async() => {
                WriteLiteral(@"
  <div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1>Role G??ncelleme  ve Detaylar</h1>
          </div>
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fedf4a794d6fe2aeccfab18e10f34e114b044fd8956", async() => {
                    WriteLiteral("Anasayfa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
              <li class=""breadcrumb-item active"">Role Detay</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
      <div class=""container-fluid"">
        <div class=""row"">
          <!-- left column -->
          <div class=""col-md-6"">
            <!-- general form elements -->
            <div class=""card card-primary"">
              
              <!-- /.card-header -->
              <!-- form start -->
                <div class=""card-body"">
                  <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Role Ad??</label>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5fedf4a794d6fe2aeccfab18e10f34e114b044fd11131", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                                                                           WriteLiteral(Model.Role.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5fedf4a794d6fe2aeccfab18e10f34e114b044fd13637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 44 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                                                           WriteLiteral(Model.Role.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <!-- /.card-body -->
                <div class=""card-footer"">
                  <button type=""submit"" class=""btn btn-primary"">G??nder</button>
                </div>
            </div>
            <!-- /.card -->
          </div>
          <div class=""col-md-6"">
            <!-- general form elements -->
           <div class=""card card-primary"">
                <div class=""card-body"">
                        <h5 class=""mt-2"">Role Ait Olmayan Kullan??c??lar</h5>
                        <table class=""table"">
                                    
                                    
");
#nullable restore
#line 62 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                         foreach (var item in Model.NonMermbers)
                           {

#line default
#line hidden
#nullable disable
                WriteLiteral("                               <tr>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                          Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><input type=\"checkbox\" name=\"MembersAdd\"");
                BeginWriteAttribute("value", " value=\"", 2756, "\"", 2772, 1);
#nullable restore
#line 67 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
WriteAttributeValue("", 2764, item.Id, 2764, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                               </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </table>\r\n                        <h5>Role Ait Kullan??c??lar</h5>\r\n                        <table class=\"table\">\r\n                            \r\n                                   \r\n");
#nullable restore
#line 75 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                         foreach (var item in Model.Members)
                           {

#line default
#line hidden
#nullable disable
                WriteLiteral("                               <tr>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 78 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                                          Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 79 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><input type=\"checkbox\" name=\"MembersDelete\"");
                BeginWriteAttribute("value", " value=\"", 3407, "\"", 3423, 1);
#nullable restore
#line 80 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
WriteAttributeValue("", 3415, item.Id, 3415, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                               </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Mehmet Kelleli\Desktop\Web Ui Files\isteksikayetkurumotomasyonu\isteksikayet.webui\Views\Root\RoleUpdate.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                          
                        </table>
                  
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /.card -->
          </div>
          <!--/.col (right) -->
        </div>
        <!-- /.row -->
      </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
  </div>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
