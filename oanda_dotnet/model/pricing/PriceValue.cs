﻿namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The string representation of a Price for an Instrument.
    /// </summary>
    public class PriceValue
    {
        private DecimalNumber _priceValue;

        public static implicit operator PriceValue(string priceValue)
        {
            return new PriceValue()
            {
                _priceValue = priceValue
            };
        }

        public static implicit operator string(PriceValue priceValue)
        {
            return priceValue._priceValue;
        }
    }
}