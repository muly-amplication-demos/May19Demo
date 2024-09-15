using Mydotnet.APIs.Dtos;
using Mydotnet.Infrastructure.Models;

namespace Mydotnet.APIs.Extensions;

public static class OrdersExtensions
{
    public static Order ToDto(this OrderDbModel model) {
        return new Order
            {
      CreatedAt = model.CreatedAt,
Customer = model.CustomerId,
Details = model.Details,
Id = model.Id,
UpdatedAt = model.UpdatedAt,

    };}

    public static OrderDbModel ToModel(this OrderUpdateInput updateDto, OrderWhereUniqueInput uniqueId) {
        var order = new OrderDbModel { 
               Id = uniqueId.Id,
Details = updateDto.Details
     };

     if(updateDto.CreatedAt != null) {
     order.CreatedAt = updateDto.CreatedAt.Value;
      }
if(updateDto.Customer != null) {
     order.CustomerId = updateDto.Customer;
      }
if(updateDto.UpdatedAt != null) {
     order.UpdatedAt = updateDto.UpdatedAt.Value;
      }

    return order;}

}
