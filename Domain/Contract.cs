using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contract
    {
        public int ContractStatus { get; private set; }
        public String No { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Contract(int contractStatus, string no, DateTime startDate, DateTime endDate)
        {
            ContractStatus = contractStatus;
            No = no;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
