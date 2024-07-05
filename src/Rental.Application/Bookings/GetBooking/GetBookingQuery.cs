using Rental.Application.Abstractions.Messaging;

namespace Rental.Application.Bookings.GetBooking;

public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;