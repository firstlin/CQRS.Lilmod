using Domain.Common;
using Domain.Entities.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class ApartmentReview : BaseEntity
{
    [Key]
    public int ReviewId { get; set; }

    [Key]
    public int ApartmentId { get; set; }

    [ForeignKey(nameof(ReviewId))]
    public Review Review { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}