﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public interface IBank
    {
        string Withdraw();
        string Deposit();
    }
}
