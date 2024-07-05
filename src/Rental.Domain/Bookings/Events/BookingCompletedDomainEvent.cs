using Rental.Domain.Abstractions;

namespace Rental.Domain.Bookings.Events;

public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;