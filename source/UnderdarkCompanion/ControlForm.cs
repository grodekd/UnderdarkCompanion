using System;
using System.Windows.Forms;

namespace UnderdarkCompanion
{
    public partial class ControlForm : Form
    {
        private UnderdarkCompanionForm companionForm;
        private Trip currentTrip;
        private Log log;
        public ControlForm(UnderdarkCompanionForm form)
        {
            InitializeComponent();

            companionForm = form;

            foreach (var location in LocationDictionary.GetLocationNames())
            {
                outsetComboBox.Items.Add(location);
                destinationComboBox.Items.Add(location);
            }
        }

        private void SetDestination(object sender, EventArgs e)
        {
            var outset = outsetComboBox.SelectedItem.ToString();
            var destination = destinationComboBox.SelectedItem.ToString();

            currentTrip = new Trip(outset, destination);

            companionForm.SetOutset(currentTrip.Outset);
            companionForm.SetDestination(currentTrip.Destination);
            companionForm.SetEta(currentTrip.GetEta());
            SetDaysOfSuppliesRemaining();
        }

        private void SetPace(object sender, EventArgs e)
        {
            var newPace = paceComboBox.SelectedItem.ToString();

            currentTrip.CurrentPace = newPace;

            companionForm.SetPace(currentTrip.CurrentPace);
            companionForm.SetEta(currentTrip.GetEta());
        }

        private void Travel(object sender, EventArgs e)
        {
            currentTrip.Travel((int)daysToTravelInput.Value);
            UpdateTravelDataOnForm();
            log.LogTravelDay(currentTrip);
        }

        private void UpdateTravelDataOnForm()
        {
            companionForm.SetDaysTraveled(currentTrip.DaysTraveled.ToString());
            companionForm.SetEta(currentTrip.GetEta());
            companionForm.SetFoodCount(currentTrip.FoodCount.ToString());
            companionForm.SetWaterCount(currentTrip.WaterCount.ToString());
            SetDaysOfSuppliesRemaining();
        }

        private void SetDaysOfSuppliesRemaining()
        {
            companionForm.SetDaysOfFoodRemaining(currentTrip.GetDaysOfFoodRemaining());
            companionForm.SetDaysOfWaterRemaining(currentTrip.GetDaysOfWaterRemaining());
        }

        private void AddFood(object sender, EventArgs e)
        {
            currentTrip.FoodCount += (int)addFoodInput.Value;
            companionForm.SetFoodCount(currentTrip.FoodCount.ToString());
            SetDaysOfSuppliesRemaining();
        }

        private void AddWater(object sender, EventArgs e)
        {
            currentTrip.WaterCount += (int)addWaterInput.Value;
            companionForm.SetWaterCount(currentTrip.WaterCount.ToString());
            SetDaysOfSuppliesRemaining();
        }

        private void SaveTrip(object sender, EventArgs e)
        {
            var saveData = new TripSaveData();
            currentTrip.BuildSaveData(saveData);
            saveData.SaveTrip();
        }

        private void LoadTrip(object sender, EventArgs e)
        {
            var saveData = new TripSaveData();
            currentTrip = saveData.LoadTrip();
            UpdateAllTripDataOnForm();
        }

        private void UpdateAllTripDataOnForm()
        {
            companionForm.SetOutset(currentTrip.Outset);
            companionForm.SetDestination(currentTrip.Destination);
            companionForm.SetPace(currentTrip.CurrentPace);
            UpdateTravelDataOnForm();
        }

        private void SetLog(object sender, EventArgs e)
        {
            log = new Log();
        }
    }
}
