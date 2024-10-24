using Domain.Common;
using Domain.Entities.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

public class HotelFeature : BaseEntity
{
    [Key]
    public int HotelId { get; set; }

    [Key]
    public int FeatureId { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }

    [ForeignKey(nameof(FeatureId))]
    public Feature Feature { get; set; }
}
