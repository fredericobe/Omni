using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console.Omni;
using console.Factory;
using console.Products.Treasury;
using console.Exceptions;
using console.Products.BankDeposit.Rules;
using console.Products.BankDeposit;
using console.Products.Treasury.Rules;
using console.CommonRules;
using console.Base;

namespace Tests.Omni
{
    [TestClass]
    public class Treasury
    {

        private const string productName = "Treasury";
        private OmniFactory factory;

        [TestInitialize]
        public void Setup()
        {
            factory = new OmniFactory();
            factory.AddRuleManager(new TreasuryRuleManager());
            factory.AddRuleManager(new BankDepositRuleManager());
        }



        [TestMethod]
        public void Test_If_Runs_CorrectRules_For_BankDeposit()
        {

            var manager = factory.GetRuleManager(productName);
            Assert.AreEqual(2, manager.Rules.Count, "The number of Rules doesnt match");
            Assert.IsInstanceOfType(manager.Rules[0], typeof(InvestorRule), "Investor Rule doesnt match");
            Assert.IsInstanceOfType(manager.Rules[1], typeof(ProfileRule), "Profile Rule doesnt match");
        }


        [TestMethod]
        public void Test_If_EvaluateSuccess_CorrectRules()
        {

            var manager = factory.GetRuleManager(productName);
            var client = new Client();
            client.Name = "Client";
            client.InvestorId = "12312312";
            client.Profile = ClientProfile.Conservative;
            Assert.IsTrue(manager.IsValid(client));

        }

        [TestMethod]
        public void Test_If_EvaluateFailure_CorrectRules()
        {

            var manager = factory.GetRuleManager(productName);
            var client = new Client();
            client.Name = "Client";


            Assert.IsFalse(manager.IsValid(client));
        }
    }
}
