using Domain.Common;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

[PrimaryKey(nameof(PhotoId), nameof(ApartmentId))]
public class ApartmentPhoto : BaseEntity
{
    public int PhotoId { get; set; }

    public int ApartmentId { get; set; }

    [ForeignKey(nameof(PhotoId))]
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Photo Photo { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}