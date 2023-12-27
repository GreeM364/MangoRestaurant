using Mango.Web.DTO;
using Mango.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductDto> products = new List<ProductDto>();
            var response = await _productService.GetAllProductsAsync<ResponseDto>("");

            if (response.IsSuccess)
                products = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));

            return View(products);
        }

        [Authorize]
        public async Task<IActionResult> Details(int productId)
        {
            ProductDto product = new ProductDto();
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId, "");

            if (response.IsSuccess)
                product = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));

            return View(product);
        }


        [Authorize]
        public IActionResult Login()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}