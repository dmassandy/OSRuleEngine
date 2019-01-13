using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Allocation
    {

        public Contract Contract { get; private set; }
        public Product Product { get; private set; }
        public Company Company { get; private set; }
        public bool Status { get; private set; }
        public String Restrictions { get; private set; }
        public DateTime HandoverDate { get; private set; }
        public DateTime Commencement { get; private set; }
        public int Repossession { get; private set; }
        public int AllocatedFloorArea { get; private set; }
        public String Usage { get; private set; }
        public bool SubletAllow { get; private set; }

        public Allocation(Contract contract, Product product, Company company,
            bool status, string restrictions, DateTime handoverDate,
            DateTime commencement, int repossession, int allocatedFloorArea, string usage, bool subletAllow)
        {
            Contract = contract;
            Product = product;
            Company = company;
            Status = status;
            Restrictions = restrictions;
            HandoverDate = handoverDate;
            Commencement = commencement;
            Repossession = repossession;
            AllocatedFloorArea = allocatedFloorArea;
            Usage = usage;
            SubletAllow = subletAllow;
        }
    }
}
