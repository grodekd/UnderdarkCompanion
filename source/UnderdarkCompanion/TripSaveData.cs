using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace UnderdarkCompanion
{
    public class TripSaveData
    {
        private XmlDocument dataXml;
        private string dataString;

        public TripSaveData()
        {
            dataXml = new XmlDocument();
            dataString = "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>\r\n";
        }

        public void AddTripStart()
        {
            dataString += "<trip>\r\n";
        }

        public void AddTripEnd()
        {
            dataString += "</trip>";
        }

        public void AddDestination(string destination)
        {
            dataString += string.Format("\t<destination>{0}</destination>\r\n", destination);
        }

        public void AddOutset(string outset)
        {
            dataString += string.Format("\t<outset>{0}</outset>\r\n", outset);
        }

        public void AddDaysTraveled(int daysTraveled)
        {
            dataString += string.Format("\t<days>{0}</days>\r\n", daysTraveled);
        }

        public void AddMilesRemaining(int miles)
        {
            dataString += string.Format("\t<miles>{0}</miles>\r\n", miles);
        }

        public void AddPace(string pace)
        {
            dataString += string.Format("\t<pace>{0}</pace>\r\n", pace);
        }

        public void AddFood(int foodCount)
        {
            dataString += string.Format("\t<food>{0}</food>\r\n", foodCount);
        }

        public void AddWater(int waterCount)
        {
            dataString += string.Format("\t<water>{0}</water>\r\n", waterCount);
        }

        public void SaveTrip()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(dataString);
                }
            }
        }

        public Trip LoadTrip()
        {
            LoadTripData();
            var loadedTrip = CreateTripFromXml();

            loadedTrip.CurrentPace = dataXml.SelectSingleNode("//trip/pace").InnerText;
            loadedTrip.FoodCount = Convert.ToInt32(dataXml.SelectSingleNode("//trip/food").InnerText);
            loadedTrip.WaterCount = Convert.ToInt32(dataXml.SelectSingleNode("//trip/water").InnerText);

            return loadedTrip;
        }


        private void LoadTripData()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataXml.LoadXml(File.ReadAllText(openFileDialog.FileName));
            }
        }

        private Trip CreateTripFromXml()
        {
            var destination = dataXml.SelectSingleNode("//trip/destination").InnerText;
            var outset = dataXml.SelectSingleNode("//trip/outset").InnerText;
            var daysTraveled = dataXml.SelectSingleNode("//trip/days").InnerText;
            var milesRemaining = dataXml.SelectSingleNode("//trip/miles").InnerText;
            return new Trip(outset, destination, Convert.ToInt32(daysTraveled), Convert.ToInt32(milesRemaining));
        }
    }
}
