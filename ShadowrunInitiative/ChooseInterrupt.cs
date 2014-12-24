using System;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    /// <summary>
    /// A form for deducting a custom interrupt value from a character.
    /// </summary>
    public partial class ChooseInterrupt : Form
    {
        public int Value = 0;

        private Character m_ForCharacter;

        public ChooseInterrupt(Character forChar)
        {
            InitializeComponent();

            m_ForCharacter = forChar;
            whoInterruptLabel.Text = "Interrupt: " + forChar.Name;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Value = (int)numericUpDown1.Value;
        }
    }
}
