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
    public partial class UnderdarkCompanionForm : Form
    {
        public UnderdarkCompanionForm()
        {
            InitializeComponent();

            var controller = new ControlForm(this);
            controller.Show();
        }

        public void SetOutset(string outset)
        {
            outsetLabel.Text = outset;
        }

        public void SetDestination(string destination)
        {
            destinationLabel.Text = destination;
        }

        public void SetDaysTraveled(string daysTraveled)
        {
            daysTraveledLabel.Text = daysTraveled;
        }

        public void SetEta(string eta)
        {
            etaLabel.Text = eta;
        }

        public void SetPace(string pace)
        {
            paceLabel.Text = pace;
        }

        public void SetFoodCount(string foodCount)
        {
            foodCountLabel.Text = foodCount;
        }

        public void SetWaterCount(string waterCount)
        {
            waterCountLabel.Text = waterCount;
        }

        public void SetDaysOfFoodRemaining(string foodDays)
        {
            daysOfFoodLabel.Text = foodDays;
        }

        public void SetDaysOfWaterRemaining(string waterDays)
        {
            daysOfWaterLabel.Text = waterDays;
        }
    }
}
