
using System.Collections.Generic;

namespace Omni.Base
{
    public interface IRuleManager
    {

        string ProductName { get;}
        string[] ErrorMassages { get;}

        bool IsValid(IClient client);

        void AddRule(IRule rule);

        void AddRules(IRule[] rules);

        List<IRule> Rules { get; }

    }
}