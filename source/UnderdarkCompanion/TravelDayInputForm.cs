using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderdarkCompanion
{
    public partial class TravelDayInputForm : Form
    {
        private string forageStatus;
        private string forageDifficulty;
        private string encounterType;

        public TravelDayInputForm(Trip currentTrip)
        {
            InitializeComponent();
            travelerCountBox.Value = currentTrip.NumberOfTravelers;
            paceComboBox.SelectedIndex = paceComboBox.Items.IndexOf(currentTrip.CurrentPace);
        }

        private void PaceChanged(object sender, EventArgs e)
        {
            if(paceComboBox.SelectedItem.ToString() == "Fast")
            {
                forageGroupBox.Enabled = false;
            }
            else
            {
                forageGroupBox.Enabled = true;
            }
        }

        private void ForageStatusChanged(object sender, EventArgs e)
        {
            var selectedStatus = sender as RadioButton;
            forageStatus = selectedStatus.Text;
        }

        private void ForageDifficultyChanged(object sender, EventArgs e)
        {
            var selectedDifficulty = sender as RadioButton;
            forageDifficulty = selectedDifficulty.Text;
        }

        private void EncounterSelectionChanged(object sender, EventArgs e)
        {
            encounterDetailsBox.ReadOnly = encounterNoneRadio.Checked;

            var selectedType = sender as RadioButton;
            encounterType = selectedType.Text;
        }

        public string GetTravelerCount()
        {
            return travelerCountBox.Value.ToString();
        }

        public string GetPace()
        {
            return paceComboBox.SelectedItem.ToString();
        }

        public string GetForcedMarch()
        {
            return forcedMarchYes.Checked ? "Yes" : "No";
        }

        public string GetForageStatus()
        {
            return forageGroupBox.Enabled ? forageStatus : "Impossible(Pace)";
        }

        public string GetForageDifficulty()
        {
            return forageDifficulty;
        }

        public string GetForageRoll()
        {
            return forageRollCountBox.Value.ToString();
        }

        public string GetForageFood()
        {
            return forageFoodCountBox.Value.ToString();
        }

        public string GetForageWater()
        {
            return forageWaterCountBox.Value.ToString();
        }

        public string GetEncounterType()
        {
            return encounterType;
        }

        public string GetEncounterDetails()
        {
            return encounterDetailsBox.ReadOnly ? "" : encounterDetailsBox.Text;
        }
    }
}
