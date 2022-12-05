#pragma checksum "E:\Killar\Views\Posts\PostList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5faca91d7dab2a16dc195d5cc4077fda60313dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_PostList), @"mvc.1.0.view", @"/Views/Posts/PostList.cshtml")]
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
#line 1 "E:\Killar\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Killar\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5faca91d7dab2a16dc195d5cc4077fda60313dec", @"/Views/Posts/PostList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Posts_PostList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Posts>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Conteudo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "8", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center list-body h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Killar\Views\Posts\PostList.cshtml"
  
    ViewData["Title"] = "Listagem De Usuários Cadastrados";

    int postsPerPage = Int32.Parse(ViewData["postsPerPage"].ToString());
    int currentPage = Int32.Parse(ViewData["currentPage"].ToString());
    int postsNumberPerPage = (Model.Count < postsPerPage ? Model.Count : postsPerPage);

    int pagesTotalNumber = 0;

    if (postsNumberPerPage > 0)
    {
        pagesTotalNumber = Model.Count / postsNumberPerPage + (Model.Count % postsNumberPerPage == 0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec6938", async() => {
                WriteLiteral("\r\n\r\n    <main role=\"main\" class=\"mb-5\">\r\n\r\n        <div class=\"container-fluid col-md-10 col-sm-12 \">\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec7327", async() => {
                    WriteLiteral(@"

                <div class=""col-md-12 p-3"">
                    <!-- *********** Retirar estilos in-line *********** -->
                    <div class=""row mt-3"">

                        <div class=""col-md-3"">

                            <select name=""FilterType"" class=""form-control mb-3"">
                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec7937", async() => {
                        WriteLiteral("Filtrar por...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec9264", async() => {
                        WriteLiteral("Autor");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec10582", async() => {
                        WriteLiteral("Conteúdo");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                            </select>
                        </div>

                        <div class=""col-md-3"">

                            <select class=""form-control mb-3"" name=""itemsPerPage"" id=""itemsPerPage"">
                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec12136", async() => {
                        WriteLiteral("Posts por página...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec13469", async() => {
                        WriteLiteral("/8");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faca91d7dab2a16dc195d5cc4077fda60313dec14785", async() => {
                        WriteLiteral(" Todos os Posts");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "E:\Killar\Views\Posts\PostList.cshtml"
                                  WriteLiteral(Model.Count);

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
                    WriteLiteral(@"

                            </select>

                        </div>

                        <div class=""col-md-3"">

                            <input type=""text"" class=""form-control"" placeholder=""Busque por Postagens"" name=""Filter""
                                class=""form-control"" />

                        </div>

                        <div class=""submitButton"">
                            <button class=""btn btn-md btn-dark"" type=""submit"">Pesquisar</button>
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 67 "E:\Killar\Views\Posts\PostList.cshtml"
             if (Model.Count != 0)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table class=""table table-responsive table-bordered table-striped table-light text-center"">

                    <thead class=""thead-dark text-center"">

                        <tr>

                            <th>Id</th>
                            <th>Autor</th>
                            <th>Data da Postagem</th>
                            <th>Conteúdo</th>
                            <th>Usuário</th>

                        </tr>

                    </thead>

                    <tbody class=""text-justify"">

");
#nullable restore
#line 88 "E:\Killar\Views\Posts\PostList.cshtml"
                         for (int i = (currentPage - 1) * postsNumberPerPage; i < (postsNumberPerPage *
                       currentPage < Model.Count ? postsNumberPerPage * currentPage : Model.Count); i++)
                        {
                            var stringLength = @Model[i].Content.Length;
                            var indexOf = @Model[i].Content.IndexOf("");
                            var subIndex = @Model[i].Content.Substring(indexOf, stringLength / 5);

                            if (stringLength >= 150)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 100 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 101 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 102 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].PostDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 103 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(subIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"text-align: center;\"><a");
                BeginWriteAttribute("href", " href=\"", 3885, "\"", 3926, 2);
                WriteAttributeValue("", 3892, "/Users/UserList?q=", 3892, 18, true);
#nullable restore
#line 104 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 3910, Model[i].Author, 3910, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 104 "E:\Killar\Views\Posts\PostList.cshtml"
                                                                                                            Write(Model[i].UsersId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\r\n                                    <td><a class=\"btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 4039, "\"", 4077, 2);
                WriteAttributeValue("", 4046, "/Posts/PostEdit?id=", 4046, 19, true);
#nullable restore
#line 106 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 4065, Model[i].Id, 4065, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i
                                    class=""fa-solid fa-file-pen""></i></a></td>

                                    <td><button class=""btn btn-sm btn-outline-primary"" type=""button"" data-toggle=""modal""
                                data-target=""#exampleModalCenter-");
#nullable restore
#line 110 "E:\Killar\Views\Posts\PostList.cshtml"
                                                            Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><i\r\n                                    class=\"fa-solid fa-trash-can\"></i></button></td>\r\n\r\n                                </tr>\r\n");
                WriteLiteral("                                <!--Start PostDelete Modal-->\r\n");
                WriteLiteral("                                <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 4619, "\"", 4655, 2);
                WriteAttributeValue("", 4624, "exampleModalCenter-", 4624, 19, true);
#nullable restore
#line 117 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 4643, Model[i].Id, 4643, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog""
                        aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">

                                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">

                                        <div class=""modal-content"">

                                            <div class=""modal-header"">

                                                <h1 class=""modal-title text-danger text-center bold"" id=""exampleModalLongTitle"">
                                                    Alerta!</h1>

                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                                                    <span aria-hidden=""true"">&times;</span>

                                                </button>

                                            </div>

                                            <div class=""modal-body"">

                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5faca91d7dab2a16dc195d5cc4077fda60313dec25039", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 139 "E:\Killar\Views\Posts\PostList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model[i];

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                            </div>

                                            <div class=""modal-footer"">

                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                                            </div>

                                        </div>

                                    </div>

                                </div>
");
                WriteLiteral("                                <!--Finish PostDelete Modal-->\r\n");
#nullable restore
#line 156 "E:\Killar\Views\Posts\PostList.cshtml"

                            }
                            else
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 163 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 164 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 165 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].PostDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 166 "E:\Killar\Views\Posts\PostList.cshtml"
                                   Write(Model[i].Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"text-align: center;\"><a");
                BeginWriteAttribute("href", " href=\"", 6712, "\"", 6753, 2);
                WriteAttributeValue("", 6719, "/Users/UserList?q=", 6719, 18, true);
#nullable restore
#line 167 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 6737, Model[i].Author, 6737, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 167 "E:\Killar\Views\Posts\PostList.cshtml"
                                                                                                            Write(Model[i].UsersId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\r\n                                    <td><a class=\"btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 6866, "\"", 6904, 2);
                WriteAttributeValue("", 6873, "/Posts/PostEdit?id=", 6873, 19, true);
#nullable restore
#line 169 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 6892, Model[i].Id, 6892, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i
                                    class=""fa-solid fa-file-pen""></i></a></td>

                                    <td><button class=""btn btn-sm btn-outline-primary"" type=""button"" data-toggle=""modal""
                                data-target=""#exampleModalCenter-");
#nullable restore
#line 173 "E:\Killar\Views\Posts\PostList.cshtml"
                                                            Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><i\r\n                                    class=\"fa-solid fa-trash-can\"></i></button></td>\r\n\r\n                                </tr>\r\n");
                WriteLiteral("                                <!--Start PostDelete Modal-->\r\n");
                WriteLiteral("                                <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 7446, "\"", 7482, 2);
                WriteAttributeValue("", 7451, "exampleModalCenter-", 7451, 19, true);
#nullable restore
#line 180 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 7470, Model[i].Id, 7470, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog""
                        aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">

                                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">

                                        <div class=""modal-content"">

                                            <div class=""modal-header"">

                                                <h1 class=""modal-title text-danger text-center bold"" id=""exampleModalLongTitle"">
                                                    Alerta!</h1>

                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                                                    <span aria-hidden=""true"">&times;</span>

                                                </button>

                                            </div>

                                            <div class=""modal-body"">

                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5faca91d7dab2a16dc195d5cc4077fda60313dec32187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 202 "E:\Killar\Views\Posts\PostList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model[i];

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                            </div>

                                            <div class=""modal-footer"">

                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                                            </div>

                                        </div>

                                    </div>

                                </div>
");
                WriteLiteral("                                <!--Finish PostDelete Modal-->\r\n");
#nullable restore
#line 219 "E:\Killar\Views\Posts\PostList.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n");
                WriteLiteral("                <div class=\"filterButton-container\">\r\n\r\n                    <p>Páginas : </p>\r\n\r\n");
#nullable restore
#line 232 "E:\Killar\Views\Posts\PostList.cshtml"
                     for (int i = 1; i <= pagesTotalNumber; i++)
                    { // paginação cria os links para as páginas

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 9496, "\"", 9533, 2);
                WriteAttributeValue("", 9503, "/Posts/PostList?currentPage=", 9503, 28, true);
#nullable restore
#line 234 "E:\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 9531, i, 9531, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 234 "E:\Killar\Views\Posts\PostList.cshtml"
                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 235 "E:\Killar\Views\Posts\PostList.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 239 "E:\Killar\Views\Posts\PostList.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <strong class=\"text-center\">Nenhum registro encontrado</strong>\r\n");
#nullable restore
#line 244 "E:\Killar\Views\Posts\PostList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"mt-3\"\">\r\n                <!-- Retirar estilo in-line -->\r\n\r\n                <a class=\"btn btn-md btn-primary\" href=\"/Users/RegisterUser\">Cadastrar um novo usuario</a>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Posts>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
