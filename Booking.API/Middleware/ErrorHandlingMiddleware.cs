using Application.DTOs.Error;
using Application.Exceptions;

namespace Booking.API.Middleware;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorHandlingMiddleware> _logger;

    public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            if (exception is BookingException bookingException)
            {
                context.Response.StatusCode = bookingException.ErrorDetails.Code;
                await context.Response.WriteAsJsonAsync(bookingException.ErrorDetails);
            }
            else
            {
                _logger.LogError($"An unhandled exception occure {exception}");

                var errorDetails = new ErrorDto(StatusCodes.Status500InternalServerError, "Server Error", "Internal Server Error [Code:500]");
                
                context.Response.StatusCode = errorDetails.Code;
                await context.Response.WriteAsJsonAsync(errorDetails);
            }
        }
    }
}
