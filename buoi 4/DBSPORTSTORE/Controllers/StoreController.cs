using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBSportStore.Models;

namespace DBSportStore.Controllers
{
    // Controller xử lý các request của trang Store
    public class StoreController : Controller
    {
        // GET: Store
        // Action Index xử lý URL /Store/Index
        public ActionResult Index()
        {
            // Tạo danh sách sản phẩm mẫu
            var products = new List<ProductCardViewModel>
            {
// Sản phẩm mẫu 1
                new ProductCardViewModel { ProductID = 1, NamePro = "Nike Air Zoom", CategoryName = "Giày thể thao", Price = 1290000, ImagePro = "shoe-01.jpg" ,ShortDescription = "Giày chạy bộ chuyên nghiệp, siêu nhẹ và êm chân."},
// Sản phẩm mẫu 2
                new ProductCardViewModel { ProductID = 2, NamePro = "Adidas Training Tee", CategoryName = "Áo quần thi đấu", Price = 1590000, ImagePro = "shirt-01-02.jpg" ,ShortDescription = "Áo thun thể thao thoáng khí, thấm mồ hôi tốt."},
// Sản phẩm mẫu 3
                new ProductCardViewModel { ProductID = 3, NamePro = "Gym Performance Set", CategoryName = "Dụng cụ thể thao", Price = 2890000, ImagePro = "gym-set.jpg" ,ShortDescription = "Bộ dụng cụ tập gym đa năng tại nhà."},
// Sản phẩm mẫu 4
                new ProductCardViewModel { ProductID = 4, NamePro = "Running Shoes Pro", CategoryName = "Giày thể thao", Price = 1490000, ImagePro = "shoe-02.jpg" ,ShortDescription = "Giày chuyên dụng cho vận động viên điền kinh."},
                new ProductCardViewModel { ProductID = 5, NamePro = "sports cap", CategoryName = "Mũ thể thao", Price = 450000, ImagePro = "ball-01.jpg" ,ShortDescription = "Mũ thể thao năng động, chống tia UV."},
    
    // Thêm sản phẩm mới 2
    new ProductCardViewModel { ProductID = 6, NamePro = "Găng tay thủ môn Nike", CategoryName = "Phụ kiện thể thao", Price = 2320000, ImagePro = "gloves-01.jpg" ,ShortDescription = "Găng tay bám dính tốt, bảo vệ khớp ngón tay."} };

            // Truyền products sang View Index
            return View(products);

        }
        public ActionResult AboutStore()
        {
            return View();
        }
    }
}
