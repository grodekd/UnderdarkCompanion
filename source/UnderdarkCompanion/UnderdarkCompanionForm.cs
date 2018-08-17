using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UnderdarkCompanion
{
    public partial class UnderdarkCompanionForm : Form
    {
        private List<Character> characters = new List<Character>();

        private Dictionary<Role, RoleGridView> roleGridLookup;

        public UnderdarkCompanionForm()
        {
            InitializeComponent();
            InitializeCharacters();

            roleGridLookup = new Dictionary<Role, RoleGridView>
            {
                { Role.Navigating, navigatingGrid }, { Role.Foraging, foragingGrid }, { Role.Scouting, scoutingGrid }, { Role.Covering, coveringGrid }
            };

            var controller = new ControlForm(this);
            controller.Show();
        }

        private void InitializeCharacters()
        {
            var newCharacter = new Character("Bierek Zoomzeros", 6, 6, 4, 2);
            characters.Add(newCharacter);
            navigatingGrid.AddCharacter(newCharacter, (int)Role.Navigating);

            newCharacter = new Character("Dorian Grimlock", 0, 2, 0, 0);
            characters.Add(newCharacter);
            navigatingGrid.AddCharacter(newCharacter, (int)Role.Navigating);

            newCharacter = new Character("Selice", 2, 2, 2, 4);
            characters.Add(newCharacter);

            newCharacter = new Character("Shadow", 3, 3, 3, 1);
            characters.Add(newCharacter);

            newCharacter = new Character("Vera Brawnen", 1, 1, 1, 5);
            characters.Add(newCharacter);

            newCharacter = new Character("Eldeth Feldrun", 1, 1, 1, 1);
            characters.Add(newCharacter);

            newCharacter = new Character("Prince Derendil", 2, 2, 2, 2);
            characters.Add(newCharacter);

            newCharacter = new Character("Sarith Kzekarit", 3, 3, 3, 3);
            characters.Add(newCharacter);
        }

        public void SetDestination(string destination)
        {
            destinationLabel.Text = destination;
        }

        public void SetOutset(string outset)
        {
            outsetLabel.Text = outset;
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

        public void ChangeRole(object sender, EventArgs e)
        {
            var pictureBox = sender as RolePictureBox;
            var character = characters.First(cha => cha.Name == pictureBox.CharacterNameLabel.Text);

            roleGridLookup[(Role)pictureBox.RoleIndex].RemoveCharacter(character);
            
            pictureBox.RoleIndex = DetermineNextRoleIndex(pictureBox.RoleIndex);
            pictureBox.RoleLabel.Text = ((Role)pictureBox.RoleIndex).ToString();
            pictureBox.Image = GetImageForRole(pictureBox.RoleLabel.Text);

            roleGridLookup[(Role)pictureBox.RoleIndex].AddCharacter(character, pictureBox.RoleIndex);
        }

        private int DetermineNextRoleIndex(int currentRoleIndex)
        {
            return currentRoleIndex == 3 ? 0 : currentRoleIndex + 1;
        }

        private Image GetImageForRole(string role)
        {
            var imagePath = string.Format("..\\..\\Images\\{0}.bmp", role);
            return Image.FromFile(imagePath);
        }

        private enum Role
        {
            Navigating = 0,
            Foraging = 1,
            Scouting = 2,
            Covering = 3
        }
    }
}
