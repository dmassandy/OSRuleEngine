using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public LandPlot LandPlot { get; private set; }
        public Building Building { get; private set; }
        public Unit Unit { get; private set; }
        public int ProductType { get; private set; }
        public Rate Rate { get; private set; }


        public Product(LandPlot landPlot, Building building, Unit unit, int productType, Rate rate)
        {
            LandPlot = landPlot;
            Building = building;
            Unit = unit;
            ProductType = productType;
            Rate = rate;
        }

    }
}
