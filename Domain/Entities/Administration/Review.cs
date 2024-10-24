using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Administration;

public class Review : BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    [Required, Column(TypeName = "decimal(3,1)")]
    public decimal Rating { get; set; }

    [Required, StringLength(100)]
    public string Author { get; set; }
}