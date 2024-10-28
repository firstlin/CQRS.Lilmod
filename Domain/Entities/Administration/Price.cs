using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Administration;

public class Price
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "decimal(5,1)")]
    public decimal value { get; set; }

    //[ForeignKey(nameof(ApartmentGuest.Apartment))]
    //public ICollection<ApartmentGuest> ApartmentGuests { get; set; }
}