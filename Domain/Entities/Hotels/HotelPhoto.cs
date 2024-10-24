using Domain.Entities.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

public class HotelPhoto 
{
    [Key]
    public long HotelId { get; set; }

    [Key]
    public long PhotoId { get; set; }

    [ForeignKey(nameof(PhotoId))]
    public Photo Photo { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }
}
