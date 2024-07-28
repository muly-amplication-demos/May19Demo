using Mydotnet.Infrastructure;

namespace Mydotnet.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(MydotnetDbContext context)
        : base(context) { }
}
