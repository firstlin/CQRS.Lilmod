using Domain.Common;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

[PrimaryKey(nameof(HotelId), nameof(FeatureId))]
public class HotelFeature : BaseEntity
{
    public int HotelId { get; set; }

    public int FeatureId { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }

    [ForeignKey(nameof(FeatureId))]
    public Feature Feature { get; set; }
}
