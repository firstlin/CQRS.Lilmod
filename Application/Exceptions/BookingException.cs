using Application.DTOs.Error;

namespace Application.Exceptions;

public class BookingException : Exception
{
    public ErrorDto ErrorDetails { get; }

    public BookingException(int code, string message, string details)
    {
        ErrorDetails = new ErrorDto(code, message, details);
    }
}
