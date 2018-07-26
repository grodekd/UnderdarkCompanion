using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UnderdarkCompanion
{
    public class Log
    {
        private XmlDocument dataXml;
        private string logFilePath;

        public Log()
        {
            dataXml = new XmlDocument();
            ImportOrCreateLog();
        }

        private void ImportOrCreateLog()
        {
            SetLogFilePath();
            if (File.Exists(logFilePath))
            {
                dataXml.LoadXml(File.ReadAllText(logFilePath));
            }
            else
            {
                dataXml.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<log>\r\n</log>");
            }
        }

        private void SetLogFilePath()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logFilePath = saveFileDialog.FileName;
            }
        }

        public void LogDay(string message)
        {
            var dayNode = dataXml.CreateElement("day");
            dayNode.InnerText = message;

            var node = dataXml.DocumentElement;
            node.AppendChild(dayNode);

            dataXml.Save(logFilePath);
        }

        public void LogTravelDay(Trip currentTrip)
        {
            var travelDayInput = new TravelDayInputForm(currentTrip);
            var result = travelDayInput.ShowDialog();

            if(result != DialogResult.OK)
            {
                return;
            }

            var dayNode = dataXml.CreateElement("travelDay");

            var travelersNode = dataXml.CreateElement("travelers");
            travelersNode.InnerText = travelDayInput.GetTravelerCount();
            dayNode.AppendChild(travelersNode);

            var paceNode = dataXml.CreateElement("pace");
            paceNode.InnerText = travelDayInput.GetPace();
            dayNode.AppendChild(paceNode);

            var forageNode = dataXml.CreateElement("forage");

            var forageStatusNode = dataXml.CreateElement("status");
            forageStatusNode.InnerText = travelDayInput.GetForageStatus();
            forageNode.AppendChild(forageStatusNode);

            var forageRollNode = dataXml.CreateElement("roll");
            forageRollNode.InnerText = travelDayInput.GetForageRoll();
            var forageDifficultyAttr = dataXml.CreateAttribute("difficulty");
            forageDifficultyAttr.Value = travelDayInput.GetForageDifficulty();
            forageRollNode.SetAttributeNode(forageDifficultyAttr);
            forageNode.AppendChild(forageRollNode);

            var forageFoodNode = dataXml.CreateElement("food");
            forageFoodNode.InnerText = travelDayInput.GetForageFood();
            forageNode.AppendChild(forageFoodNode);

            var forageWaterNode = dataXml.CreateElement("food");
            forageWaterNode.InnerText = travelDayInput.GetForageWater();
            forageNode.AppendChild(forageWaterNode);

            dayNode.AppendChild(forageNode);

            var forcedMarchNode = dataXml.CreateElement("forcedMarch");
            forcedMarchNode.InnerText = travelDayInput.GetForcedMarch();
            dayNode.AppendChild(forcedMarchNode);

            var encounterNode = dataXml.CreateElement("encounter");
            encounterNode.InnerText = travelDayInput.GetEncounterDetails();
            var encounterTypeAttr = dataXml.CreateAttribute("type");
            encounterTypeAttr.Value = travelDayInput.GetEncounterType();
            encounterNode.SetAttributeNode(encounterTypeAttr);
            dayNode.AppendChild(encounterNode);

            var baseNode = dataXml.DocumentElement;
            baseNode.AppendChild(dayNode);

            dataXml.Save(logFilePath);
        }
    }
}
