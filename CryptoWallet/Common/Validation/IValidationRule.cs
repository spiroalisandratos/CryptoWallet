using System;
namespace CryptoWallet.Common.Validation
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }

        bool Check(T value);
    }
}
