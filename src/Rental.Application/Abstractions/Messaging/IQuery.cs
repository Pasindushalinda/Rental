using MediatR;
using Rental.Domain.Abstractions;

namespace Rental.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}