using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Building
    {

        public LandPlot LandAllocation { get; private set; }
        public String Name { get; private set; }
        public String BlockNumber { get; private set; }
        public String StreetName { get; private set; }
        public String PostalCode { get; private set; }
        public int PlotRatio { get; private set; }
        public int FloorArea { get; private set; }
        public bool IsRampAccess { get; private set; }
        public int RampWeight { get; private set; }
        public int RampLength { get; private set; }
        public int RampHeight { get; private set; }
        public bool IsCarparkAvail { get; private set; }
        public int CarparkLots { get; private set; }
        public DateTime CompletionYear { get; private set; }
        public DateTime StatutoryCompletion { get; private set; }
        public DateTime LastRepairDate { get; private set; }
        public DateTime LastInspection { get; private set; }
        public bool IsCompliance { get; private set; }
        public int GISFeatureID { get; private set; }


        public Building(LandPlot landAllocation, string name, string blockNumber, 
            string streetName, string postalCode, int plotRatio, int floorArea, 
            bool isRampAccess, int rampWeight, int rampLength, int rampHeight, 
            bool isCarparkAvail, int carparkLots, DateTime completionYear, 
            DateTime statutoryCompletion, DateTime lastRepairDate, 
            DateTime lastInspection, bool isCompliance, int gISFeatureID)
        {
            LandAllocation = landAllocation;
            Name = name;
            BlockNumber = blockNumber;
            StreetName = streetName;
            PostalCode = postalCode;
            PlotRatio = plotRatio;
            FloorArea = floorArea;
            IsRampAccess = isRampAccess;
            RampWeight = rampWeight;
            RampLength = rampLength;
            RampHeight = rampHeight;
            IsCarparkAvail = isCarparkAvail;
            CarparkLots = carparkLots;
            CompletionYear = completionYear;
            StatutoryCompletion = statutoryCompletion;
            LastRepairDate = lastRepairDate;
            LastInspection = lastInspection;
            IsCompliance = isCompliance;
            GISFeatureID = gISFeatureID;
        }

    }
}
