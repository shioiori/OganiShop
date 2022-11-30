#pragma checksum "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e09963216f9b1d391e4c20a421ebadaec9a63d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_AddOrUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/AddOrUpdate.cshtml")]
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
#line 1 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
using AppManager.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09963216f9b1d391e4c20a421ebadaec9a63d0d", @"/Areas/Admin/Views/Product/AddOrUpdate.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_AddOrUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    string error = TempData["error"] as string;
    List<CategoryModel> listCategory = ViewBag.Category;

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
        <li class=""active"">Quản lý sản phẩm</li>
    </ol>
</section>

<section class=""content"">
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Quản lý sản phẩm</h3>
        </div>
        <!-- /.box-header -->
        <form class=""form-horizontal"" action=""/admin/product/addorupdate"" method=""post"" style=""overflow: hidden"">
            <div class=""box-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <input type=""number"" name=""id""");
            BeginWriteAttribute("value", " value=\"", 1087, "\"", 1126, 1);
#nullable restore
#line 31 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 1095, Model.Id == 0 ? 0 : Model.Id, 1095, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden>
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Sản phẩm</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 1384, "\"", 1426, 1);
#nullable restore
#line 34 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 1392, Model.Id == 0 ? "" : Model.Name, 1392, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Giá bán</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""price""");
            BeginWriteAttribute("value", " value=\"", 1795, "\"", 1838, 1);
#nullable restore
#line 40 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 1803, Model.Id == 0 ? "" : Model.Price, 1803, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Giá gốc</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""oldprice""");
            BeginWriteAttribute("value", " value=\"", 2210, "\"", 2256, 1);
#nullable restore
#line 46 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 2218, Model.Id == 0 ? "" : Model.OldPrice, 2218, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Số lượng</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 2629, "\"", 2675, 1);
#nullable restore
#line 52 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 2637, Model.Id == 0 ? "" : Model.Quantity, 2637, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Trọng lượng</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""weight""");
            BeginWriteAttribute("value", " value=\"", 3049, "\"", 3093, 1);
#nullable restore
#line 58 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 3057, Model.Id == 0 ? "" : Model.Weight, 3057, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Đơn vị đo</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""unit""");
            BeginWriteAttribute("value", " value=\"", 3463, "\"", 3505, 1);
#nullable restore
#line 64 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 3471, Model.Id == 0 ? "" : Model.Unit, 3471, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"" class=""col-md-3 control-label"">Thuộc danh mục</label>
                            <div class=""col-md-9"">
                                <input type=""text"" name=""categoryid"" id=""cate""");
            BeginWriteAttribute("value", " value=\"", 3872, "\"", 3919, 1);
#nullable restore
#line 70 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 3880, Model.Id == 0 ? 0 : Model.CategoryId, 3880, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\r\n                                <select class=\"form-control select2\" id=\"category\" style=\"width: 100%;\">\r\n");
#nullable restore
#line 72 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
                                      
                                        foreach (var item in listCategory)
                                        {
                                            if (Model.CategoryId == item.Id)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("id", " id=\"", 4375, "\"", 4388, 1);
#nullable restore
#line 77 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 4380, item.Id, 4380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 77 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 78 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("id", " id=\"", 4619, "\"", 4632, 1);
#nullable restore
#line 81 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 4624, item.Id, 4624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>                            \r\n");
#nullable restore
#line 82 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Tóm tắt</label>
                            <div class=""col-md-9"">
                                <input type=""text"" class=""form-control"" name=""summary""");
            BeginWriteAttribute("value", " value=\"", 5222, "\"", 5267, 1);
#nullable restore
#line 91 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 5230, Model.Id == 0 ? "" : Model.Summary, 5230, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Mô tả</label>
                            <div class=""col-md-9"">
                                <textarea class=""form-control"" name=""description""");
            BeginWriteAttribute("value", " value=\"", 5631, "\"", 5680, 1);
#nullable restore
#line 97 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 5639, Model.Id == 0 ? "" : Model.Description, 5639, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" rows=""3""></textarea>
                            </div>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"" for=""exampleInputPassword1"">Ảnh đại diện</label>
                            <div class=""col-md-12 text-center"">
                                <img id=""image-upload"" class=""rounded mx-auto d-block"" style=""padding-bottom:1rem""");
            BeginWriteAttribute("src", " src=\"", 6225, "\"", 6283, 1);
#nullable restore
#line 106 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 6231, Model.Id == 0 ? "/img/default.jpg" : Model.Avatar, 6231, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"193px\">\r\n                            </div>\r\n                            <input type=\"text\" name=\"avatar\" id=\"image-file-path\"");
            BeginWriteAttribute("value", " value=\"", 6418, "\"", 6461, 1);
#nullable restore
#line 108 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 6426, Model.Id == 0 ? 0 : Model.Avatar, 6426, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\r\n                            <input type=\"text\" name=\"avatarFileId\" id=\"image-file-id\"");
            BeginWriteAttribute("value", " value=\"", 6557, "\"", 6606, 1);
#nullable restore
#line 109 "F:\AppManager\AppManager\Areas\Admin\Views\Product\AddOrUpdate.cshtml"
WriteAttributeValue("", 6565, Model.Id == 0 ? 0 : Model.AvatarFileId, 6565, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden>
                            <div class=""col-md-12 text-center"">
                                <input type=""file"" id=""image-upload"" name=""fileUpload"">
                            </div>
                        </div>
                        
                    <!-- /.form-group -->
                        
                        
                    <!-- /.form-group -->
                    </div>
                        
                    <!-- /.col -->
                </div>
            <!-- /.row -->
            </div>
            <div class=""box-footer"">
                <button type=""submit"" class=""btn btn-info pull-right "">Lưu thông tin</button>
            </div>
        </form>
        <!-- /.box-body -->
        </div>
</section>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#category').on('change', function(){
            $('#cate').val($(""#category :selected"").attr(""id""));
            console.log($(""#cate"").val());
        });
        $(document).on('change', 'input[name=""fileUpload""]', function() {
            let files = $(this).prop(""files"");
            let formData = new FormData();
            formData.append(""file"", files[0]);
            $.ajax({
                url: ""/admin/product/uploadfile"",
                type: ""POST"",
                data: formData,
                contentType: false,
                processData: false,
                beforeSend: () => {

                },
                success: res => {
                    console.log(res);
                    $('#image-upload').attr('src', res.fileInfo.filePath);
                    $('#image-file-path').val(res.fileInfo.filePath);
                    $('#image-file-id').val(res.fileInfo.id);
                },
                error: error => {
            ");
                WriteLiteral("        console.log(error);\r\n                }\r\n            })\r\n        })\r\n    </script>\r\n");
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
