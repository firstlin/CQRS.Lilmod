using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class ApartmentPrice : BaseEntity
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Value { get; set; }

    [Key]
    public int ApartmentId { get; set; }

    [ForeignKey(nameof(ApartmentGuest.Apartment))]
    public ICollection<ApartmentGuest> ApartmentGuests { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
