#pragma checksum "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_City), @"mvc.1.0.view", @"/Views/Home/City.cshtml")]
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
#line 1 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\_ViewImports.cshtml"
using CeylanTurizm.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\_ViewImports.cshtml"
using CeylanTurizm.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\_ViewImports.cshtml"
using CeylanTurizm.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\_ViewImports.cshtml"
using CeylanTurizm.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd23938fa1aeed210ebfa615cb8c7e18abd0be3d", @"/Views/Home/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99de08a19770245eb2c9863784d4ba81d337b368", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_City : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("date"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExpeditionList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
  
    foreach (var item in Model.CitiesByCityName)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container-admin text-white   mt-4\">\r\n            <div class=\"city-name mt-3\">\r\n                ");
#nullable restore
#line 8 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
           Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Otobus Biletleri
            </div>
            <div class=""container-main"">
                <div class=""d-flex container-main-top"">
                    <div class=""row w-100"">
                        <div class=""ticket-form  col-md-6"">
                            <div class=""ticket-buttons"">
                                <button class=""btn btn-sm btn-danger w-50"">Tek Yön</button>
                                <button class=""btn btn-sm btn-secondary w-50"">Gidiş Dönüş</button>
                            </div>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d7213", async() => {
                WriteLiteral("\r\n                                <div class=\"mt-4\">\r\n                                    <div><i class=\"fa-solid fa-location-dot\"></i>Kalkış</div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d7662", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                          
                                            foreach (var city in Model.CitiesAll)
                                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d8361", async() => {
#nullable restore
#line 26 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                                   Write(city.CityName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 22 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sales.cityStart);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div class=\"mt-5\"><i class=\"fa-solid fa-location-dot\"></i>Varış</div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d11486", async() => {
                    WriteLiteral("\r\n\r\n");
#nullable restore
#line 33 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                          
                                            foreach (var city in Model.CitiesAll)
                                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d12190", async() => {
#nullable restore
#line 36 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                                   Write(city.CityName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                                if (item.CityName == city.CityName)
                                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d13853", async() => {
#nullable restore
#line 39 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                                                       Write(city.CityName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                                                }
                                            }
                                        

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 31 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sales.cityFinish);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div class=\"mt-5\">\r\n                                        <i class=\"fa-regular fa-calendar-days\"></i>Gidişarihi\r\n                                    </div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd23938fa1aeed210ebfa615cb8c7e18abd0be3d17811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 47 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sales.date);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <span class=""text-danger"" id=""date-control""></span>
                                </div>

                                <input type=""submit"" class=""btn btn-danger w-100 mt-4"" id=""sefer-btn"" value=""Sefer Ara"" />

                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"city-image col-md-6\">\r\n                            <img src=\"https://picsum.photos/id/111/600/400\" class=\"ms-3\" style=\"width: 100%;\"");
            BeginWriteAttribute("alt", " alt=\"", 3150, "\"", 3156, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"mt-3\">\r\n                    <div>");
#nullable restore
#line 61 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                    Write(item.CityTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"mt-3\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                   Write(item.CityDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"mt-4\">\r\n                        <span style=\"font-size: 20pt; font-weight: bold;\">Tarihin Kokusunu Almak İçin Gezilecek Yerler</span><br>\r\n                        ");
#nullable restore
#line 67 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                   Write(item.CityDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"mt-4\">\r\n                        <span style=\"font-size: 20pt; font-weight: bold;\">Görsel Şölen Yerler</span><br>\r\n                        ");
#nullable restore
#line 71 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                   Write(item.CityDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"mt-4\">\r\n                        <span style=\"font-size: 20pt; font-weight: bold;\">Sanatla Buluşma Noktaları</span><br>\r\n                        ");
#nullable restore
#line 75 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                   Write(item.CityDescription4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"mt-4\">\r\n                        <span style=\"font-size: 20pt; font-weight: bold;\">Nerede Ne Yesek</span><br>\r\n                        ");
#nullable restore
#line 79 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
                   Write(item.CityDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br><br>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 85 "C:\Users\osman\Desktop\Dersler\CeylanTurizmApp\CeylanTurizm.WebUI\Views\Home\City.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
