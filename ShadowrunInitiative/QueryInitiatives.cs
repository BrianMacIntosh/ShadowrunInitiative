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
    public partial class QueryInitiatives : Form
    {
        public QueryInitiatives(IEnumerable<Form1.Character> characters)
        {
            InitializeComponent();

            foreach (Form1.Character character in characters)
            {
                if (!character.Incapacitated)
                    initiativeRowPanel.Controls.Add(new CharacterInitLine(character));
            }
        }

        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                foreach (Control control in initiativeRowPanel.Controls)
                {
                    if (control is CharacterInitLine)
                    {
                        ((CharacterInitLine)control).ApplyInit();
                    }
                }
            }
        }
    }
}
