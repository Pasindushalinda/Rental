using Rental.Domain.Abstractions;

namespace Rental.Domain.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;