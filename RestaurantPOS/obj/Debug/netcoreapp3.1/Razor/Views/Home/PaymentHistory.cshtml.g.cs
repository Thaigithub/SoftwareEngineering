#pragma checksum "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cff98b3ee51008049ae4d195d7b7732ac6fd776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PaymentHistory), @"mvc.1.0.view", @"/Views/Home/PaymentHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cff98b3ee51008049ae4d195d7b7732ac6fd776", @"/Views/Home/PaymentHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd24f2504c31cab6a2e66182c9f9a4a93fc420e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PaymentHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PaymentHistoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
  
    ViewData["Title"] = "PaymentHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string[] PaymentHeader = new string[] { "STT", "Chi ti???t", "T???ng (VN??)", "Ph????ng th???c thanh to??n", "Ng??y thanh to??n" };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- ASIDE -->
            <!-- store products -->
            <div>
                <h2>L???ch s??? thanh to??n</h2>
                <table class=""table table-bordered table-striped table-hover"">
                    <thead class=""thead-dark"">
                        <tr>
");
#nullable restore
#line 21 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                              
                                foreach (var head in PaymentHeader)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th class=\"text-center\">\n                                        ");
#nullable restore
#line 25 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </th>\n");
#nullable restore
#line 27 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 32 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                          
                            int i = 1;
                            if (Model.Count > 0)
                                foreach (var Data in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td class=\"text-center\">");
#nullable restore
#line 38 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                                            Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"text-center\">\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1594, 1);
#nullable restore
#line 40 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
WriteAttributeValue("", 1533, Url.Action("PaymentDetailHistory","Home",new { id=Data.Id }), 1533, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi ti???t: </a>\n                                        </td>\n                                        <td class=\"text-center\">");
#nullable restore
#line 42 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                                            Write(Data.Total * 11 / 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"text-center\">");
#nullable restore
#line 43 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                                           Write(Data.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"text-center\">");
#nullable restore
#line 44 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                                           Write(Data.CreatedDate.ToLocalTime().ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 46 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                                }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td colspan=\"5\" class=\"text-center\">B???n ch??a thanh to??n l???n n??o!!</td>\n                                </tr>\n");
#nullable restore
#line 52 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\SoftwareEngineering\RestaurantPOS\Views\Home\PaymentHistory.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n        <!-- /STORE -->\n        <!-- /row -->\n    </div>\n    <!-- /container -->\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PaymentHistoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
