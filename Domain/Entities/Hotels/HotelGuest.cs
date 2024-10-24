using Domain.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

public class HotelGuest : BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int HotelId { get; set; }

    public EGuest Guest { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }
}
