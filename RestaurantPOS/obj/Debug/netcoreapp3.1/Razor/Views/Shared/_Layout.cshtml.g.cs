#pragma checksum "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\_ViewImports.cshtml"
using RestaurantPOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\_ViewImports.cshtml"
using RestaurantPOS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
using RestaurantPOS.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8abbbb3712ee42d126f0b6d104fcb8e8eccae14e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd24f2504c31cab6a2e66182c9f9a4a93fc420e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e5564", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 10 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - RestaurantPOS</title>
    <link rel=""stylesheet"" type=""text/css"" href=""/css/site.css"" />
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,500,700"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    ");
#nullable restore
#line 15 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
Write(RenderSection("CustomCss", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e7645", async() => {
                WriteLiteral(@"
    <!-- HEADER -->
    <header>
        <!-- TOP HEADER -->
        <div id=""top-header"">
            <div class=""container"">
                <ul class=""header-links pull-left"">
                    <li><a href=""#""><i class=""fa fa-phone""></i>028 38647256</a></li>
                    <li><a href=""#""><i class=""far fa-envelope""></i>RestaurantPOS@hcmut.edu.vn</a></li>
                    <li><a href=""#""><i class=""fa fa-map-marker""></i>268 Lý Thường Kiệt, Phường 14, Quận 10, Thành phố Hồ Chí Minh</a></li>
                </ul>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e8463", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        <!-- /TOP HEADER -->
        <!-- MAIN HEADER -->
        <div id=""header"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <!-- LOGO -->
                    <div class=""col-md-3"">
                        <div class=""header-logo"">
                            <a href=""#"" class=""logo"">
                                <img src=""/images/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1869, "\"", 1875, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </a>
                        </div>
                    </div>
                    <!-- /LOGO -->
                    <!-- SEARCH BAR -->
                    <div class=""col-md-6"">
                        <div class=""header-search"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e10587", async() => {
                    WriteLiteral("\n                                <input class=\"input-select\" placeholder=\"Tìm kiếm tại đây\">\n                                <button class=\"search-btn\">Tìm kiếm</button>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                    <!-- /SEARCH BAR -->
                    <!-- ACCOUNT -->
                    <div class=""col-md-3 clearfix"">
                        <div class=""header-ctn"">
                            <!-- Cart -->
                            <div>
                                <a");
                BeginWriteAttribute("href", " href=\"", 2726, "\"", 2765, 1);
#nullable restore
#line 62 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2733, Url.Action("ShowToCart","Home"), 2733, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fa fa-shopping-cart""></i>
                                    <span>Giỏ hàng</span>
                                </a>
                            </div>
                            <!-- /Cart -->
                        </div>
                    </div>
                    <!-- /ACCOUNT -->
                </div>
                <!-- row -->
            </div>
            <!-- container -->
        </div>
        <!-- /MAIN HEADER -->
    </header>
    <!-- /HEADER -->
    <!-- NAVIGATION -->
    <nav id=""navigation"">
        <!-- container -->
        <div class=""container"">
            <!-- responsive-nav -->
            <div id=""responsive-nav"">
                <!-- NAV -->
                <ul class=""main-nav nav navbar-nav"">
                    <li><a");
                BeginWriteAttribute("href", " href=\"", 3582, "\"", 3668, 5);
#nullable restore
#line 87 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3589, Url.Action("Index","Home"), 3589, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3616, ">Trang", 3616, 6, true);
                WriteAttributeValue(" ", 3622, "chủ</a></li>", 3623, 13, true);
                WriteAttributeValue("\n                    ", 3635, "<li><a", 3656, 27, true);
                WriteAttributeValue(" ", 3662, "href=", 3663, 6, true);
                EndWriteAttribute();
#nullable restore
#line 88 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("MenuFood","Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Menu</a></li>\n                    <li><a href=\"");
#nullable restore
#line 89 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("Payment", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Thanh toán</a></li>\n                    <li><a href=\"");
#nullable restore
#line 90 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("BookTable","Reservation"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Đặt bàn</a></li>\n                    <li><a href=\"");
#nullable restore
#line 91 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("TableOrderedHistory", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Lịch sử đặt bàn</a></li>\n                    <li><a href=\"");
#nullable restore
#line 92 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("PaymentHistory", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">Lịch sử thanh toán</a></li>
                </ul>
                <!-- /NAV -->
            </div>
            <!-- /responsive-nav -->
        </div>
        <!-- /container -->
    </nav>
    <!-- /NAVIGATION -->
    <!--BODY-->
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 104 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>
    <!--/BODY-->
    <!-- FOOTER -->
    <footer id=""footer"">
        <!-- top footer -->
        <div class=""section"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-5 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Mọi thắc mắc vui lòng liên hệ</h3>
                            <ul class=""footer-links"">
                                <li><i class=""fa fa-phone""></i>028 38647256</li>
                                <li><i class=""far fa-envelope""></i>RestaurantPOS@hcmut.edu.vn</li>
                                <li><i class=""fa fa-map-marker""></i>268 Lý Thường Kiệt, Phường 14, Quận 10, Thành phố Hồ Chí Minh</li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
  ");
                WriteLiteral(@"                          <h3 class=""footer-title"">Các kiểu thức ăn</h3>
                            <ul class=""footer-links"">
                                <li>Món khai vị</li>
                                <li>Món ăn chính</li>
                                <li>Món tráng miệng</li>
                                <li>Các loại thức uống </li>
                            </ul>
                        </div>
                    </div>

                    <div class=""clearfix visible-xs""></div>
                    <div class=""col-md-4 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Các loại dịch vụ</h3>
                            <ul class=""footer-links"">
                                <li>Thanh toán online, tiết kiệm thời gian</li>
                                <li>Đặt món online, thỏa sức lựa chọn</li>
                                <li>Tri ân khách hàng thành viên</li>
                                <li>Đặt bàn trước mà không cần tới n");
                WriteLiteral(@"ơi</li>
                                <li>Hỗ trợ giải đáp mọi thắc mắc</li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /top footer -->
    </footer>
    <!-- /FOOTER -->
    <script src=""~/lib/jquery/dist/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e19376", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js\"></script>\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abbbb3712ee42d126f0b6d104fcb8e8eccae14e20669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 164 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
#nullable restore
#line 165 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Customer> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Customer> SignInManager { get; private set; }
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
