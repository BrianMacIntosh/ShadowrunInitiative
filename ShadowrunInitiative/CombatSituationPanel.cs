using System;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    /// <summary>
    /// A control for selecting a combat situation.
    /// </summary>
    public partial class CombatSituationPanel : UserControl
    {
        public CombatSituation Situation
        {
            get { return m_Situation; }
            set
            {
                m_Situation = value;
                switch (m_Situation)
                {
                    case CombatSituation.PHYSICAL:
                        physicalRadioButton.Checked = true;
                        break;
                    case CombatSituation.ASTRAL:
                        astralRadioButton.Checked = true;
                        break;
                    case CombatSituation.MATRIX:
                        matrixRadioButton.Checked = true;
                        break;
                }
                if (OnCombatSituationChanged != null)
                    OnCombatSituationChanged(this, null);
            }
        }

        private CombatSituation m_Situation;

        public event EventHandler OnCombatSituationChanged;


        public CombatSituationPanel()
        {
            InitializeComponent();

            Situation = CombatSituation.PHYSICAL;
        }

        private void combatSituationChanged(object sender, EventArgs e)
        {
            if (physicalRadioButton.Checked)
                m_Situation = CombatSituation.PHYSICAL;
            else if (astralRadioButton.Checked)
                m_Situation = CombatSituation.ASTRAL;
            else if (matrixRadioButton.Checked)
                m_Situation = CombatSituation.MATRIX;

            if (OnCombatSituationChanged != null)
                OnCombatSituationChanged(this, null);
        }
    }
}
