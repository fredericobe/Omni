using console.Base;

namespace console.Products.Treasury.Rules
{
    public class InvestorRule : IRule
    {
        public string Name { get => "Investor Registered"; }
        public string ErrorMassage { get => "This client is not registered as Investor"; }

        public bool Validate(IClient client, IProduct product)
        {
            return !string.IsNullOrEmpty(client.InvestorId);
        }
    }

}
