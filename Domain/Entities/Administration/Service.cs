using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Administration;

public class Service : BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required, Column(TypeName = "decimal(5,2)")]
    public decimal Price { get; set; }
}