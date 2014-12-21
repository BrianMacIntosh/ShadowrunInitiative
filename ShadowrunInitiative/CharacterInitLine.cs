using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    public partial class CharacterInitLine : UserControl
    {
        Form1.Character m_Character;

        public CharacterInitLine(Form1.Character character)
        {
            InitializeComponent();

            m_Character = character;
            characterNameLabel.Text = character.Name;
        }

        public void ApplyInit()
        {
            m_Character.Initiative = (int)initiativeNumeric.Value;
        }
    }
}
