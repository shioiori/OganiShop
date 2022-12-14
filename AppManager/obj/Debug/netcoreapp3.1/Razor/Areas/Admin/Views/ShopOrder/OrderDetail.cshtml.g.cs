#pragma checksum "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a814a0ed086e90e30a4eef0f32ca7171d5e01341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ShopOrder_OrderDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/ShopOrder/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a814a0ed086e90e30a4eef0f32ca7171d5e01341", @"/Areas/Admin/Views/ShopOrder/OrderDetail.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ShopOrder_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        &nbsp;
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Danh sách đơn hàng</a></li>
        <li class=""active"">Chi tiết đơn hàng</li>
    </ol>
</section>
        <!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-4"">
            <div class=""box box-primary"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Thông tin đơn hàng</h3>
                </div>
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                        <tr>
                            <th>Mã đơn hàng</th>
                            <td>");
#nullable restore
#line 29 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                           Write(Model.ShopOrder.ShopOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                            <tr>\r\n                            <th>Tình trạng</th>\r\n                            <td>\r\n");
#nullable restore
#line 34 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                  
                                    switch (Model.ShopOrder.OrderStatus)
                                    {
                                        case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-warning\">Pending</span>\r\n");
#nullable restore
#line 39 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                            break;
                                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-warning\">Processing</span>\r\n");
#nullable restore
#line 42 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                            break;
                                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-success\">Shipped</span>\r\n");
#nullable restore
#line 45 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                            break;
                                        case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-danger\">Delivered</span>\r\n");
#nullable restore
#line 48 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                            break;
                                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-warning\">Pending</span>\r\n");
#nullable restore
#line 51 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                            break;
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>Người mua</th>\r\n                            <td>\r\n");
#nullable restore
#line 59 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                  
                                    if (Model.ShopOrder.Account == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span style=\"color:#bfc4c4\">Ẩn danh</span>\r\n");
#nullable restore
#line 62 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                    }
                                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>");
#nullable restore
#line 64 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                         Write(Model.ShopOrder.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 65 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>Ngày mua hàng</th>\r\n                            <td>");
#nullable restore
#line 71 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                           Write(Model.ShopOrder.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        </tr>
                    </table>
                </div>
                <div class=""box-footer"">
                    <a href=""/Admin/ShopOrder/ListOrder""><button type=""submit"" class=""btn btn-default"">Cancel</button></a>
                    <a");
            BeginWriteAttribute("href", " href=\"", 3454, "\"", 3516, 2);
            WriteAttributeValue("", 3461, "/Admin/ShopOrder/Delete?id=", 3461, 27, true);
#nullable restore
#line 77 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
WriteAttributeValue("", 3488, Model.ShopOrder.ShopOrderId, 3488, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><button type=""submit"" class=""btn btn-info pull-right"">Xoá</button></a>
                </div>
            </div>
        </div>
        <div class=""col-xs-8"">
            <div class=""box box-primary"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Chi tiết đơn hàng</h3>
                    <div class=""box-tools"">
                        <div class=""input-group input-group-sm"" style=""width: 150px;"">
                            <input type=""text"" name=""table_search"" class=""form-control pull-right"" placeholder=""Search"">
                            <div class=""input-group-btn"">
                                <button type=""submit"" class=""btn btn-default""><i class=""fa fa-search""></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body table-responsive no-padding"">
                <table class=""table table-hover"">");
            WriteLiteral(@"
                    <tbody>
                        <tr>
                            <th>STT</th>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng mua</th>
                            <th>Giá tiền</th>
                            <th>Thành tiền</th>
                        </tr>
");
#nullable restore
#line 105 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                          
                            var stt = 1;
                            foreach(var item in Model.ListOrderDetail)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 110 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 111 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 112 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 113 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                   Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                    <td>");
#nullable restore
#line 114 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                                   Write(item.TotalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                </tr>\r\n");
#nullable restore
#line 116 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                            }
                            stt++;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <th>&nbsp;</th>\r\n                        <th>Tổng tiền</th>\r\n                        <th>&nbsp;</th>\r\n                        <th>&nbsp;</th>\r\n                        <th>");
#nullable restore
#line 125 "F:\Backend Devmaster\AppManager\AppManager\Areas\Admin\Views\ShopOrder\OrderDetail.cshtml"
                       Write(Model.ShopOrder.TotalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</th>\r\n                    </tfoot>\r\n                </table>\r\n                </div>\r\n                <!-- /.box-body -->\r\n                </div>\r\n            </div>\r\n        <!-- /.box -->\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
