using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rate
    {

        public DateTime EffectiveDate { get; private set; }
        public int FrequencyType { get; private set; }
        public int RentPrice { get; private set; }
        public int AirconPrice { get; private set; }
        public int RefurbishPrice { get; private set; }
        public int MaintPrice { get; private set; }


        public Rate(DateTime effectiveDate, int frequencyType, int rentPrice, int airconPrice, int refurbishPrice, int maintPrice)
        {
            EffectiveDate = effectiveDate;
            FrequencyType = frequencyType;
            RentPrice = rentPrice;
            AirconPrice = airconPrice;
            RefurbishPrice = refurbishPrice;
            MaintPrice = maintPrice;
        }
    }
}
