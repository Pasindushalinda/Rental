﻿using Rental.Domain.Apartments;
using Rental.Domain.Shared;

namespace Rental.Domain.Bookings;

public class PricingService
{
    public PricingDetails CalculatePrice(Apartment apartment, DateRange duration)
    {
        var currency = apartment.Price.Currency;

        var priceForPeriod= new Money(
            apartment.Price.Amount * duration.LengthInDays,
            currency
        );

        decimal percentageUpCharge = 0;

        foreach (var amenity in apartment.Amenities)
        {
            percentageUpCharge += amenity switch
            {
                Amenity.GardenView or Amenity.MountainView => 0.05m,
                Amenity.AirConditioning => 0.03m,
                Amenity.Parking => 0.01m,
                _ => 0
            };
        }

        var amenitiesUpCharge = Money.Zero(currency);

        if (percentageUpCharge > 0)
        {
            amenitiesUpCharge = new Money(
                priceForPeriod.Amount * percentageUpCharge,
                currency);
        }

        var totalPrice = Money.Zero(currency);

        totalPrice += priceForPeriod;

        if (!apartment.CleaningFee.IsZero())
        {
            totalPrice += apartment.CleaningFee;
        }

        totalPrice += amenitiesUpCharge;

        return new PricingDetails(priceForPeriod, apartment.CleaningFee, amenitiesUpCharge, totalPrice);

    }
}