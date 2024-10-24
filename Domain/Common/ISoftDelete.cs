namespace Domain.Common;

public interface ISoftDelete
{
    public DateTime? DeleteAt { get; set; }
    public bool IsActive { get; set; }
}
