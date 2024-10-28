using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

[PrimaryKey(nameof(Id), nameof(HotelId))]
public class HotelPrice : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Value { get; set; }

    public int HotelId { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }
}
