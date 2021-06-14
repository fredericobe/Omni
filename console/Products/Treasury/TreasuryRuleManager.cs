using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console.Base;
using console.CommonRules;
using console.Products.Treasury;
namespace console.Products.Treasury
{
    public class TreasuryRuleManager : RuleManagerBase
    {

        public override string ProductName => "Treasury";
        public TreasuryRuleManager()
        {
            this.AddRule(new Rules.InvestorRule());
            this.AddRule(new ProfileRule());
        }


    }
}
