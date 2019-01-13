using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UsedRule
    {
        public Rate Rate { get; private set; }
        public RateRule RateRule { get; private set; }

        public UsedRule()
        {

        }

        public void SetRuleResult(Rate rate, RateRule rateRule)
        {
            Rate = rate;
            RateRule = rateRule;
        }
    }
}
