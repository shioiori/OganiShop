#pragma checksum "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3efe47a06ddb7ec16484a222b1258ad74e7850e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ListProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ListProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3efe47a06ddb7ec16484a222b1258ad74e7850e", @"/Areas/Admin/Views/Product/ListProduct.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);
    string name = ViewBag.name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
<h1>
    &nbsp;
</h1>
<ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li><a href=""#"">Sản phẩm</a></li>
    <li class=""active"">Danh sách sản phẩm</li>
</ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                <h3 class=""box-title"">Danh sách sản phẩm</h3>

                <div class=""box-tools"">
                    <div class=""input-group input-group-sm"" style=""width: 150px;"">
                        <input type=""text"" name=""name"" class=""form-control pull-right"" action=""/Admin/Product/ListProduct"" method=""get"" id=""formSearch"" placeholder=""Search"">
                        <div class=""input-group-btn"">
                            <button type=""submit"" class=""btn btn-default""><i class=""fa fa-search""></i></button>
                        </div>
                   ");
            WriteLiteral(@"     <input type=""number"" name=""pageNumber"" id=""txtPageNumber"" value=""1"" hidden/>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                               <th>STT</th>
                               <th>Tên sản phẩm</th>
                               <th>Giá bán</th>
                               <th>Giá gốc</th>
                               <th>Số lượng</th>
                               <th>Trọng lượng</th>
                               <th>Ảnh đại diện</th>
                               <th>Thao tác</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 56 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                              
                                foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <tr>\r\n                                        <td>");
#nullable restore
#line 60 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 63 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 64 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 65 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                                    Write(item.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 2824, "\"", 2842, 1);
#nullable restore
#line 66 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 2830, item.Avatar, 2830, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:128px\"></td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2963, "\"", 3005, 2);
            WriteAttributeValue("", 2970, "/Admin/Product/AddImage?id=", 2970, 27, true);
#nullable restore
#line 68 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 2997, item.Id, 2997, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-info\" style=\"color: white\">Thêm ảnh</a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3121, "\"", 3166, 2);
            WriteAttributeValue("", 3128, "/Admin/Product/AddOrUpdate?id=", 3128, 30, true);
#nullable restore
#line 69 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3158, item.Id, 3158, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-warning\" style=\"color: white\">Sửa</a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3280, "\"", 3320, 2);
            WriteAttributeValue("", 3287, "/Admin/Product/Delete?id=", 3287, 25, true);
#nullable restore
#line 70 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3312, item.Id, 3312, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-danger\" style=\"color: white\">Xóa</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 73 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                    stt++;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer clearfix"">
                    <ul class=""pagination pagination-sm no-margin pull-right"">
                        <li><a href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 3882, "\"", 3927, 2);
            WriteAttributeValue("", 3892, "clickPage(", 3892, 10, true);
#nullable restore
#line 82 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3902, Math.Max(pageNumber-1,1), 3902, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a></li>\r\n");
#nullable restore
#line 83 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                         for (int i = 1; i <= pageCount; ++i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4080, "\"", 4103, 3);
            WriteAttributeValue("", 4090, "clickPage(", 4090, 10, true);
#nullable restore
#line 85 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4100, i, 4100, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4102, ")", 4102, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 86 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4184, "\"", 4237, 2);
            WriteAttributeValue("", 4194, "clickPage(", 4194, 10, true);
#nullable restore
#line 87 "F:\AppManager\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4204, Math.Min(pageNumber+1,pageCount), 4204, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        <!-- /.box -->\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function clickPage(pageNumber){\r\n            document.getElementById(\"txtPageNumber\").value = pageNumber;\r\n            document.getElementById(\"formSearch\").submit();\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
