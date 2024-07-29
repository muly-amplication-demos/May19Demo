using Microsoft.AspNetCore.Mvc;

namespace Mydotnet.APIs;

[ApiController()]
public class ProductsController : ProductsControllerBase
{
    public ProductsController (IProductsService service): base(service) {
    }

}
