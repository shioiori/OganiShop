#pragma checksum "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c529224096466f06ba978c882ba5c52ce2cae03b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingGrid_Index), @"mvc.1.0.view", @"/Views/ShoppingGrid/Index.cshtml")]
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
#line 1 "F:\Backend Devmaster\AppManager\AppManager\Views\_ViewImports.cshtml"
using AppManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Backend Devmaster\AppManager\AppManager\Views\_ViewImports.cshtml"
using AppManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c529224096466f06ba978c882ba5c52ce2cae03b", @"/Views/ShoppingGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bdf4e2eeb9182a14600fe5d339bdb2f9540938", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ShoppingGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
  
    ViewData["Title"] = "Shopping Grid";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);
    string name = ViewBag.name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""hero hero-normal"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero__categories"">
                    <div class=""hero__categories__all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    <ul id=""department2"">
                        <li><a href=""#"">Fresh Meat</a></li>
                        <li><a href=""#"">Vegetables</a></li>
                        <li><a href=""#"">Fruit &amp; Nut Gifts</a></li>
                        <li><a href=""#"">Fresh Berries</a></li>
                        <li><a href=""#"">Ocean Foods</a></li>
                        <li><a href=""#"">Butter &amp; Eggs</a></li>
                        <li><a href=""#"">Fastfood</a></li>
                        <li><a href=""#"">Fresh Onion</a></li>
                        <li><a href=""#"">Papayaya &amp; Crisps</a></li>
                        <li><a hr");
            WriteLiteral(@"ef=""#"">Oatmeal</a></li>
                        <li><a href=""#"">Fresh Bananas</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""hero__search"">
                    <div class=""hero__search__form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c529224096466f06ba978c882ba5c52ce2cae03b5868", async() => {
                WriteLiteral(@"
                            <div class=""hero__search__categories"">
                                All Categories
                                <span class=""arrow_carrot-down""></span>
                            </div>
                            <input type=""text"" placeholder=""What do yo u need?"">
                            <button type=""submit"" class=""site-btn"">SEARCH</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""hero__search__phone"">
                        <div class=""hero__search__phone__icon"">
                            <i class=""fa fa-phone""></i>
                        </div>
                        <div class=""hero__search__phone__text"">
                            <h5>+65 11.188.888</h5>
                            <span>support 24/7 time</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Organi Shop</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""/index.html"">Home</a>
                        <span>Shop</span>
");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Product Section Begin -->
<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-5"">
                <div class=""sidebar"">
                    <div class=""sidebar__item"">
                        <h4>Department</h4>
                        <ul id=""department"">
                            <li><a href=""#"">Fresh Meat</a></li>
                            <li><a href=""#"">Vegetables</a></li>
                            <li><a href=""#"">Fruit & Nut Gifts</a></li>
                            <li><a href=""#"">Fresh Berries</a></li>
                            <li><a href=""#"">Ocean Foods</a></li>
                            <li><a href=""#"">Butter & Eggs</a></li>
                            <li><a href=""#"">Fastfood</a></li>
                            <li><a href=""#"">Fresh Onion</a></li>
  ");
            WriteLiteral(@"                          <li><a href=""#"">Papayaya & Crisps</a></li>
                            <li><a href=""#"">Oatmeal</a></li>
                        </ul>
                    </div>
                    <div class=""sidebar__item"">
                        <h4>Price</h4>
                        <div class=""price-range-wrap"">
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content""
                                 data-min=""10"" data-max=""540"">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
                            <div class=""range-slider"">
                                <div class=""price-input"">
              ");
            WriteLiteral(@"                      <input type=""text"" id=""minamount"">
                                    <input type=""text"" id=""maxamount"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""sidebar__item"">
                        <div class=""latest-product__text"">
                            <h4>Latest Products</h4>
                            <div class=""latest-product__slider owl-carousel"" id=""latest-product"">
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 col-md-7"">
                <div class=""product__discount"">
                    <div class=""section-title product__discount__title"">
                        <h2>Sale Off</h2>
                    </div>
                    <div class=""row"">
                        <div class=""product__");
            WriteLiteral("discount__slider owl-carousel\" id=\"product-discount\">\r\n");
#nullable restore
#line 132 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                              
                                foreach (var item in Model.Discount)
                                {
                                    var discount = item.DiscountType == 0 ? ("-" + item.DiscountValue + "$") : ("-" + item.DiscountValue + "%");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-lg-4"">
                                        <div class=""product__discount__item"">
                                            <div class=""product__discount__item__pic set-bg""
                                                 data-setbg=""");
#nullable restore
#line 139 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                        Write(item.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 6796, "\"", 6840, 4);
            WriteAttributeValue("", 6804, "background-image:", 6804, 17, true);
            WriteAttributeValue(" ", 6821, "url(", 6822, 5, true);
#nullable restore
#line 139 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 6826, item.Avatar, 6826, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6838, ");", 6838, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"product__discount__percent\">");
#nullable restore
#line 140 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                                   Write(discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <ul class=\"product__item__pic__hover\"");
            BeginWriteAttribute("id", " id=\"", 7034, "\"", 7047, 1);
#nullable restore
#line 141 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 7039, item.Id, 7039, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                                    <li><a href=""#"" class=""add-to-cart""><i class=""fa fa-shopping-cart""></i></a></li>
                                                </ul>
                                            </div>
                                            <div class=""product__discount__item__text"">
                                                <span>");
#nullable restore
#line 148 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                 Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <h5><a");
            BeginWriteAttribute("href", " href=\"", 7726, "\"", 7767, 2);
            WriteAttributeValue("", 7733, "/ProductDetail/Product?id=", 7733, 26, true);
#nullable restore
#line 149 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 7759, item.Id, 7759, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                                <div class=\"product__item__price\">$");
#nullable restore
#line 150 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                              Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 150 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                                                                  Write(item.OldPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 154 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""filter__item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-5"">
                            <div class=""filter__sort"">
                                <span>Sort By</span>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c529224096466f06ba978c882ba5c52ce2cae03b17720", async() => {
                WriteLiteral("Default");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c529224096466f06ba978c882ba5c52ce2cae03b18917", async() => {
                WriteLiteral("Default");
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
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""filter__found"">
                                <h6><span id=""product-count"">");
#nullable restore
#line 172 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> Products found</h6>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-3"">
                            <div class=""filter__option"">
                                <span class=""icon_grid-2x2""></span>
                                <span class=""icon_ul""></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"" id=""filter-item"">
");
#nullable restore
#line 184 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                      
                        foreach (var item in Model.ListProduct)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                                <div class=\"product__item\">\r\n                                    <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 189 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                                  Write(item.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 9846, "\"", 9890, 4);
            WriteAttributeValue("", 9854, "background-image:", 9854, 17, true);
            WriteAttributeValue(" ", 9871, "url(", 9872, 5, true);
#nullable restore
#line 189 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 9876, item.Avatar, 9876, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9888, ");", 9888, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <ul class=\"product__item__pic__hover\"");
            BeginWriteAttribute("id", " id=\"", 9971, "\"", 9984, 1);
#nullable restore
#line 190 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 9976, item.Id, 9976, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#"" class=""add-to-cart""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product__item__text"">
                                        <h6><a");
            BeginWriteAttribute("href", " href=\"", 10520, "\"", 10561, 2);
            WriteAttributeValue("", 10527, "/ProductDetail/Product?id=", 10527, 26, true);
#nullable restore
#line 197 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 10553, item.Id, 10553, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 197 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        <h5>$");
#nullable restore
#line 198 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                        Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 202 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"product__pagination\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 10931, "\"", 10994, 2);
            WriteAttributeValue("", 10938, "/ShoppingGrid/Index?pageNumber=", 10938, 31, true);
#nullable restore
#line 206 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 10969, Math.Max(pageNumber-1,1), 10969, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-left\"></i></a>\r\n");
#nullable restore
#line 207 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                      
                        for (int i = 1; i <= pageCount; ++i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 11182, "\"", 11222, 2);
            WriteAttributeValue("", 11189, "/ShoppingGrid/Index?pageNumber=", 11189, 31, true);
#nullable restore
#line 210 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 11220, i, 11220, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 210 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 211 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 11304, "\"", 11375, 2);
            WriteAttributeValue("", 11311, "/ShoppingGrid/Index?pageNumber=", 11311, 31, true);
#nullable restore
#line 213 "F:\Backend Devmaster\AppManager\AppManager\Views\ShoppingGrid\Index.cshtml"
WriteAttributeValue("", 11342, Math.Min(pageNumber+1,pageCount), 11342, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-right\"></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Product Section End -->\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // category
        $.ajax({
            url: ""/Home/GetAllCategories"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                $('#department2').html('');
                $('#department2').append('<li><a href=""/ShoppingGrid/Index"" class=""category"">All</a></li>');
                data.forEach(function (item,index){
                    let row = `<li><a href=""/ShoppingGrid/Index?id=${item.id}"" class=""category"">${item.name}</a></li>`;
                    $('#department2').append(row);
                })
            },
            error: function(){},
            complete: function(){}
        });

        // category
        // jquery chỉ chạy với id, thay vì class nếu nó được thêm vào sau khi tải trang

        $.ajax({
            url: ""/ShoppingGrid/GetAllCategories"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
           ");
                WriteLiteral(@" success: function(data){
                $('#department').html('');
                $('#department').append('<li><a href=""/ShoppingGrid/Index"" class=""category"">All</a></li>');
                data.forEach(function (item,index){
                    let row = `<li><a href=""/ShoppingGrid/Index?id=${item.id}"" class=""category"">${item.name}</a></li>`;
                    $('#department').append(row);
                })
            },
            error: function(){},
            complete: function(){}
        });

        // trigger khi thêm sản phẩm vào giỏ hàng
        $(document).ready(function(){
            $(document).on('click', '.add-to-cart', function(e){
                e.preventDefault();
                let id = $(this).closest('ul').attr('id');
                $.ajax({
                    url: ""/ShoppingCart/AddItemToCart"",
                    type: ""GET"",
                    data: {
                        id: id,
                    },
                    dataType: ""json"",
   ");
                WriteLiteral(@"                 beforeSend: function(){},
                    success: function(data){
                        alert(""Thêm sản phẩm vào giả hàng thành công!"");
                    },
                    error: function(){},
                    complete: function(){}
                });
            });
        });

        // hàm xử lý khi xử dụng input range
        function PriceRange(data){
             $.ajax({
                    url: ""/ShoppingGrid/FilterProductByPrice"",
                    type: ""GET"",
                    data: data,
                    dataType: ""json"",
                    beforeSend: function(){
                    },
                    success: function(data){
                        $('#filter-item').html('');
                        $('#product-count').html('');
                        let c = data.count;
                        $('#product-count').append(c);
                        if (c > 0){
                            let prd = data.listProduct;
    ");
                WriteLiteral(@"                        prd.forEach(function (item,index){
                                let price = parseFloat(item.price).toFixed(2);
                                let url = ""/ProductDetail/Product?id="" + item.id;
                                let row = `<div class=""col-lg-4 col-md-6 col-sm-6"">
                                                <div class=""product__item"">
                                                    <div class=""product__item__pic set-bg"" data-setbg=""${item.avatar}"" style=""background-image: url(${item.avatar});"">
                                                        <ul class=""product__item__pic__hover"" id=""${item.id}"">
                                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                                            <li><a href=""/ShoppingCart/AddItemToCart?id=${item.id}"" class=""add-to");
                WriteLiteral(@"-cart""><i class=""fa fa-shopping-cart""></i></a></li>
                                                        </ul>
                                                    </div>
                                                    <div class=""product__item__text"">
                                                        <h6><a href=""${url}"">${item.name}</a></h6>
                                                        <h5>$${price}</h5>
                                                    </div>
                                                </div>
                                            </div>`;
                                $('#filter-item').append(row);
                            });
                         }
                    },
                    error: function(){},
                    complete: function(){}
                });
        }

        // bắt trigger của input range
        $('.ui-slider-handle').on(""change mouseover"", function() {
            let min = $('#minamount').");
                WriteLiteral(@"val();
            min = min.substring(1,min.length);
            let max = $('#maxamount').val();
            max = max.substring(1,max.length);
            var data = {
                MinPrice: min,
                MaxPrice: max
            }
            PriceRange(data);
        });
       
        $.ajax({
            url: ""/Home/GetLatestProducts"",
            type: ""GET"",
            dataType: ""json"",
            success: function(data){
                let col = jQuery('<div>', {class: 'latest-prdouct__slider__item' });
                data.forEach(function(item,index){
                    let price = parseFloat(item.price).toFixed(2);
                    let row = `<a href=""/ProductDetail/Product?id=${item.id}"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""${item.avatar}"" alt="""">
                                    </div>
                                    <div class=""");
                WriteLiteral(@"latest-product__item__text"">
                                        <h6>${item.name}</h6>
                                        <span>$${price}</span>
                                    </div>
                                </a>`;
                    col.append(row);
                    if (index % 3 == 2){
                        $('#latest-product').owlCarousel().trigger('add.owl.carousel', col);                        
                        col = jQuery('<div>', {class: 'latest-prdouct__slider__item' });
                    }
                });
                $('#latest-product').trigger('refresh.owl.carousel');
            }
        })
    </script>
");
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
