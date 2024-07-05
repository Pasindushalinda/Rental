﻿using Rental.Application.Abstractions.Messaging;

namespace Rental.Application.Bookings.ReserveBooking;

public record ReserveBookingCommand(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate):ICommand<Guid>;