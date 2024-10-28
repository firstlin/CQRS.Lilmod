using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

[PrimaryKey(nameof(Id), nameof(ApartmentId))]
public class ApartmentPrice : BaseEntity
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Value { get; set; }

    public int ApartmentId { get; set; }

    //[ForeignKey(nameof(ApartmentGuest.Apartment))]
    //public ICollection<ApartmentGuest> ApartmentGuests { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
