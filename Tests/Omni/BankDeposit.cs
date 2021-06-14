﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using console.CommonRules;

namespace Tests.Omni
{
    [TestClass]
    public class BankDeposit
    {

        private const string productName = "BankDeposit";
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
            Assert.IsInstanceOfType(manager.Rules[0], typeof(GenericRule), "Generic Rule doesnt match");
            Assert.IsInstanceOfType(manager.Rules[1], typeof(ProfileRule), "Profile Rule doesnt match");
        }


        [TestMethod]
        public void Test_If_EvaluateSuccess_CorrectRules_For_BankDeposit()
        {

            var manager = factory.GetRuleManager(productName);
            var client = new Client();
            client.Name = "Client";
            client.InvestorId = "12312312";
            client.Profile = console.Base.ClientProfile.Conservative;
            Assert.IsTrue(manager.IsValid(client));

        }

        [TestMethod]
        public void Test_If_EvaluateFailure_CorrectRules_For_BankDeposit()
        {

            var manager = factory.GetRuleManager(productName);
            var client = new Client();
            client.Name = "Client";


            Assert.IsFalse(manager.IsValid(client));
        }
    }
}