using Domain.Common;
using Domain.Entities.Apartments;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Administration;

public class Photo : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Url { get; set; }

    public string Alt { get; set; }

    public ICollection<ApartmentPhoto> ApartmentPhotos { get; set; }
}