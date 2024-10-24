using Domain.Common;
using Domain.Entities.Administration;
using Domain.Entities.Catalogs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Apartments;

public class Apartment : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required, StringLength(200)]    
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required,StringLength(200)]
    public string Location { get; set; }

    public int RoomTypeId { get; set; }
    
    public int PhotoId { get; set; }

    public int ApartmentTypeId { get; set; }

    public int FeatureId { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public virtual RoomType RoomType { get; set; }

    [ForeignKey(nameof(PhotoId))]
    public Photo MainPhoto { get; set; }
    
    [ForeignKey(nameof(Apartments.ApartmentPrice.Apartment))]
    public ICollection<ApartmentPrice> ApartmentPrice { get; set; }

    [ForeignKey(nameof(ApartmentPhoto.Apartment))]
    public ICollection<ApartmentPhoto> ApartmentPhotos { get; set; }

    [InverseProperty(nameof(ApartmentReview.Apartment))]
    public ICollection<ApartmentReview> ApartmentReviews { get; set; }

    [InverseProperty(nameof(ApartmentFeature.Apartment))]
    public ICollection<ApartmentFeature> ApartmentFeatures { get; set; }
}