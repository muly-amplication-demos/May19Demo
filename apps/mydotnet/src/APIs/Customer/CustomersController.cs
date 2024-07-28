using Microsoft.AspNetCore.Mvc;

namespace Mydotnet.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
