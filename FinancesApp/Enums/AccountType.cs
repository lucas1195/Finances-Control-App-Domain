﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Enums
{
    /// <summary>
    /// Represents the type of an account.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Represents a debit account.
        /// </summary>
        Debit = 0,

        /// <summary>
        /// Represents a credit account.
        /// </summary>
        Credit = 1
    }
}
