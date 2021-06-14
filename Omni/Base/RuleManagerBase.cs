using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omni.Base
{
    public abstract class RuleManagerBase : IRuleManager
    {

        private List<String> _messages = new List<string>();
        private List<IRule> _rules = new List<IRule>();


        public abstract string ProductName { get; }
        public virtual string[] ErrorMassages
        {
            get
            {
                return _messages.ToArray();
            }
        }


        public virtual List<IRule> Rules
        {
            get
            {
                return _rules;
            }
        }


        public virtual void AddRule(IRule rule)
        {
            AddRules(new IRule[] { rule });
        }

        public virtual void AddRules(IRule[] rules)
        {
            _rules.AddRange(rules);
        }

        public virtual bool IsValid(IClient client)
        {
            bool rect = true;
            foreach (var rule in this.Rules)
            {
                if (!rule.Validate(client, null))
                {
                    _messages.Add(rule.ErrorMassage);
                    rect = false;
                }
            }

            return rect;
        }
    }
}
