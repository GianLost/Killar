#pragma checksum "D:\Workspace\Killar\Views\Users\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c9a22205422f6d78476338038b8a21e003fa8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserList), @"mvc.1.0.view", @"/Views/Users/UserList.cshtml")]
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
#line 1 "D:\Workspace\Killar\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Killar\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c9a22205422f6d78476338038b8a21e003fa8c", @"/Views/Users/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Users>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
  
    ViewData["Title"] = "Listagem De Usuários Cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c9a22205422f6d78476338038b8a21e003fa8c4798", async() => {
                WriteLiteral("\r\n\r\n    <main role=\"main userFormList-container\">\r\n\r\n        <div class=\"container-fluid \">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-md-10 col-xl-10 col-lg-10 col-sm-10 userFormList\">\r\n\r\n                    <h4>");
#nullable restore
#line 17 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                   Write(ViewData["msg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c9a22205422f6d78476338038b8a21e003fa8c5663", async() => {
                    WriteLiteral(@"

                                <div class=""form-group mb-2"">

                                    <p style=""float:left; margin-right:10px;"">
                                        <!-- *********** Retirar estilos in-line *********** -->
                                        <input class=""btn btn-md btn-light text-justify"" type=""text""
                                            placeholder=""Busque por usuários"" name=""q"" />
                                        <input class=""btn btn-md btn-dark btn-searchUser"" type=""submit""
                                            value=""Pesquisar"" />
                                    </p>

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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n");
#nullable restore
#line 39 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                         if (Model.Count != 0)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <table class="" table table-responsive table-bordered table-striped table-light text-center"">

                                <thead class=""thead-dark text-center"">

                                    <tr>
                                        <th>Id</th>
                                        <th>Nome</th>
                                        <th>Data de Nascimento</th>
                                        <th>Nick WR</th>
                                        <th>Nome de Usuário</th>
                                        <th>Senha</th>
                                        <th>Lane</th>
                                        <th>Elo</th>
                                        <th>Tipo</th>

                                    </tr>

                                </thead>

                                <tbody>

");
#nullable restore
#line 63 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                     foreach (Users u in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 66 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 67 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 68 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.BirthDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 69 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.LoginWr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 70 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.LoginName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 71 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 72 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Lane);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 73 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Elo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 74 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                           Write(u.Tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3084, "\"", 3115, 2);
                WriteAttributeValue("", 3091, "/Users/UserEdit?id=", 3091, 19, true);
#nullable restore
#line 76 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
WriteAttributeValue("", 3110, u.Id, 3110, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-user-pen\"></i></a></td>\r\n                                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3214, "\"", 3247, 2);
                WriteAttributeValue("", 3221, "/Users/UserDelete?id=", 3221, 21, true);
#nullable restore
#line 77 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
WriteAttributeValue("", 3242, u.Id, 3242, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-user-xmark\"></i></a>\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 81 "D:\Workspace\Killar\Views\Users\UserList.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </tbody>\r\n\r\n                            </table>\r\n");
                WriteLiteral("                            <div class=\"filterButton-container\">\r\n\r\n                                <p>Páginas : </p>\r\n\r\n");
#nullable restore
#line 92 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                 for (int i = 1; i <= (int)ViewData["pageQuantity"]; i++)
                                { // paginação cria os links para as páginas

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a class=\"btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 3887, "\"", 3918, 2);
                WriteAttributeValue("", 3894, "/Users/UserList?pages=", 3894, 22, true);
#nullable restore
#line 94 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
WriteAttributeValue("", 3916, i, 3916, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 94 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 95 "D:\Workspace\Killar\Views\Users\UserList.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 99 "D:\Workspace\Killar\Views\Users\UserList.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"text-center\">Nenhum registro encontrado</strong>\r\n");
#nullable restore
#line 104 "D:\Workspace\Killar\Views\Users\UserList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                    <div style=""margin-top: 45px;"">
                        <a class=""btn btn-lg btn-dark"" href=""/Users/RegisterUser"">Cadastrar um novo usuario</a>
                    </div>

                </div>

            </div>

    </main>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
