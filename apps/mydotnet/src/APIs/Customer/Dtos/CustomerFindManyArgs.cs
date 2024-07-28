using Microsoft.AspNetCore.Mvc;
using Mydotnet.APIs.Common;
using Mydotnet.Infrastructure.Models;

namespace Mydotnet.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
