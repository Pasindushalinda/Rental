using Rental.Domain.Abstractions;

namespace Rental.Domain.Bookings.Events;

public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;