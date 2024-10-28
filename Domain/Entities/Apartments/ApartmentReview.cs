using Domain.Common;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

[PrimaryKey(nameof(ReviewId), nameof(ApartmentId))]
public class ApartmentReview : BaseEntity
{
    public int ReviewId { get; set; }

    public int ApartmentId { get; set; }

    [ForeignKey(nameof(ReviewId))]
    public Review Review { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}