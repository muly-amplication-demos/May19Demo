using Mydotnet.APIs.Dtos;
using Mydotnet.Infrastructure.Models;

namespace Mydotnet.APIs.Extensions;

public static class CustomersExtensions
{
    public static Customer ToDto(this CustomerDbModel model) {
        return new Customer
            {
      CreatedAt = model.CreatedAt,
Id = model.Id,
LastName = model.LastName,
Name = model.Name,
Orders = model.Orders?.Select(x => x.Id).ToList(),
UpdatedAt = model.UpdatedAt,

    };}

    public static CustomerDbModel ToModel(this CustomerUpdateInput updateDto, CustomerWhereUniqueInput uniqueId) {
        var customer = new CustomerDbModel { 
               Id = uniqueId.Id,
LastName = updateDto.LastName,
Name = updateDto.Name
     };

     if(updateDto.CreatedAt != null) {
     customer.CreatedAt = updateDto.CreatedAt.Value;
      }
if(updateDto.UpdatedAt != null) {
     customer.UpdatedAt = updateDto.UpdatedAt.Value;
      }

    return customer;}

}
