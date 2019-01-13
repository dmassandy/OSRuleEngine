using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Unit
    {

        public Building Building { get; private set; }
        public int NewField { get; private set; }
        public int FloorNo { get; private set; }
        public int FloorMinHeight { get; private set; }
        public int MaxHeight { get; private set; }
        public bool IsColumns { get; private set; }
        public bool IsAircon { get; private set; }
        public bool IsWindows { get; private set; }
        public int QualityType { get; private set; }
        public int UsageType { get; private set; }
        public int OwnershipType { get; private set; }
        public DateTime LeaseCommence { get; private set; }
        public int FloorArea { get; private set; }
        public int VoidArea { get; private set; }
        public int FloorLoading { get; private set; }
        public int ElectricalLoading { get; private set; }
        public bool IsCarparkAvail { get; private set; }
        public int ValuationPrice { get; private set; }
        public DateTime ValudationDate { get; private set; }
        public bool IsWaterAvail { get; private set; }
        public bool UnitType { get; private set; }
        public int GISFeatureID { get; private set; }


        public Unit(Building building, int newField, int floorNo, int floorMinHeight, 
            int maxHeight, bool isColumns, bool isAircon, bool isWindows, 
            int qualityType, int usageType, int ownershipType, DateTime leaseCommence, 
            int floorArea, int voidArea, int floorLoading, int electricalLoading, 
            bool isCarparkAvail, int valuationPrice, DateTime valudationDate, 
            bool isWaterAvail, bool unitType, int gISFeatureID)
        {
            Building = building;
            NewField = newField;
            FloorNo = floorNo;
            FloorMinHeight = floorMinHeight;
            MaxHeight = maxHeight;
            IsColumns = isColumns;
            IsAircon = isAircon;
            IsWindows = isWindows;
            QualityType = qualityType;
            UsageType = usageType;
            OwnershipType = ownershipType;
            LeaseCommence = leaseCommence;
            FloorArea = floorArea;
            VoidArea = voidArea;
            FloorLoading = floorLoading;
            ElectricalLoading = electricalLoading;
            IsCarparkAvail = isCarparkAvail;
            ValuationPrice = valuationPrice;
            ValudationDate = valudationDate;
            IsWaterAvail = isWaterAvail;
            UnitType = unitType;
            GISFeatureID = gISFeatureID;
        }


    }
}
