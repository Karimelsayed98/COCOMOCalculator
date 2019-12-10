namespace COCOMOCalculator.Core
{
    public class COCOMOCalculator
    {
        private COCOMOMode _mode;
        private float[][] COCOMOCoefficients;

        public COCOMOCalculator(COCOMOMode mode)
        {
            this._mode = mode;
            this.initializeCoefficients();
        }

        public float CalculateEffort(int KLOC)
        {
            throw new System.Exception("Not Implemented");
        }

        private void initializeCoefficients()
        {
        }
    }
}
