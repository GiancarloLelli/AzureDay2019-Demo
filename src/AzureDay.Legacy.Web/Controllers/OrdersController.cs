using System.Dynamic;
using System.Web.Http;

namespace AzureDay.Legacy.Web.Controllers
{
    public class OrdersController : ApiController
    {
        public dynamic Get()
        {
            dynamic orders = new ExpandoObject();

            orders.items = new object[]
            {
                "Order 01",
                "Order 02",
                "Order 03",
                "Order 04",
                "Order 05",
            };

            return Json(orders);
        }
    }
}
