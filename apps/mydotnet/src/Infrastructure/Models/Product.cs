using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mydotnet.Infrastructure.Models;

[Table("Products")]
public class ProductDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Metadata { get; set; }

    [StringLength(1000)]
    public string? Sku { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
