using System.Dynamic;
using System.Web.Http;

namespace AzureDay.Legacy.Web.Controllers
{
    public class CustomersController : ApiController
    {
        public dynamic Get()
        {
            dynamic customers = new ExpandoObject();

            customers.items = new object[]
            {
                "Customer 01",
                "Customer 02",
                "Customer 03",
                "Customer 04",
                "Customer 05",
            };

            return Json(customers);
        }
    }
}
