#pragma checksum "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e094ad297958505085c37ad8b2ae7e632ed77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e094ad297958505085c37ad8b2ae7e632ed77c", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed27a90769d57c4cf1e99ddf07e56b08d479e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.Response.MovieDetailsResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-pill badge-dark ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Genre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-lg btn-block btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bg-image\"");
            BeginWriteAttribute("style", " style=\"", 118, "\"", 167, 4);
            WriteAttributeValue("", 126, "background-image:", 126, 17, true);
            WriteAttributeValue(" ", 143, "url(", 144, 5, true);
#nullable restore
#line 4 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 148, Model.BackdropUrl, 148, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 166, ")", 166, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 offset-2\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 276, "\"", 298, 1);
#nullable restore
#line 9 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 282, Model.PosterUrl, 282, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"row mt-2\">\r\n                <div class=\"col-12\">\r\n                    <h1 class=\"text-white\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h1>\r\n                    <small class=\"text-muted\"> ");
#nullable restore
#line 19 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                          Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-4 text-secondary font-weight-bold mt-2\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m | ");
#nullable restore
#line 26 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                  Write(Model.ReleaseDate.Value.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                     foreach (var genre in Model.Genres)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e094ad297958505085c37ad8b2ae7e632ed77c7956", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                       Write(genre.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                                                                         WriteLiteral(genre.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-4 mt-3\">\r\n                    <h4>\r\n                        <span class=\"badge badge-warning\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                       Write(Model.Rating?.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </h4>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-12 text-light mt-2\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""col-md-2 mt-4 offset-1"">
            <ul class=""list-group"">
                <li class=""list-group-item"">


                </li>
                <li class=""list-group-item"">
                    <button type=""button""
                            class=""btn btn-outline-light btn-lg btn-block btn-sm"">
                        <i class=""far fa-edit mr-1""></i>
                        REVIEW
                    </button>
                </li>
                <li class=""list-group-item"">
                    <button type=""button""
                            class=""btn btn-outline-light btn-lg btn-block btn-sm"">
                        <i class=""fas fa-play mr-1""></i> TRAILER
                    </button>
                </li>

                <li class=""list-group-item"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e094ad297958505085c37ad8b2ae7e632ed77c12637", async() => {
                WriteLiteral("\r\n                        BUY ");
#nullable restore
#line 78 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e094ad297958505085c37ad8b2ae7e632ed77c15421", async() => {
                WriteLiteral("\r\n                        WATCH MOVIE\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
            </ul>
        </div>

    </div>
</div>


<div class=""row mt-4"">
    <div class=""col-4 moviefacts"">
        <h5>MOVIE FACTS</h5>
        <hr>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">
                <i class=""far fa-calendar-alt mr-2""></i>Release Date
                <span class=""badge badge-pill badge-dark"">");
#nullable restore
#line 99 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                                     Write(Model.ReleaseDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n\r\n            <li class=\"list-group-item\">\r\n                <i class=\"fas fa-hourglass-half mr-2\"></i>Run Time\r\n                <span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 104 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                                                     Write(Model.RunTime.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span>\r\n            </li>\r\n            <li class=\"list-group-item\">\r\n                <i class=\"far fa-money-bill-alt\"></i> Box Office\r\n                <span class=\"badge badge-pill badge-pill badge-dark\">\r\n                    ");
#nullable restore
#line 109 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(NumberFormatInfo.CurrentInfo.CurrencySymbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 110 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(Model.Revenue?.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </li>\r\n\r\n            <li class=\"list-group-item\">\r\n                <i class=\"fas fa-dollar-sign mr-2\"></i> Budget\r\n                <span class=\"badge badge-pill badge-dark\">\r\n                    ");
#nullable restore
#line 117 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(NumberFormatInfo.CurrentInfo.CurrencySymbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 118 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
               Write(Model.Budget?.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </li>\r\n\r\n            <li class=\"list-group-item\">\r\n                <i class=\"fab fa-imdb\"></i>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4493, "\"", 4514, 1);
#nullable restore
#line 125 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 4500, Model.ImdbUrl, 4500, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""text-dark ml-3""
                   target=""_blank"">
                    <i class=""fas fa-share-square mr-2""></i>
                </a>
            </li>

        </ul>
    </div>

    <div class=""col-4 offset-1"">
        <h5>CAST</h5>

        <table class=""table"">
            <tbody>

");
#nullable restore
#line 141 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                 foreach (var cast in Model?.Casts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5004, "\"", 5027, 1);
#nullable restore
#line 145 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 5010, cast.ProfilePath, 5010, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 class=\"cast-small-img rounded-circle\"");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 5100, "\"", 5150, 1);
#nullable restore
#line 147 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 5140, cast.Name, 5140, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td> ");
#nullable restore
#line 149 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                        Write(cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 150 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                        Write(cast.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 152 "C:\Users\cream\Desktop\SQL\MovieShop\MovieShop.MVC\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.Response.MovieDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
