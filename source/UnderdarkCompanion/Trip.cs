using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderdarkCompanion
{
    public class Trip
    {
        private int milesRemaining;
        private bool unknownDestination;

        private Dictionary<string, double> paceLookup = new Dictionary<string, double> { { "Slow", 4.0 }, { "Normal", 6.0 }, { "Fast", 8.0 } };

        public Trip(string outset, string destination)
            :this(outset, destination, 0, LocationDictionary.GetMilesBetween(outset, destination))
        {
        }

        public Trip(string outset, string destination, int daysTraveled, int milesRemaining)
        {
            Outset = outset;
            Destination = destination;
            CurrentPace = "Normal";
            DaysTraveled = daysTraveled;
            NumberOfTravelers = 8;
            FoodCount = 50;
            WaterCount = 50;
            this.milesRemaining = milesRemaining;

            if(destination == "???")
            {
                unknownDestination = true;
            }
        }



        public string Outset { get; private set; }

        public string Destination { get; private set; }

        public int DaysTraveled { get; private set; }

        public string CurrentPace { get; set; }

        public int NumberOfTravelers { get; set; }

        public int FoodCount { get; set; }

        public int WaterCount { get; set; }

        public string GetEta()
        {
            return unknownDestination ? "???" : string.Format("{0} days", CalculateDaysRemaining());
        }

        private int CalculateDaysRemaining()
        {
            return (int)Math.Ceiling(milesRemaining / paceLookup[CurrentPace]);
        }

        public string GetDaysOfFoodRemaining()
        {
            var daysOfFoodRemaining = FoodCount / NumberOfTravelers;
            return string.Format("({0} days)", daysOfFoodRemaining);
        }

        public string GetDaysOfWaterRemaining()
        {
            var daysOfWaterRemaining = WaterCount / NumberOfTravelers;
            return string.Format("({0} days)", daysOfWaterRemaining);
        }

        public void Travel(int days)
        {
            DaysTraveled += days;
            milesRemaining -= (int)(paceLookup[CurrentPace] * days);

            FoodCount -= (NumberOfTravelers * days);
            WaterCount -= (NumberOfTravelers * days);
        }

        public void BuildSaveData(TripSaveData saveData)
        {
            saveData.AddTripStart();
            saveData.AddDestination(Destination);
            saveData.AddOutset(Outset);
            saveData.AddDaysTraveled(DaysTraveled);
            saveData.AddMilesRemaining(milesRemaining);
            saveData.AddPace(CurrentPace);
            saveData.AddFood(FoodCount);
            saveData.AddWater(WaterCount);
            saveData.AddTripEnd();
        }
    }
}
