using Omni.Exceptions;
using Omni.Factory;
using Omni.Products.Treasury;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Omni
{
    [TestClass]
    public class Factory
    {

        [TestMethod, ExpectedException(typeof(AmbiguosRuleManagerException))]
        public void Test_If_Multiple_RuleManager_With_Same_Name()
        {
            var factory = new OmniFactory();
            factory.AddRuleManager(new TreasuryRuleManager());
            factory.AddRuleManager(new TreasuryRuleManager());


        }
    }





}
