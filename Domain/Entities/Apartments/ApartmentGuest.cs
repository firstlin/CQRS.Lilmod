using Domain.Common;
using Domain.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

[PrimaryKey(nameof(GuestId), nameof(ApartmentId))]
public class ApartmentGuest : BaseEntity
{
    public int GuestId { get; set; }

    public int ApartmentId { get; set; }

    public int GuestTypeId { get; set; }

    [ForeignKey(nameof(GuestTypeId))]
    public GuestType Guest { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
