using System;
using System.Collections.Generic;

namespace COCOMOCalculator.Core
{
    public class COCOMOCalculator
    {
        private COCOMOMode _mode;
        private double[][] COCOMOCoefficients;

        public COCOMOCalculator(COCOMOMode mode)
        {
            this._mode = mode;
            this.initializeCoefficients();
        }

        public double CalculateEffort(int KLOC)
        {
            return this.getCoefficient('a') * (Math.Pow(KLOC, this.getCoefficient('b')));
        }

        public double CalculateTDev(double effort)
        {
            return this.getCoefficient('c') * (Math.Pow(effort, this.getCoefficient('d')));
        }

        public double CalculateEAF(List<double> costDriversValues)
        {
            double result = 1.0;
            foreach (var value in costDriversValues)
            {
                result *= value;
            }

            return result;
        }

        public double CalculateActualEffort(double effort, double EAF)
        {
            return effort * EAF;
        }

        private double getCoefficient(char index)
        {
            return this.COCOMOCoefficients[(int) this._mode][index - 'a'];
        }

        private void initializeCoefficients()
        {
            this.COCOMOCoefficients = new double[][]
            {
                new double[] { 3.2F, 1.05F, 2.5F, 0.38F },
                new double[] { 3.0F, 1.12F, 2.5F, 0.35F },
                new double[] { 2.8F, 1.20F, 2.5F, 0.32F },
            };
        }
    }
}
