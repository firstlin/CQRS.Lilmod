using Domain.Common;
using Domain.Entities.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class ApartmentFeature : BaseEntity
{
    [Key]
    public int FeatureId { get; set; }

    [Key]
    public int ApartmentId { get; set; }

    [ForeignKey(nameof(FeatureId))]
    public Feature Feature { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
