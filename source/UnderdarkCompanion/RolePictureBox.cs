using System.Windows.Forms;

namespace UnderdarkCompanion
{
    class RolePictureBox : PictureBox
    {
        public RolePictureBox()
        {
            RoleIndex = 0;
        }

        public Label RoleLabel { get; set; }

        public int RoleIndex { get; set; }

        public Label CharacterNameLabel { get; set; }
    }
}
