using Mydotnet.Infrastructure;

namespace Mydotnet.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService (MydotnetDbContext context): base(context) {
    }

}
