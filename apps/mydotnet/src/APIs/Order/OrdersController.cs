using Microsoft.AspNetCore.Mvc;

namespace Mydotnet.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service) : base(service)
    {
    }

}
