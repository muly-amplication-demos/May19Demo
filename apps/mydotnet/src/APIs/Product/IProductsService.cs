using Mydotnet.APIs.Dtos;
using Mydotnet.APIs.Common;

namespace Mydotnet.APIs;

public interface IProductsService
{
    /// <summary>
    /// Create one Product
    /// </summary>
    public Task<Product> CreateProduct(ProductCreateInput product);
    /// <summary>
    /// Delete one Product
    /// </summary>
    public Task DeleteProduct(ProductWhereUniqueInput uniqueId);
    /// <summary>
    /// Find many Products
    /// </summary>
    public Task<List<Product>> Products(ProductFindManyArgs findManyArgs);
    /// <summary>
    /// Meta data about Product records
    /// </summary>
    public Task<MetadataDto> ProductsMeta(ProductFindManyArgs findManyArgs);
    /// <summary>
    /// Get one Product
    /// </summary>
    public Task<Product> Product(ProductWhereUniqueInput uniqueId);
    /// <summary>
    /// Update one Product
    /// </summary>
    public Task UpdateProduct(ProductWhereUniqueInput uniqueId, ProductUpdateInput updateDto);
}
