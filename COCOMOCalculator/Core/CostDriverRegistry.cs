using System.Collections.Generic;
using System.Linq;

namespace COCOMOCalculator.Core
{
    public class CostDriverRegistry
    {
        private Dictionary<string, CostDriver> _registry;

        public CostDriverRegistry()
        {
            this.loadRegistry();
        }

        public CostDriver GetCostDriver(string name)
        {
            return this._registry[name];
        }

        public List<CostDriver> GetAllCostDrivers()
        {
            return this._registry.Values.ToList();
        }

        private void loadRegistry()
        {
            this._registry = new Dictionary<string, CostDriver>()
            {
                /* Product Attributes */
                {
                    "Required software reliability",
                    new CostDriver(
                        "Required software reliability",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 0.75 },
                            { CostDriverRating.LOW, 0.88 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.15 },
                            { CostDriverRating.VERY_HIGH, 1.40 },
                        })
                },
                {
                    "Size of application database",
                    new CostDriver(
                        "Size of application database",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.LOW, 0.94 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.08 },
                            { CostDriverRating.VERY_HIGH, 1.16 },
                        })
                },
                {
                    "Complexity of the product",
                    new CostDriver(
                        "Complexity of the product",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 0.70 },
                            { CostDriverRating.LOW, 0.85 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.15 },
                            { CostDriverRating.VERY_HIGH, 1.30 },
                            { CostDriverRating.EXTRA_HIGH, 1.65 },
                        })
                },


                /* Hardware Attributes */
                {
                    "Run-time performance constraints",
                    new CostDriver(
                        "Run-time performance constraints",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.11 },
                            { CostDriverRating.VERY_HIGH, 1.30 },
                            { CostDriverRating.EXTRA_HIGH, 1.66 },
                        })
                },
                {
                    "Memory constraints",
                    new CostDriver(
                        "Memory constraints",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.06 },
                            { CostDriverRating.VERY_HIGH, 1.21 },
                            { CostDriverRating.EXTRA_HIGH, 1.56 },
                        })
                },
                {
                    "Volatility of virtual machine environment",
                    new CostDriver(
                        "Volatility of virtual machine environment",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.LOW, 0.87 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.15 },
                            { CostDriverRating.VERY_HIGH, 1.30 },
                        })
                },
                {
                    "Required turnabout time",
                    new CostDriver(
                        "Required turnabout time",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.LOW, 0.87 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.07 },
                            { CostDriverRating.VERY_HIGH, 1.15 },
                        })
                },


                /* Personnel Attributes */
                {
                    "Analyst capability",
                    new CostDriver(
                        "Analyst capability",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.46 },
                            { CostDriverRating.LOW, 1.19 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.86 },
                            { CostDriverRating.VERY_HIGH, 0.71 },
                        })
                },
                {
                    "Applications experience",
                    new CostDriver(
                        "Applications experience",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.29 },
                            { CostDriverRating.LOW, 1.13 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.91 },
                            { CostDriverRating.VERY_HIGH, 0.82 },
                        })
                },
                {
                    "Software engineer capability",
                    new CostDriver(
                        "Software engineer capability",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.42 },
                            { CostDriverRating.LOW, 1.17 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.86 },
                            { CostDriverRating.VERY_HIGH, 0.70 },
                        })
                },
                {
                    "Virtual machine experience",
                    new CostDriver(
                        "Virtual machine experience",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.21 },
                            { CostDriverRating.LOW, 1.10 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.90 },
                        })
                },
                {
                    "Programming language experience",
                    new CostDriver(
                        "Programming language experience",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.14 },
                            { CostDriverRating.LOW, 1.07 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.95 },
                        })
                },


                /* Project Attributes */
                {
                    "Application of software engineering methods",
                    new CostDriver(
                        "Application of software engineering methods",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.24 },
                            { CostDriverRating.LOW, 1.10 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.91 },
                            { CostDriverRating.EXTRA_HIGH, 0.82 },
                        })
                },
                {
                    "Use of sofware tools",
                    new CostDriver(
                        "Use of sofware tools",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.24 },
                            { CostDriverRating.LOW, 1.10 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 0.91 },
                            { CostDriverRating.EXTRA_HIGH, 0.83 },
                        })
                },
                 {
                    "Required development schedule",
                    new CostDriver(
                        "Required development schedule",
                        new Dictionary<CostDriverRating, double>()
                        {
                            { CostDriverRating.VERY_LOW, 1.23 },
                            { CostDriverRating.LOW, 1.08 },
                            { CostDriverRating.NOMINAL, 1.0 },
                            { CostDriverRating.HIGH, 1.04 },
                            { CostDriverRating.EXTRA_HIGH, 1.10 },
                        })
                },
            };

        }

    }
}
