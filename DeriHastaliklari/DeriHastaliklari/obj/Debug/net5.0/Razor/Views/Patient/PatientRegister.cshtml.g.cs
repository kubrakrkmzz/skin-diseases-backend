#pragma checksum "C:\Users\Berkan\source\repos\DeriHastaliklari\DeriHastaliklari\Views\Patient\PatientRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8682a6b87660be972e8fd3e81ade98bbd4232c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientRegister), @"mvc.1.0.view", @"/Views/Patient/PatientRegister.cshtml")]
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
#line 1 "C:\Users\Berkan\source\repos\DeriHastaliklari\DeriHastaliklari\Views\_ViewImports.cshtml"
using DeriHastaliklari;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berkan\source\repos\DeriHastaliklari\DeriHastaliklari\Views\_ViewImports.cshtml"
using DeriHastaliklari.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8682a6b87660be972e8fd3e81ade98bbd4232c1c", @"/Views/Patient/PatientRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c48b6dbdd02c16e8c8ebf865023529932880d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/hasta-kayit-birlesik/styles/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/hasta-kayit-birlesik/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-sag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("wf-form-"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-name", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Berkan\source\repos\DeriHastaliklari\DeriHastaliklari\Views\Patient\PatientRegister.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8682a6b87660be972e8fd3e81ade98bbd4232c1c7449", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta charset=""utf-8"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Readex+Pro&display=swap"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8682a6b87660be972e8fd3e81ade98bbd4232c1c8072", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <title>Hasta Kayıt</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8682a6b87660be972e8fd3e81ade98bbd4232c1c9993", async() => {
                WriteLiteral("\r\n    <div class=\"containerust w-container\">\r\n        <div class=\"divblock\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8682a6b87660be972e8fd3e81ade98bbd4232c1c10347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""divsol"">


                <div class=""div-center"">
                    <div class=""text-block-7"">HASTA KAYIT</div>
                    <div class=""divorta"">
                        <div class=""divust"">
                            <div class=""text-block-8"">KİŞİSEL BİLGİLER</div>
                        </div>
                        <div class=""divalt"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8682a6b87660be972e8fd3e81ade98bbd4232c1c11953", async() => {
                    WriteLiteral(@"
                            <div class=""divaltsol"">
                                <div class=""form-block w-form"">
                                        <div class=""div-block-3"">
                                            <div class=""text-block-9"">AD:</div>
                                            <input type=""text"" class=""text-field-2 w-input"" maxlength=""256"" name=""Name"" data-name=""Field"" placeholder=""Adınız"" id=""field""");
                    BeginWriteAttribute("required", " required=\"", 1684, "\"", 1695, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                        <div class=""div-block-3"">
                                            <div class=""text-block-10"">SOYAD:</div>
                                            <input type=""text"" class=""text-field w-input"" maxlength=""256"" name=""Surname"" data-name=""Field 4"" placeholder=""Soyadınız"" id=""field-4""");
                    BeginWriteAttribute("required", " required=\"", 2078, "\"", 2089, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                        <div class=""div-block-3"">
                                            <div class=""text-block-11"">T.C KİMLİK NUMARASI:</div>
                                            <input type=""text"" class=""text-field-3 w-input"" maxlength=""256"" name=""TcNo"" data-name=""Field 3"" placeholder=""TC numaranız"" id=""field-3""");
                    BeginWriteAttribute("required", " required=\"", 2488, "\"", 2499, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                </div>
                            </div>
                            <div class=""divaltsag"">
                                <div class=""w-form"">
                                   
                                        <div class=""div-block-2"">
                                            <div class=""text-block-12"">DOĞUM TARİHİ:</div><input type=""text"" class=""text-field-6 w-input"" maxlength=""256"" name=""bthDay"" data-name=""Field 2"" placeholder=""Gün/Ay/Yıl"" id=""field-2""");
                    BeginWriteAttribute("required", " required=\"", 3065, "\"", 3076, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                        <div class=""div-block-2"">
                                            <div class=""text-block-13"">E-POSTA:</div>
                                            <input type=""text"" class=""text-field-4 text-field-2 w-input"" maxlength=""256"" name=""Email"" data-name=""Field 2"" placeholder=""E-postanız"" id=""field-2""");
                    BeginWriteAttribute("required", " required=\"", 3475, "\"", 3486, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                        <div class=""div-block-2"">
                                            <div class=""text-block-14"">PAROLA:</div>
                                            <input type=""text"" class=""text-field-5 w-input"" maxlength=""256"" name=""Password"" data-name=""Field 2"" placeholder=""İstediğiniz parola"" id=""field-2""");
                    BeginWriteAttribute("required", " required=\"", 3882, "\"", 3893, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        </div>
                                   
                                </div>
                            </div>

                       

                    <div class=""divorta2"">
                        <div class=""divust2"">
                            <div class=""text-block-8"">SAĞLIK DURUMU</div>
                        </div><div class=""divalt2"">
                            <div class=""form-block w-form"">
                                <div class=""div-block-3"">
                                    <div class=""text-block-9"">Alerjiniz var mı?:</div>
                                    <input type=""text"" class=""text-field-alerji w-input"" maxlength=""256"" name=""Allergy"" data-name=""Field"" placeholder=""Var ise ne alerjiniz olduğunu belirtiniz"" id=""field""");
                    BeginWriteAttribute("required", " required=\"", 4719, "\"", 4730, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                </div>
                                <div class=""div-block-3"">
                                    <div class=""text-block-10 "">Kronik rahatsızlığınız var mı?:</div>
                                    <input type=""text"" class=""text-field-kronik w-input"" maxlength=""256"" name=""Disease"" data-name=""Field 4"" placeholder=""Var ise hangi hastalık olduğunu belirtiniz"" id=""field-4""");
                    BeginWriteAttribute("required", " required=\"", 5147, "\"", 5158, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                </div><div class=""div-block-3"">
                                    <div class=""text-block-11"">Aktif olarak kullandığınız ilaç var mı?:</div>
                                    <input type=""text"" class=""text-field-ilac w-input"" maxlength=""256"" name=""Medicine"" data-name=""Field 3"" placeholder=""Var ise ilaç(lar)ınızın ismini giriniz"" id=""field-3""");
                    BeginWriteAttribute("required", " required=\"", 5544, "\"", 5555, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <input class=\"btn\" type=\"submit\"");
                    BeginWriteAttribute("name", " name=\"", 5755, "\"", 5762, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"KAYDET\">\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Berkan\source\repos\DeriHastaliklari\DeriHastaliklari\Views\Patient\PatientRegister.cshtml"
AddHtmlAttributeValue("", 1201, Url.Action("PatientRegisterSave","Patient"), 1201, 44, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"divsag\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 5958, "\"", 5964, 0);
                EndWriteAttribute();
                WriteLiteral(" loading=\"lazy\"");
                BeginWriteAttribute("alt", " alt=\"", 5980, "\"", 5986, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"logo2\" />\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
