using Omni.Base;
using Omni.Exceptions;
using Omni.Products.Treasury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omni.Factory
{
    public class OmniFactory : IOmniFactory
    {
        private List<IRuleManager> _managers;

        public OmniFactory()
        {
            _managers = new List<IRuleManager>();
        }
        public IRuleManager GetRuleManager(string type)
        {
            return _managers.Find(manager => manager.ProductName.ToLower() == type.ToLower());
        }

        public void AddRuleManager(IRuleManager manager)
        {
            if (GetRuleManager(manager.ProductName)!=null)
            {
                throw new AmbiguosRuleManagerException();
            }
            _managers.Add(manager);
        }
    }
}
