﻿using CurrencyView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyView.Repositories
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<string>> GetCurrencyList();
        Task<decimal> GetLatestRateForCurrency(string currency);
        Task<IEnumerable<CurrencyRate>> GetHistoricalRatesForCurrency(string currency);
    }
}
