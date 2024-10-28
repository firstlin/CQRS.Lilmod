using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common;

public class BaseCatalog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200)]
    [Required]
    public string Name { get; set; }

    [StringLength(50)]
    public string Code { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}