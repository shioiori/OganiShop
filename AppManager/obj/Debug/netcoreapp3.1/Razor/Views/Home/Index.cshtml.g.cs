#pragma checksum "F:\Backend Devmaster\AppManager\AppManager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6547dde178740f57f1efae621701f6243e98ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6547dde178740f57f1efae621701f6243e98ef1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bdf4e2eeb9182a14600fe5d339bdb2f9540938", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "F:\Backend Devmaster\AppManager\AppManager\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Categories Section Begin -->

<section class=""hero"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero__categories"">
                    <div class=""hero__categories__all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    <ul id=""department"">
                        <li><a href=""#"">Fresh Meat</a></li>
                        <li><a href=""#"">Vegetables</a></li>
                        <li><a href=""#"">Fruit & Nut Gifts</a></li>
                        <li><a href=""#"">Fresh Berries</a></li>
                        <li><a href=""#"">Ocean Foods</a></li>
                        <li><a href=""#"">Butter & Eggs</a></li>
                        <li><a href=""#"">Fastfood</a></li>
                        <li><a href=""#"">Fresh Onion</a></li>
                        <li><a href=""#"">Papayaya & Crisps</a></li>
                     ");
            WriteLiteral(@"   <li><a href=""#"">Oatmeal</a></li>
                        <li><a href=""#"">Fresh Bananas</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""hero__search"">
                    <div class=""hero__search__form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6547dde178740f57f1efae621701f6243e98ef15182", async() => {
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
                <div class=""hero__item set-bg"" id=""banner"" data-setbg=""/img/hero/banner.jpg"">
                    <div class=""hero__text"">
                        <span>FRUIT FRESH</span>
                        <h2>Vegetable <br />100% Organic</h2>
                        <p>Free Pickup and Delivery Available</p>
                        <a href=""/ShoppingGrid/Index"" class=""primary-btn"">SHOP NOW</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            WriteLiteral(@"<section class=""categories"">
    <div class=""container"">
        <div class=""row"">
            <div class=""categories__slider owl-carousel"" id=""categories"">
            </div>
        </div>
    </div>
</section>
<!-- Categories Section End -->
<!-- Featured Section Begin -->
<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>Featured Product</h2>
                </div>
                <div class=""featured__controls"">
                    <ul id=""featured-categories"">
                        <li data-filter=""*"" class=""filter"">All</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row featured__filter"" id=""category-filter"">
        </div>
    </div>
</section>
<!-- Featured Section End -->
<!-- Banner Begin -->
<div class=""banner"">
    <div class=""container"">
        <div class=""row smal");
            WriteLiteral("l-banner\">\r\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                <div class=\"banner__pic\">\r\n                    <img src=\"/img/banner/banner-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4052, "\"", 4058, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                <div class=\"banner__pic\">\r\n                    <img src=\"/img/banner/banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4258, "\"", 4264, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner End -->
<!-- Latest Product Section Begin -->
<section class=""latest-product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product__text"">
                    <h4>Latest Products</h4>
                    <div class=""latest-product__slider owl-carousel"">
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5004, "\"", 5010, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5543, "\"", 5549, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6082, "\"", 6088, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6721, "\"", 6727, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7260, "\"", 7266, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7799, "\"", 7805, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product__text"">
                    <h4>Top Rated Products</h4>
                    <div class=""latest-product__slider owl-carousel"">
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8727, "\"", 8733, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9266, "\"", 9272, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9805, "\"", 9811, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10444, "\"", 10450, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10983, "\"", 10989, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11522, "\"", 11528, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product__text"">
                    <h4>Review Products</h4>
                    <div class=""latest-product__slider owl-carousel"">
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12447, "\"", 12453, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12986, "\"", 12992, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13525, "\"", 13531, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct__slider__item"">
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14164, "\"", 14170, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14703, "\"", 14709, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product__item"">
                                <div class=""latest-product__item__pic"">
                                    <img src=""/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15242, "\"", 15248, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product__item__text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Latest Product Section End -->
<!-- Blog Section Begin -->
<section class=""from-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title from-blog__title"">
                    <h2>From The Blog</h2>
                </div>
            </div>
        </div>
        <div class=""row"" id=""blog"">
        </div>
    </div>
</section>

");
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


        // banner 

        $.ajax({
            url: ""/Home/GetHeaderBanner"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                console.log(data);
                $('#banner'");
                WriteLiteral(@").attr('data-setbg', data.filePath);
                $('#banner').css('background-image', data.filePath);
            },
            error: function(){},
            complete: function(){}
        });

        // category image: ????
        $(document).ready(function(){  
            $.ajax({
                url: ""/Home/GetAllCategoryImage"",
                type: ""GET"",
                dataType: ""json"",
                beforeSend: function(){},
                success: function(data){
                    // k xài empty html với carousel k nó sẽ lỗi
                    //$('#categories').html('');
                    data.forEach(function(item,index){
                        let row = `<div class=""col-lg-3"">
                                        <div class=""categories__item set-bg"" data-setbg=""${item.filePath}"" style=""background-image: url(${item.filePath});"">
                                            <h5><a href=""/ShoppingGrid/Index?id=${item.id}"">${item.name}</a></h5>
              ");
                WriteLiteral(@"                          </div>
                                    </div>`;
                        $('#categories').owlCarousel().trigger('add.owl.carousel', row);
                        //$('#categories').append(row);
                    });
                    $('#categories').trigger('refresh.owl.carousel');
                },
                error: function(){},
                complete: function(){}
            });
        });

        // feature

        $.ajax({
            url: ""/Home/GetAllFeature"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
               data.forEach(function(item,index){
                   console.log(item);
                   let row = `<li data-filter="".${item.categorySlug}"" class=""filter"">${item.categoryName}</li>`;
                   $('#featured-categories').append(row);
                   
                   item.listProduct.forEach(function(itm, index){
     ");
                WriteLiteral(@"                   let price = parseFloat(itm.price).toFixed(2);
                        let r = `<div class=""col-lg-3 col-md-4 col-sm-6 mix ${item.categorySlug}"">
                                    <div class=""featured__item"">
                                        <div class=""featured__item__pic set-bg"" style=""background-image: url(${itm.avatar})"">
                                            <ul class=""featured__item__pic__hover"" id=""${itm.id}"">
                                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                                <li><a href=""#"" class=""add-to-cart""><i class=""fa fa-shopping-cart""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""featured__item__text"">
                                            <h6><a hre");
                WriteLiteral(@"f=""/ProductDetail/Product?id=${itm.id}"">${itm.name}</a></h6>
                                            <h5>$${price}</h5>
                                        </div>
                                    </div>
                                </div>`
                        $('#category-filter').append(r);
                   })
               });
            },
            error: function(){},
            complete: function(){}
        });

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
                    beforeSend: function(){},
                    success: function(data){
                        al");
                WriteLiteral(@"ert(""Thêm sản phẩm vào giả hàng thành công!"");
                    },
                    error: function(){},
                    complete: function(){}
                });
            });
        });

        // small banner

        $.ajax({
            url: ""/Home/GetSmallBanner"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
               $('.small-banner').html('');
               console.log(data);
               data.forEach(function(item,index){
                   let row = `<div class=""col-lg-6 col-md-6 col-sm-6"">
                                    <div class=""banner__pic"">
                                        <img src=""${item.imagePath}"" alt="""">
                                    </div>
                               </div>`;
                   $('.small-banner').append(row);
               });
            },
            error: function(){},
            complete: function(){}
     ");
                WriteLiteral(@"   });

        // blog
        $.ajax({
            url: ""/Blog/GetRecentNews"",
            type: ""GET"",
            dataType: ""json"",
            success: function(data){
                data.forEach(function(item,index){
                    let row = ` <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""blog__item"">
                                        <div class=""blog__item__pic"">
                                            <img src=""${item.postAvatarFilePath}"" alt="""" style=""width: 360px; height: 260px"">
                                        </div>
                                        <div class=""blog__item__text"">
                                            <ul>
                                                <li><i class=""fa fa-calendar-o""></i>${item.createdDate}</li>
                                                <li><i class=""fa fa-comment-o""></i> 5</li>
                                            </ul>
                                  ");
                WriteLiteral(@"          <h5><a href=""/BlogDetail/Post?id=${item.id}"">${item.title}</a></h5>
                                            <p>${item.description}</p>
                                        </div>
                                    </div>
                                </div>`
                    $('#blog').append(row);
                });
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
