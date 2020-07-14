using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Utilities.Constants;

namespace QL_Vat_Lieu_Xay_Dung_Data_EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public DbInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Description = "Customer"
                });
            }
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active,
                    EmailConfirmed = true
                }, "123456789");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (!_context.Functions.Any())
            {
                _context.Functions.AddRange(new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "Hệ thống",ParentId = null,SortOrder = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Nhóm",ParentId = "SYSTEM",SortOrder = 1,Status = Status.Active,URL = "/admin/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Chức năng",ParentId = "SYSTEM",SortOrder = 2,Status = Status.Active,URL = "/admin/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "Người dùng",ParentId = "SYSTEM",SortOrder =3,Status = Status.Active,URL = "/admin/user/index",IconCss = "fa-home"  },
                    new Function() {Id = "ACTIVITY", Name = "Nhật ký",ParentId = "SYSTEM",SortOrder = 4,Status = Status.Active,URL = "/admin/activity/index",IconCss = "fa-home"  },
                    new Function() {Id = "ERROR", Name = "Lỗi",ParentId = "SYSTEM",SortOrder = 5,Status = Status.Active,URL = "/admin/error/index",IconCss = "fa-home"  },
                    new Function() {Id = "SETTING", Name = "Cấu hình",ParentId = "SYSTEM",SortOrder = 6,Status = Status.Active,URL = "/admin/setting/index",IconCss = "fa-home"  },
                    new Function() {Id = "PRODUCT",Name = "Sản phẩm",ParentId = null,SortOrder = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Danh mục",ParentId = "PRODUCT",SortOrder =1,Status = Status.Active,URL = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Sản phẩm",ParentId = "PRODUCT",SortOrder = 2,Status = Status.Active,URL = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "BILL",Name = "Hóa đơn",ParentId = "PRODUCT",SortOrder = 3,Status = Status.Active,URL = "/admin/bill/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "CONTENT",Name = "Nội dung",ParentId = null,SortOrder = 3,Status = Status.Active,URL = "/",IconCss = "fa-table"  },
                    new Function() {Id = "UTILITY",Name = "Tiện ích",ParentId = null,SortOrder = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortOrder = 1,Status = Status.Active,URL = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Phản hồi",ParentId = "UTILITY",SortOrder = 2,Status = Status.Active,URL = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ANNOUNCEMENT",Name = "Thông báo",ParentId = "UTILITY",SortOrder = 3,Status = Status.Active,URL = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Liên hệ",ParentId = "UTILITY",SortOrder = 4,Status = Status.Active,URL = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Function() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",SortOrder = 5,Status = Status.Active,URL = "/admin/slide/index",IconCss = "fa-clone"  },
                    new Function() {Id = "REPORT",Name = "Báo cáo",ParentId = null,SortOrder = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Báo cáo doanh thu",ParentId = "REPORT",SortOrder = 1,Status = Status.Active,URL = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Báo cáo truy cập",ParentId = "REPORT",SortOrder = 2,Status = Status.Active,URL = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "READER",Name = "Reader Report",ParentId = "REPORT",SortOrder = 3,Status = Status.Active,URL = "/admin/report/reader",IconCss = "fa-bar-chart-o"  },
                });
            }
            if (!_context.Slides.Any())
            {
                var slides = new List<Slide>()
                {
                    new Slide() {Name="Slide 1",Image="/img_ds/slide-1.jpg",Url="#",DisplayOrder = 1,GroupAlias = "top",Status=Status.Active },
                    new Slide() {Name="Slide 2",Image="/img_ds/slide-2.jpg",Url="#",DisplayOrder = 2,GroupAlias = "top",Status=Status.Active },
                    new Slide() {Name="Slide 3",Image="/img_ds/slide-3.jpg",Url="#",DisplayOrder = 3,GroupAlias = "top",Status=Status.Active },

                    new Slide() {Name="Slide 1",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 1,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 2",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 2,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 3",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 3,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 4",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 4,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 5",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 5,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 6",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 6,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 7",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 7,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 8",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 8,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 9",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 9,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 10",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 10,GroupAlias = "brand",Status=Status.Active },
                    new Slide() {Name="Slide 11",Image="/img_ds/brand1.png",Url="#",DisplayOrder = 11,GroupAlias = "brand",Status=Status.Active },
                };
                await _context.Slides.AddRangeAsync(slides);
            }
            if (!_context.Sizes.Any())
            {
                var listSize = new List<Size>()
                {
                    new Size() { Name="1530mm x 1250mm"},
                    new Size() { Name="6m2" },
                    new Size() { Name="300mm x 300mm" },
                    new Size() { Name="390mm x 390mm x 28mm" },
                    new Size() { Name="105mm x 215mm x 50mm" },
                    new Size() { Name="147mm x 22mm"},
                    new Size() { Name="20mm x 20mm x 6mm" }
                };
                await _context.Sizes.AddRangeAsync(listSize);
            }
            if (!_context.ProductCategories.Any())
            {
                var listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Gạch Ốp Lát",SeoAlias="gach-op-lat",ParentId = null,Status=Status.Active,SortOrder=1,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Gạch INAX-155F",DateCreated=DateTime.Now,Image="/img_ds/product-1.jpg",SeoAlias = "gach-inax-155f",Price = 350000,Status = Status.Active,OriginalPrice = 200000},
                            new Product(){Name = "Gạch INAX HAL-25B",DateCreated=DateTime.Now,Image="/img_ds/product-2.jpg",SeoAlias = "gach-inax-25b",Price = 350000,Status = Status.Active,OriginalPrice = 200000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT009",DateCreated=DateTime.Now,Image="/img_ds/product-3.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt009",Price = 420000,Status = Status.Active,OriginalPrice = 300000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT010",DateCreated=DateTime.Now,Image="/img_ds/product-4.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt010",Price = 420000,Status = Status.Active,OriginalPrice = 300000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT011",DateCreated=DateTime.Now,Image="/img_ds/product-5.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt011",Price = 500000,Status = Status.Active,OriginalPrice = 300000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT016",DateCreated=DateTime.Now,Image="/img_ds/product-6.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt016",Price = 500000,Status = Status.Active,OriginalPrice = 300000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT018",DateCreated=DateTime.Now,Image="/img_ds/product-7.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt018",Price = 500000,Status = Status.Active,OriginalPrice = 300000},
                            new Product(){Name = "Gạch tranh mosaic nghệ thuật GT020",DateCreated=DateTime.Now,Image="/img_ds/product-8.jpg",SeoAlias = "gach-tranh-mosaic-nghe-thuat-gt020",Price = 500000,Status = Status.Active,OriginalPrice = 300000},
                        }
                    },
                    new ProductCategory() { Name="Xi Măng",SeoAlias="xi-mang",ParentId = null,Status=Status.Active ,SortOrder=2,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Xi Măng Vicem Hà Tiên Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds/product-9.jpg",SeoAlias = "xi-mang-vicem-ha-tien-da-dung",Price = 85000,Status = Status.Active,OriginalPrice = 50000},
                            new Product(){Name = "Xi Măng Hà Tiên 2 Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds/product-10.jpg",SeoAlias = "xi-mang-ha-tien-2-da-dung",Price = 85000,Status = Status.Active,OriginalPrice = 50000},
                            new Product(){Name = "Xi Măng Hoàng Mai Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds/product-11.jpg",SeoAlias = "xi-mang-hoang-long-da-dung",Price = 85000,Status = Status.Active,OriginalPrice = 50000},
                            new Product(){Name = "Xi Măng Hoàng Long Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds/product-12.jpg",SeoAlias = "xi-mang-hoang-mai-da-dung",Price = 105000,Status = Status.Active,OriginalPrice = 50000},
                            new Product(){Name = "Xi Măng Hoàng Thạch Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds//product-13.jpg",SeoAlias = "xi-mang-hoang-thach-da-dung",Price = 95000,Status = Status.Active,OriginalPrice = 50000},
                            new Product(){Name = "Xi Măng Holcim Đa Dụng",DateCreated=DateTime.Now,Image="/img_ds/product-14.jpg",SeoAlias = "xi-mang-holcim-da-dung",Price = 95000,Status = Status.Active,OriginalPrice = 50000},
                        }},
                    new ProductCategory() { Name="Giàn Giáo",SeoAlias="gian-giao",ParentId = null,Status=Status.Active ,SortOrder=3,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Giàn giáo xây dựng khung H",DateCreated=DateTime.Now,Image="/img_ds/product-15.jpg",SeoAlias = "gian-giao-xay-dung-khung-h",Price = 650000,Status = Status.Active,OriginalPrice = 500000},
                            new Product(){Name = "Giàn Giáo Xây Dựng RỒNG VIỆT",DateCreated=DateTime.Now,Image="/img_ds/product-16.jpg",SeoAlias = "gian-giao-xay-dung-rong-viet",Price = 750000,Status = Status.Active,OriginalPrice = 500000},
                            new Product(){Name = "Giàn Giáo Nêm Chống",DateCreated=DateTime.Now,Image="/img_ds/product-17.jpg",SeoAlias = "gian-giao-nem-chong",Price = 850000,Status = Status.Active,OriginalPrice = 500000},
                            new Product(){Name = "Giàn giáo nêm Hưng Thịnh",DateCreated=DateTime.Now,Image="/img_ds/product-18.jpg",SeoAlias = "gian-giao-nem-hung-thinh",Price = 950000,Status = Status.Active,OriginalPrice = 500000},
                            new Product(){Name = "GIÀN GIÁO KẼM, DÀN GIÁO MẠ KẼM",DateCreated=DateTime.Now,Image="/img_ds/product-19.jpg",SeoAlias = "gian-giao-kem-dan-giao-ma-kem",Price = 650000,Status = Status.Active,OriginalPrice = 500000},
                        }},
                    new ProductCategory() { Name="Gạch Block",SeoAlias="gach-block",ParentId = null,Status=Status.Active,SortOrder=4,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Gạch cổ xây AB09",DateCreated=DateTime.Now, Image="/img_ds/product-20.jpg",SeoAlias = "gach-co-xay-ab09",Price = 8500,Status = Status.Active,OriginalPrice = 5000},
                            new Product(){Name = "Gạch cổ xây AB01",DateCreated=DateTime.Now,Image="/img_ds/product-21.jpg",SeoAlias = "gach-co-xay-ab01",Price = 8500,Status = Status.Active,OriginalPrice = 5000},
                            new Product(){Name = "Gạch cổ xây AB02",DateCreated=DateTime.Now,Image="/img_ds/product-22.jpg",SeoAlias = "gach-co-xay-ab02",Price = 8500,Status = Status.Active,OriginalPrice = 5000},
                            new Product(){Name = "Gạch Block khuôn bông trang trí V403",DateCreated=DateTime.Now,Image="/img_ds/product-23.jpg",SeoAlias = "gach-block-khuon-bong-trang-tri-v403",Price = 169000,Status = Status.Active,OriginalPrice = 150000},
                            new Product(){Name = "Gạch bánh ú bê tông xi măng",DateCreated=DateTime.Now,Image="/img_ds/product-24.jpg",SeoAlias = "gach-banh-u-be-tong-xi-mang",Price = 22000,Status = Status.Active,OriginalPrice = 12000},
                        }}
                };
                await _context.ProductCategories.AddRangeAsync(listProductCategory);
            }

            if (_context.Footers.Count(x => x.Id == CommonConstants.DefaultFooterId) == 0)
            {
                const string content = "Footer";
                _context.Footers.Add(new Footer()
                {
                    Id = CommonConstants.DefaultFooterId,
                    Content = content
                });
                _context.SaveChanges();
            }
            if (!_context.SystemConfigs.Any(x => x.Id == "HomeTitle"))
            {
                _context.SystemConfigs.Add(new SystemConfig()
                {
                    Id = "HomeTitle",
                    Name = "Tiêu đề trang chủ",
                    Value1 = "Trang chủ",
                    Status = Status.Active
                });
            }
            if (!_context.SystemConfigs.Any(x => x.Id == "HomeMetaKeyword"))
            {
                _context.SystemConfigs.Add(new SystemConfig()
                {
                    Id = "HomeMetaKeyword",
                    Name = "Từ khoá trang chủ",
                    Value1 = "Trang chủ",
                    Status = Status.Active
                });
            }
            if (!_context.SystemConfigs.Any(x => x.Id == "HomeMetaDescription"))
            {
                _context.SystemConfigs.Add(new SystemConfig()
                {
                    Id = "HomeMetaDescription",
                    Name = "Mô tả trang chủ",
                    Value1 = "Trang chủ",
                    Status = Status.Active
                });
            }

            await _context.SaveChangesAsync();
        }
    }
}
