using Domain.Common;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

[PrimaryKey(nameof(ReviewId), nameof(HotelId))]
public class HotelReview : BaseEntity
{
    public int ReviewId { get; set; }

    public int HotelId { get; set; }

    [ForeignKey(nameof(ReviewId))]
    public Review Review { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }
}
