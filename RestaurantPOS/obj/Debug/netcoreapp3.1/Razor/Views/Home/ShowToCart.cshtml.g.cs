#pragma checksum "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4990449a953b42a2c2cf3920a2ccdfa1d56fe59b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowToCart), @"mvc.1.0.view", @"/Views/Home/ShowToCart.cshtml")]
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
#line 1 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\_ViewImports.cshtml"
using RestaurantPOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\_ViewImports.cshtml"
using RestaurantPOS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4990449a953b42a2c2cf3920a2ccdfa1d56fe59b", @"/Views/Home/ShowToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd24f2504c31cab6a2e66182c9f9a4a93fc420e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
  
    ViewData["Title"] = "ShowToCart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string[] CartHeader = new string[] {"STT","Tên món ăn","Hình ảnh", "Giá (VNĐ)","Số Lượng","Tổng(VNĐ)" };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- ASIDE -->
            <!-- store products -->
            <div>
                <h2>Giỏ hàng</h2>
                <table class=""table table-striped table-bordered"">
                    <thead class=""thead-dark"">
                        <tr>
");
#nullable restore
#line 20 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                              
                                foreach (var head in CartHeader)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th style=\"text-align:center\">\n                                        ");
#nullable restore
#line 24 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </th>\n");
#nullable restore
#line 26 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 31 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                          
                            int i = 1;
                            if (Model.ListFood!=null)
                            {
                                int count = 0;
                                foreach (var Data in Model.ListFood)
                                {
                                    count += Data.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td style=\"text-align:center\">");
#nullable restore
#line 40 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                                                  Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"text-align:center\">");
#nullable restore
#line 41 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                                                 Write(Data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td><center><img");
            BeginWriteAttribute("src", " src=\"", 1656, "\"", 1676, 1);
#nullable restore
#line 42 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 1662, Data.ImageURL, 1662, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1677, "\"", 1683, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"40\" width=\"60\"></center></td>\n                                        <td style=\"text-align:center\">");
#nullable restore
#line 43 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                                                 Write(Data.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"text-align:center\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4990449a953b42a2c2cf3920a2ccdfa1d56fe59b9320", async() => {
                WriteLiteral("\n                                                <span><input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2070, "\"", 2086, 1);
#nullable restore
#line 46 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 2078, Data.Id, 2078, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"cartdetailvm.Id\" /></span>\n                                                <span><input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2195, "\"", 2215, 1);
#nullable restore
#line 47 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 2203, Data.FoodId, 2203, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"cartdetailvm.FoodId\" /></span>\n                                                <span><input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2328, "\"", 2351, 1);
#nullable restore
#line 48 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 2336, Data.UnitPrice, 2336, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""cartdetailvm.UnitPrice"" /></span>
                                                <span><input style=""background-color:red; border-radius: 50%;width:25px;height:25px"" type=""submit"" value=""-"" name=""cartdetailvm.Type"" /></span>
                                                <span><input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2657, "\"", 2679, 1);
#nullable restore
#line 50 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 2665, Data.Quantity, 2665, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""cartdetailvm.Quantity"" size=""3"" readonly style=""text-align:center"" /></span>
                                                <span><input style=""background-color:red;border-radius: 50%;width:25px;height:25px"" type=""submit"" value=""+"" name=""cartdetailvm.Type"" /></span>
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
            WriteLiteral("\n                                        </td>\n                                        <td style=\"text-align:center\">");
#nullable restore
#line 54 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                                                 Write(Data.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 56 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr><td colspan=\"6\" class=\"text-right\">Tổng thanh toán:");
#nullable restore
#line 57 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                                                                                  Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (VND)</td></tr>\n                                <tr>\n                                    <td colspan=\"6\" class=\"text-center\" style=\"background-color:aquamarine\">\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3514, "\"", 3550, 1);
#nullable restore
#line 60 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
WriteAttributeValue("", 3521, Url.Action("Payment","Home"), 3521, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>Thanh Toán</span></a>\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 63 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr><td colspan=\"8\" class=\"text-center\">Giỏ hàng trống!</td></tr>\n");
#nullable restore
#line 67 "E:\EDUCATION\Bach Khoa University\HK212\Software engineering\Assignment reference\RestaurantPOS-main\RestaurantPOS-main\RestaurantPOS\Views\Home\ShowToCart.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n        <!-- /STORE -->\n        <!-- /row -->\n    </div>\n    <!-- /container -->\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591