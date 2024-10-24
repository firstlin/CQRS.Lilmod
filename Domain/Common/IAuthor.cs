namespace Domain.Common;

public interface IAuthor
{
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
}
