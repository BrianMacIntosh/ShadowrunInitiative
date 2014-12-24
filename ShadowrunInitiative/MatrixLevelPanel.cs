using System;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    public partial class MatrixLevelPanel : UserControl
    {
        public MatrixLevel MatrixLevel
        {
            get { return m_MatrixLevel; }
            set
            {
                m_MatrixLevel = value;
                switch (m_MatrixLevel)
                {
                    case MatrixLevel.AR:
                        arRadioButton.Checked = true;
                        break;
                    case MatrixLevel.COLD_SIM:
                        coldsimRadioButton.Checked = true;
                        break;
                    case MatrixLevel.HOT_SIM:
                        hotsimRadioButton.Checked = true;
                        break;
                }
            }
        }
        private MatrixLevel m_MatrixLevel;

        public MatrixLevelPanel()
        {
            InitializeComponent();

            MatrixLevel = MatrixLevel.AR;
        }

        private void matrixLevelChanged(object sender, EventArgs e)
        {
            if (arRadioButton.Checked)
                m_MatrixLevel = MatrixLevel.AR;
            else if (coldsimRadioButton.Checked)
                m_MatrixLevel = MatrixLevel.COLD_SIM;
            else if (hotsimRadioButton.Checked)
                m_MatrixLevel = MatrixLevel.HOT_SIM;
        }
    }
}
