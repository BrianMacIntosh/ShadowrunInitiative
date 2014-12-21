using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    public partial class ChooseInterrupt : Form
    {
        public int Value = 0;

        private Form1.Character m_ForCharacter;

        public ChooseInterrupt(Form1.Character forChar)
        {
            InitializeComponent();

            m_ForCharacter = forChar;
            whoInterruptLabel.Text = "Interrupt: " + forChar.Name;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Value = (int)numericUpDown1.Value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
