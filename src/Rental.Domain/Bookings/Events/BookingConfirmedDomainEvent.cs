using Rental.Domain.Abstractions;

namespace Rental.Domain.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;