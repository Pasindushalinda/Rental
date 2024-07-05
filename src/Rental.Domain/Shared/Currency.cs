namespace Rental.Domain.Shared;

public record Currency
{
    internal static Currency None => new("None");
    public static Currency Usd => new("USD");
    public static Currency Eur => new("EUR");
    public string Code { get; set; }

    private Currency(string code) => Code = code;

    public static Currency FromCode(string code) =>
        Currencies.FirstOrDefault(c => c.Code == code)
        ?? throw new ApplicationException("The currency code is not valid.");

    public static readonly IReadOnlyCollection<Currency> Currencies = new[]
    {
        Usd,
        Eur,
    };
}
