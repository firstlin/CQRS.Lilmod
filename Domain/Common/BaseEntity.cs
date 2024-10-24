using System.Text.Json.Serialization;

namespace Domain.Common;

public class BaseEntity : IAuthor, ITimestamps, ISoftDelete
{
    [JsonIgnore]
    public Guid CreatedBy { get; set; }

    [JsonIgnore]
    public Guid? ModifiedBy { get; set; }

    [JsonIgnore]
    public DateTime CreatedAt { get; set; }

    [JsonIgnore]
    public DateTime? LastModifiedAt { get; set; }

    [JsonIgnore]
    public DateTime? DeleteAt { get; set; }

    public bool IsActive { get; set; }
}