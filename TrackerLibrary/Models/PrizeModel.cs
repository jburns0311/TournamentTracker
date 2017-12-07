using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class PrizeModel
    {
        public int PrizeId { get; set; }
        /// <summary>
        /// The Plaze id: 1, 2, ...
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The Actual Place name: 1st Place, 2nd Place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The amount rewarded to the receipt of the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The amount of the total prize they receive
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        //With this constructor we have taken these string parameters 
        //and parse them into their corresponding properties
        //The logic is we take in "Valid Form Information" as a string that 

       
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int PlaceNumberValue = 0;
            int.TryParse(placeNumber, out PlaceNumberValue);
            PlaceNumber = PlaceNumberValue;

            decimal PrizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out PrizeAmountValue);
            PrizeAmount = PrizeAmountValue;

            double PrizePercentageValue = 0;
            double.TryParse(prizePercentage, out PrizePercentageValue);
            PrizePercentage = PrizePercentageValue;
        }
    }
}
