namespace Mydotnet.APIs.Dtos;

public class ProductCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? Metadata { get; set; }

    public string? Sku { get; set; }

    public DateTime UpdatedAt { get; set; }
}
