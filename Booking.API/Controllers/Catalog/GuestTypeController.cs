using Application.Services.Catalog.GuestType.Command.Add;
using Domain.Entities.Catalogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers.Catalog;

[ApiController, Route("api/[controller]")]
public class GuestTypeController : Controller
{
    private readonly IMediator _mediator;

    public GuestTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    //public IActionResult Index()
    //{
    //    return View();
    //}

    public async Task<GuestType> CreateGuestType(GuestType guestType)
    {
        return await _mediator.Send(new CreateGuestTypeRequest(){ GuestType = guestType });
    }
}
