using Domain.Common;
using Domain.Entities.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class ApartmentPhoto : BaseEntity
{
    [Key]
    public long PhotoId { get; set; }

    [Key]
    public long ApartmentId { get; set; }

    [ForeignKey(nameof(PhotoId))]
    public Photo Photo { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}