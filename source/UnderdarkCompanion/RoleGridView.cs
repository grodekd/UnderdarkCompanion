using System.Linq;
using System.Windows.Forms;

namespace UnderdarkCompanion
{
    class RoleGridView : DataGridView
    {
        public RoleGridView()
            : base()
        {

        }

        public void AddCharacter(Character character, int roleIndex)
        {
            if(!CharacterExistsInGrid(character.Name))
            {
                Rows.Add(character.Name, character.GetRollString(roleIndex));
            }
        }
        
        private bool CharacterExistsInGrid(string name)
        {
            return Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value != null && x.Cells[0].Value.ToString() == name).Any();
        }

        public void RemoveCharacter(Character character)
        {
            if (CharacterExistsInGrid(character.Name))
            {
                Rows.RemoveAt(GetCharacterRowIndex(character.Name));
            }
        }

        private int GetCharacterRowIndex(string name)
        {
            return Rows.Cast<DataGridViewRow>().First(x => x.Cells[0].Value.ToString() == name).Index;
        }
    }
}
