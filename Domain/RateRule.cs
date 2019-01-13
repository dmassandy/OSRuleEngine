using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RateRule : IDomainRule
    {
        // LandPlot
        public int LocationType { get; private set; }
        // Unit
        public int UsageType { get; private set; }
        public int QualityType { get; private set; }
        public int FloorLevel { get; private set; }
        // Building
        public int PlotRatio { get; private set; }
        // Unit
        public bool IsWindow { get; private set; }
        // LandPlot
        public bool IsWaterfront { get; private set; }
        // Product
        public int ProductType { get; private set; }
        public float RateMultiplier { get; private set; }

        public RateRule(int locationType, int usageType, int qualityType, int floorLevel, int plotRatio, bool isWindow, bool isWaterfront, int productType, float rateMultiplier)
        {
            LocationType = locationType;
            UsageType = usageType;
            QualityType = qualityType;
            FloorLevel = floorLevel;
            PlotRatio = plotRatio;
            IsWindow = isWindow;
            IsWaterfront = isWaterfront;
            ProductType = productType;
            RateMultiplier = rateMultiplier;
        }

        public String LocationTypeOp { get; private set; }
        public String UsageTypeOp { get; private set; }
        public String QualityTypeOp { get; private set; }
        public String FloorLevelOp { get; private set; }
        public String PlotRatioOp { get; private set; }
        public String IsWindowOp { get; private set; }
        public String IsWaterfrontOp { get; private set; }
        public String ProductTypeOp { get; private set; }

        public void SetRateRuleCondition(String locationTypeOp, String usageTypeOp, String qualityTypeOp,
            String floorLevelOp, String plotRatioOp, String isWindowOp, String isWaterfrontOp, String productTypeOp)
        {
            LocationTypeOp = locationTypeOp;
            UsageTypeOp = usageTypeOp;
            QualityTypeOp = qualityTypeOp;
            FloorLevelOp = floorLevelOp;
            PlotRatioOp = plotRatioOp;
            IsWindowOp = isWindowOp;
            IsWaterfrontOp = isWaterfrontOp;
            ProductTypeOp = productTypeOp;
        }

    }
}
