using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omni.Products.BankDeposit;
using Omni.Base;
using Omni.CommonRules;

namespace Omni.Products.BankDeposit
{
    public class BankDepositRuleManager : RuleManagerBase
    {

        public override string ProductName => "BankDeposit";
        public BankDepositRuleManager()
        {
            this.AddRule(new Rules.GenericRule());
            this.AddRule(new ProfileRule());
        }
        
        
    }
}
