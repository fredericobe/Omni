using console.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.CommonRules
{
    public class ProfileRule : IRule
    {
        public string Name => "ProfileRule";

        public string ErrorMassage => "Client Profile is not respected";

        public bool Validate(IClient client, IProduct product)
        {
            //Simple test to simulate the rule. 
            // in real life this method should be more complex, with a lot of http request, for instance
            return client.Profile == ClientProfile.Conservative;
        }
    }
}
