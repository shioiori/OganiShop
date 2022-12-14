#pragma checksum "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c70e567360b4bcd513402f53bbdca52ef473dd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ListOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ListOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c70e567360b4bcd513402f53bbdca52ef473dd9", @"/Areas/Admin/Views/Home/ListOrder.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_ListOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);

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
        <li><a href=""#"">Đơn hàng</a></li>
        <li class=""active"">Danh sách đơn hàng</li>
    </ol>
</section>


<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Danh sách đơn hàng</h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <table id=""example2"" class=""table table-bordered table-hover"">
                <thead>
                <tr>
                    <th>STT</th>
                    <th>Tình trạng</th>
                    <th>Tổng tiền</th>
                    <th>Người mua</th>
                    <th>Ngày mua</th>
                    <th>Thao tác</th>
                </tr>
                </thead>
              ");
            WriteLiteral("  <tbody>\r\n");
#nullable restore
#line 44 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                      
                        foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr role=\"row\" class=\"odd\">\r\n                                <td class=\"sorting_1\">");
#nullable restore
#line 47 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                 Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 49 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                      
                                        switch (item.OrderStatus)
                                        {
                                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Pending</span>\r\n");
#nullable restore
#line 54 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                break;
                                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Processing</span>\r\n");
#nullable restore
#line 57 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                break;
                                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-success\">Shipped</span>\r\n");
#nullable restore
#line 60 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                break;
                                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-danger\">Delivered</span>\r\n");
#nullable restore
#line 63 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                break;
                                            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Pending</span>\r\n");
#nullable restore
#line 66 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 70 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                               Write(item.TotalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                <td>\r\n");
#nullable restore
#line 72 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                      
                                        if (item.Account == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:\t#bfc4c4\">Ẩn danh</span>\r\n");
#nullable restore
#line 75 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                        }
                                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 77 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                             Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 78 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 81 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                               Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3612, "\"", 3668, 2);
            WriteAttributeValue("", 3619, "/Admin/ShopOrder/OrderDetail?id=", 3619, 32, true);
#nullable restore
#line 83 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
WriteAttributeValue("", 3651, item.ShopOrderId, 3651, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-info\" style=\"color: white\">Chi tiết</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3776, "\"", 3827, 2);
            WriteAttributeValue("", 3783, "/Admin/ShopOrder/Delete?id=", 3783, 27, true);
#nullable restore
#line 84 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
WriteAttributeValue("", 3810, item.ShopOrderId, 3810, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-danger\" style=\"color: white\">Xóa</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 87 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                            stt++;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"box-footer clearfix\">\r\n                <ul class=\"pagination pagination-sm no-margin pull-right\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4275, "\"", 4345, 2);
            WriteAttributeValue("", 4282, "/Admin/ShopOrder/ListOrder?pageNumber=", 4282, 38, true);
#nullable restore
#line 95 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
WriteAttributeValue("", 4320, Math.Max(pageNumber-1,1), 4320, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a></li>\r\n");
#nullable restore
#line 96 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                     for (int i = 1; i <= pageCount; ++i)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4477, "\"", 4524, 2);
            WriteAttributeValue("", 4484, "/Admin/ShopOrder/ListOrder?pageNumber=", 4484, 38, true);
#nullable restore
#line 98 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
WriteAttributeValue("", 4522, i, 4522, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 99 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4588, "\"", 4666, 2);
            WriteAttributeValue("", 4595, "/Admin/ShopOrder/ListOrder?pageNumber=", 4595, 38, true);
#nullable restore
#line 100 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\Home\ListOrder.cshtml"
WriteAttributeValue("", 4633, Math.Min(pageNumber+1,pageCount), 4633, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a></li>\r\n                </ul>\r\n            </div>\r\n            <!-- /.box-body -->\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n        </div>\r\n    <!-- /.row -->\r\n</section>");
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
