using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omni.Base;
using Omni.CommonRules;
using Omni.Products.Treasury;
namespace Omni.Products.Treasury
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
