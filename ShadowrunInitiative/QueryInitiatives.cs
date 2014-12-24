using System.Collections.Generic;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    /// <summary>
    /// A form for inputting new initiative values at the start of turn.
    /// </summary>
    public partial class QueryInitiatives : Form
    {
        public QueryInitiatives(IEnumerable<Character> characters)
        {
            InitializeComponent();

            foreach (Character character in characters)
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
