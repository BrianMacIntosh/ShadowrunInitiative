using System;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    /// <summary>
    /// Form for creating a new Character object.
    /// </summary>
    public partial class NewCharacter : Form
    {
        public Character Character;

        public NewCharacter()
        {
            InitializeComponent();

            Character = new Character();
            okButton.Enabled = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Character.Name = nameTextBox.Text;
            okButton.Enabled = !string.IsNullOrWhiteSpace(Character.Name);
        }

        private void pcCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Character.PC = pcCheckbox.Checked;
        }

        private void edgeNumeric_ValueChanged(object sender, EventArgs e)
        {
            Character.Edge = (int)edgeNumeric.Value;
        }

        private void reactNumeric_ValueChanged(object sender, EventArgs e)
        {
            Character.Reaction = (int)reactNumeric.Value;
        }

        private void intuitNumeric_ValueChanged(object sender, EventArgs e)
        {
            Character.Intuition = (int)intuitNumeric.Value;
        }
    }
}
