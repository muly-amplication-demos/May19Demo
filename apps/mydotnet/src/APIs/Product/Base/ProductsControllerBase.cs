using Microsoft.AspNetCore.Mvc;
using Mydotnet.APIs;

namespace Mydotnet.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ProductsControllerBase : ControllerBase
{
    protected readonly IProductsService _service;
    public ProductsControllerBase (IProductsService service) {
        _service = service;}

}
