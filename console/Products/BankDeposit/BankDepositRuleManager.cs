using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console.Products.BankDeposit;
using console.Base;
using console.CommonRules;

namespace console.Products.BankDeposit
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
