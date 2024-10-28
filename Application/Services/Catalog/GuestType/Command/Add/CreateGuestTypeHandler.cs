using MediatR;
using Application.Exceptions;
using Application.Repositories;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Application.Services.Catalog.GuestType.Command.Add;

using Application.Interfaces;
using Domain.Entities.Catalogs;

public class CreateGuestTypeHandler : IRequestHandler<CreateGuestTypeRequest, GuestType>
{
    private readonly IRepository<GuestType> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateGuestTypeHandler> _logger;

    public CreateGuestTypeHandler(IRepository<GuestType> repository, IUnitOfWork unitOfWork, ILogger<CreateGuestTypeHandler> logger)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<GuestType> Handle(CreateGuestTypeRequest request, CancellationToken cancellationToken)
    {
        try
        {
            
            var guestType = await _repository.AddAsync(request.GuestType);
            await _unitOfWork.Commit(cancellationToken);
            return guestType;
        }
        catch (Exception ex)
        {
            _logger.LogError("Unable to creae GuestType @{ex}", ex);
            throw new BookingException((int)HttpStatusCode.BadRequest, "Unable to creae GuestType", ex.Message.ToString());
        }
    }
}