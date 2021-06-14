using Omni.Base;

namespace Omni.Products.BankDeposit.Rules
{
    public class GenericRule : IRule
    {
        public string Name { get => "Generic Rule"; }
        public string ErrorMassage { get => "Gereric Rule Error"; }

        public bool Validate(IClient client, IProduct product)
        {
            return !string.IsNullOrEmpty(client.InvestorId);
        }
    }

}
