using Mydotnet.Infrastructure;

namespace Mydotnet.APIs;

public class ProductsService : ProductsServiceBase
{
    public ProductsService(MydotnetDbContext context)
        : base(context) { }
}
