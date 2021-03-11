using System;
namespace CryptoWallet.Common.Validation
{
    public class NonNegativeRule : IValidationRule<decimal>
    {
        public NonNegativeRule()
        {
        }

        public string ValidationMessage { get; set; }

        public bool Check(decimal value)
        {
            return value > 0;
        }
    }
}
