using Mydotnet.APIs.Dtos;
using Mydotnet.Infrastructure.Models;

namespace Mydotnet.APIs.Extensions;

public static class ProductsExtensions
{
    public static Product ToDto(this ProductDbModel model)
    {
        return new Product
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Metadata = model.Metadata,
            Sku = model.Sku,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ProductDbModel ToModel(
        this ProductUpdateInput updateDto,
        ProductWhereUniqueInput uniqueId
    )
    {
        var product = new ProductDbModel
        {
            Id = uniqueId.Id,
            Metadata = updateDto.Metadata,
            Sku = updateDto.Sku
        };

        if (updateDto.CreatedAt != null)
        {
            product.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            product.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return product;
    }
}
