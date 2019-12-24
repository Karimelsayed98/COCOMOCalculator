using System.Collections.Generic;
using System.Linq;

namespace COCOMOCalculator.Core
{
    public class CostDriver
    {
        public string Name;
        public Dictionary<CostDriverRating, double> RatingValue;

        public CostDriver(string Name, Dictionary<CostDriverRating, double> RatingValue)
        {
            this.Name = Name;
            this.RatingValue = RatingValue;
        }

        public List<CostDriverRating> GetRatings()
        {
            return this.RatingValue.Keys.ToList();
        }
    }
}
