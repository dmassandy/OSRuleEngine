using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OSRuleEngine
{
    interface IRuleProcessor
    {
        void ConstructExpressionTree(IDomainRule domainRule);
    }
}
