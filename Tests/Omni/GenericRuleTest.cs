using console.Omni;
using console.Products.BankDeposit.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Omni
{
    [TestClass]
    public class GenericRuleTest
    {
        [TestMethod]
        public void EvaluateSucess()
        {
            var client = new Client();
            client.InvestorId = "123213";

            var rule = new GenericRule();

            Assert.IsTrue(rule.Validate(client,null));
        }

        [TestMethod]
        public void EvaluateFailure()
        {
            var client = new Client();
            client.InvestorId = "";

            var exceptedMassage = "Gereric Rule Error";

            var rule = new GenericRule();

            Assert.IsFalse(rule.Validate(client, null));

            Assert.AreEqual(exceptedMassage, rule.ErrorMassage);
        }
    }
}
