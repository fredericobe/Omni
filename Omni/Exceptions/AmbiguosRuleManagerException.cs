using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omni.Exceptions
{
    public class AmbiguosRuleManagerException:Exception
    {

        public AmbiguosRuleManagerException(): base("You cannot use more than one RuleManager with same ProductName")
        {

        }

        public AmbiguosRuleManagerException(string massage) : base(massage)
        {

        }
    }
}
