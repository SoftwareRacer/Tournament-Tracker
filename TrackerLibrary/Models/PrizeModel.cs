using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique Id of a Prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represents the place where you get the prize as a number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place where you get the prize as a written statement
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize as an absolut value
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage the prize is part oh the whole
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
                
        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
