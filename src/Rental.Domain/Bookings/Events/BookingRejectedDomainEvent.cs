using Rental.Domain.Abstractions;

namespace Rental.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;