﻿using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> Accounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
