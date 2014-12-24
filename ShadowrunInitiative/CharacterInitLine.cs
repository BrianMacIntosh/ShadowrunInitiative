using System.Windows.Forms;

namespace ShadowrunInitiative
{
    /// <summary>
    /// A control allowing input of initiative for a turn for a single character.
    /// </summary>
    public partial class CharacterInitLine : UserControl
    {
        Character m_Character;

        public CharacterInitLine(Character character)
        {
            InitializeComponent();

            m_Character = character;
            characterNameLabel.Text = character.Name;
        }

        /// <summary>
        /// Apply the current control settings to the character object.
        /// </summary>
        public void ApplyInit()
        {
            m_Character.Initiative = (int)initiativeNumeric.Value;
            m_Character.Seize = seizeCheckBox.Checked;
        }
    }
}
