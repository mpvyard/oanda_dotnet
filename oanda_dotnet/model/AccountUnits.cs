﻿using System;

namespace oanda_dotnet.model
{
    /// <summary>
    /// The string representation of a quantity of an Account’s home currency.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public class AccountUnits
    {
        private decimal _accountUnits;

        public AccountUnits(string accountUnits)
        {
            _accountUnits = Convert.ToDecimal(accountUnits);
        }

        public static implicit operator AccountUnits(string accountUnits) => new AccountUnits(accountUnits);
        public static implicit operator string(AccountUnits accountUnits) => accountUnits._accountUnits.ToString();
    }
}
