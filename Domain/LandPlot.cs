using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LandPlot
    {
        public String LandDescription { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime LeaseStart { get; private set; }
        public DateTime LeaseEnd { get; private set; }
        public int GISFeatureID { get; private set; }
        public int LeaseType { get; private set; }
        public int LocationType { get; private set; }
        public bool IsWaterfront { get; private set; }



        public LandPlot(string landDescription, bool isActive, DateTime leaseStart, DateTime leaseEnd, int gISFeatureID, int leaseType, int locationType, bool isWaterfront)
        {
            LandDescription = landDescription;
            IsActive = isActive;
            LeaseStart = leaseStart;
            LeaseEnd = leaseEnd;
            GISFeatureID = gISFeatureID;
            LeaseType = leaseType;
            LocationType = locationType;
            IsWaterfront = isWaterfront;
        }




    }
}
