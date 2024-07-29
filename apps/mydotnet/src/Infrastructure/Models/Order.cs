using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mydotnet.Infrastructure.Models;

[Table("Orders")]
public class OrderDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public CustomerDbModel? Customer { get; set; } = null;

    [StringLength(1000)]
    public string? Details { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
