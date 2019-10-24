using System.Dynamic;
using System.Web.Http;

namespace AzureDay.Legacy.Web.Controllers
{
    public class ProductsController : ApiController
    {
        public dynamic Get()
        {
            dynamic products = new ExpandoObject();

            products.items = new object[]
            {
                "Product 01",
                "Product 02",
                "Product 03",
                "Product 04",
                "Product 05",
            };

            return Json(products);
        }
    }
}
