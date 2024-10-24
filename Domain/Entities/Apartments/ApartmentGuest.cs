using Domain.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class ApartmentGuest : BaseEntity
{
    [Key]
    public long GuestId { get; set; }

    [Key]
    public long ApartmentId { get; set; }

    public EGuest Guest { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
