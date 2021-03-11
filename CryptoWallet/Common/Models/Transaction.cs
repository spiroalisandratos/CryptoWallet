﻿using System;
using CryptoWallet.Common.Database;

namespace CryptoWallet.Common.Models
{
    public class Transaction : BaseDatabaseItem
    {
        public string Symbol { get; set; }
        public decimal Amount { get; set; }
        public decimal DollarValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
        public string StatusImageSource { get; set; }
        public string UserEmail { get; set; }
    }
}
