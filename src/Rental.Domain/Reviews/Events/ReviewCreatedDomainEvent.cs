using Rental.Domain.Abstractions;

namespace Rental.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;