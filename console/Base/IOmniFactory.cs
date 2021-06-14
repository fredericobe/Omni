﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Base
{
    interface IOmniFactory
    {
        IRuleManager GetRuleManager(string type);
        void AddRuleManager(IRuleManager treasuryRuleManager);
    }
}
