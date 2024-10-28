using Domain.Common;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

[PrimaryKey(nameof(FeatureId), nameof(ApartmentId))]
public class ApartmentFeature : BaseEntity
{
    public int FeatureId { get; set; }

    public int ApartmentId { get; set; }

    [ForeignKey(nameof(FeatureId))]
    public Feature Feature { get; set; }

    [ForeignKey(nameof(ApartmentId))]
    public Apartment Apartment { get; set; }
}
