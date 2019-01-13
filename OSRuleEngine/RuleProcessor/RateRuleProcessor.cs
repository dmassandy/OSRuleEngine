using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OSRuleEngine.RuleProcessor
{
    public class RateRuleProcessor : IRuleProcessor
    {
        public void ConstructExpressionTree(IDomainRule domainRule)
        {
            // TODO: validate Op for each field in RateRule
            RateRule rateRule = (RateRule)domainRule;

            ParameterExpression landPlotPE = Expression.Parameter(typeof(LandPlot), "landPlot");
            MemberExpression locationTypeME = Expression.Property(landPlotPE, "LocationType");
            ConstantExpression locationTypeCV = Expression.Constant(rateRule.LocationType, typeof(int));
            BinaryExpression locationTypeBody = Common.CreateBinaryExpression(locationTypeME, locationTypeCV, rateRule.LocationTypeOp);
            var locationTypeExprTree = Expression.Lambda<Func<LandPlot, bool>>(locationTypeBody, new[] { landPlotPE });
            Common.DebugExprTree("LandPlot.LocationType", locationTypeExprTree);

            MemberExpression isWaterfrontME = Expression.Property(landPlotPE, "IsWaterfront");
            ConstantExpression isWaterfrontCV = Expression.Constant(rateRule.IsWaterfront, typeof(bool));
            BinaryExpression isWaterfrontBody = Common.CreateBinaryExpression(isWaterfrontME, isWaterfrontCV, rateRule.IsWaterfrontOp);
            var isWaterfrontExprTree = Expression.Lambda<Func<LandPlot, bool>>(isWaterfrontBody, new[] { landPlotPE });
            Common.DebugExprTree("LandPlot.IsWaterfront", isWaterfrontExprTree);

            ParameterExpression unitPE = Expression.Parameter(typeof(Unit), "unit");
            MemberExpression usageTypeME = Expression.Property(unitPE, "UsageType");
            ConstantExpression usageTypeCV = Expression.Constant(rateRule.UsageType, typeof(int));
            BinaryExpression usageTypeBody = Common.CreateBinaryExpression(usageTypeME, usageTypeCV, rateRule.UsageTypeOp);
            var usageTypeExprTree = Expression.Lambda<Func<Unit, bool>>(usageTypeBody, new[] { unitPE });
            Common.DebugExprTree("Unit.UsageType", usageTypeExprTree);

            MemberExpression qualityTypeME = Expression.Property(unitPE, "QualityType");
            ConstantExpression qualityTypeCV = Expression.Constant(rateRule.QualityType, typeof(int));
            BinaryExpression qualityTypeBody = Common.CreateBinaryExpression(qualityTypeME, qualityTypeCV, rateRule.QualityTypeOp);
            var qualityTypeExprTree = Expression.Lambda<Func<Unit, bool>>(qualityTypeBody, new[] { unitPE });
            Common.DebugExprTree("Unit.QualityType", qualityTypeExprTree);

            MemberExpression floorLevelME = Expression.Property(unitPE, "FloorNo");
            ConstantExpression floorLevelCV = Expression.Constant(rateRule.FloorLevel, typeof(int));
            BinaryExpression floorLevelBody = Common.CreateBinaryExpression(floorLevelME, floorLevelCV, rateRule.FloorLevelOp);
            var floorLevelExprTree = Expression.Lambda<Func<Unit, bool>>(floorLevelBody, new[] { unitPE });
            Common.DebugExprTree("Unit.FloorLevel", floorLevelExprTree);

            MemberExpression isWindowME = Expression.Property(unitPE, "IsWindows");
            ConstantExpression isWindowCV = Expression.Constant(rateRule.IsWindow, typeof(bool));
            BinaryExpression isWindowBody = Common.CreateBinaryExpression(isWindowME, isWindowCV, rateRule.IsWindowOp);
            var isWindowExprTree = Expression.Lambda<Func<Unit, bool>>(isWindowBody, new[] { unitPE });
            Common.DebugExprTree("Unit.IsWindow", isWindowExprTree);

            ParameterExpression buildingPE = Expression.Parameter(typeof(Building), "building");
            MemberExpression plotRatioME = Expression.Property(buildingPE, "PlotRatio");
            ConstantExpression plotRatioCV = Expression.Constant(rateRule.PlotRatio, typeof(int));
            BinaryExpression plotRatioBody = Common.CreateBinaryExpression(plotRatioME, plotRatioCV, rateRule.PlotRatioOp);
            var plotRatioExprTree = Expression.Lambda<Func<Building, bool>>(plotRatioBody, new[] { buildingPE });
            Common.DebugExprTree("Building.PlotRatio", plotRatioExprTree);

            ParameterExpression productPE = Expression.Parameter(typeof(Product), "product");
            MemberExpression productTypePE = Expression.Property(productPE, "ProductType");
            ConstantExpression productTypeCV = Expression.Constant(rateRule.ProductType, typeof(int));
            BinaryExpression productTypeBody = Common.CreateBinaryExpression(productTypePE, productTypeCV, rateRule.ProductTypeOp);
            var productTypeExprTree = Expression.Lambda<Func<Product, bool>>(productTypeBody, new[] { productPE });
            Common.DebugExprTree("Product.ProductType", productTypeExprTree);

        }
    }
}
