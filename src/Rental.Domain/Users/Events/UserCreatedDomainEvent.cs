using Rental.Domain.Abstractions;

namespace Rental.Domain.Users.Events;

public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;