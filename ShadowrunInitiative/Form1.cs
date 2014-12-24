using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ShadowrunInitiative
{
    public partial class Form1 : Form
    {
        private CharacterSpeedComparer CharacterSorter = new CharacterSpeedComparer();

        private BindingList<Character> m_Characters = new BindingList<Character>();
        private Character m_CurrentCharacter = null;

        public TimeSpan CombatLength = TimeSpan.FromSeconds(0);
        public int CombatTurns
        {
            get { return m_CombatTurns; }
            set
            {
                m_CombatTurns = value;
                CombatLength = TimeSpan.FromSeconds(m_CombatTurns * 3f);

                List<string> comps = new List<string>();
                if (CombatLength.Hours > 0)
                    comps.Add(CombatLength.Hours + " hours");
                if (CombatLength.Minutes > 0)
                    comps.Add(CombatLength.Minutes + " min");
                if (CombatLength.Seconds > 0 || comps.Count == 0)
                    comps.Add(CombatLength.Seconds + " sec");
                combatTimeLabel.Text = string.Join(", ", comps);
            }
        }
        private int m_CombatTurns = 0;

        private Character SelectedCharacter
        {
            get { return charactersListBox.SelectedItem as Character; }
        }

        private const int MAX_LOG = 64;

        private BindingList<string> m_LogMessages = new BindingList<string>();

        private void LogMessage(string str)
        {
            if (m_LogMessages.Count >= MAX_LOG)
                m_LogMessages.RemoveAt(0);
            m_LogMessages.Add(str);
        }

        public Form1()
        {
            InitializeComponent();

            CombatTurns = 0;
            characterBox.Visible = false;
            logListBox.DataSource = m_LogMessages;
            SetCurrentCharacter(null);

            combatSituationPanel1.OnCombatSituationChanged += OnSituationChanged;
            OnSituationChanged(this, null);

            m_Characters.ListChanged += CharacterListChanged;
            CharacterListChanged(null, null);
            charactersListBox.DataSource = m_Characters;
        }

        private void OnSituationChanged(object sender, EventArgs e)
        {
            matrixLevelPanel.Visible = combatSituationPanel1.Situation == CombatSituation.MATRIX;
        }

        private void CharacterListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateCharacterDependent();
        }

        private void UpdateCharacterDependent()
        {
            nextTurnButton.Enabled = m_Characters.Any();
            newCombatButton.Enabled = m_Characters.Any();

            interrupt5Button.Enabled = SelectedCharacter != null && SelectedCharacter.Initiative >= 5;
            interrupt10Button.Enabled = SelectedCharacter != null && SelectedCharacter.Initiative >= 10;

            delayButton.Enabled = m_CurrentCharacter == SelectedCharacter;
        }

        private void charactersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load infos into character box
            if (SelectedCharacter != null)
            {
                characterBox.Visible = true;
                characterBox.Text = SelectedCharacter.Name;
                pcCheckbox.Checked = SelectedCharacter.PC;
                incapacitatedCheckBox.Checked = SelectedCharacter.Incapacitated;
                edgeNumeric.Value = SelectedCharacter.Edge;
                reactNumeric.Value = SelectedCharacter.Reaction;
                intuitNumeric.Value = SelectedCharacter.Intuition;
                initNumeric.Value = SelectedCharacter.Initiative;
            }
            else
            {
                characterBox.Visible = false;
            }
            UpdateCharacterDependent();
        }

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            NewCharacter newCharacterDialog = new NewCharacter();
            if (newCharacterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_Characters.Add(newCharacterDialog.Character);
                charactersListBox_SelectedIndexChanged(charactersListBox, null);
            }
        }

        private void pcCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.PC = pcCheckbox.Checked;
        }

        private void incapacitatedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.Incapacitated = incapacitatedCheckBox.Checked;
        }

        private void edgeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.Edge = (int)edgeNumeric.Value;
        }

        private void reactNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.Reaction = (int)reactNumeric.Value;
        }

        private void intuitNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.Intuition = (int)intuitNumeric.Value;
        }

        private void initNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                SelectedCharacter.Initiative = (int)initNumeric.Value;
        }

        private void removeCharacterButton_Click(object sender, EventArgs e)
        {
            if (m_Characters.Contains(SelectedCharacter))
            {
                if (MessageBox.Show(
                    "Really delete character '" + SelectedCharacter.Name + "'?",
                    "Delete Character",
                    MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    m_Characters.Remove(SelectedCharacter);
                }
            }
        }

        private void interrupt5Button_Click(object sender, EventArgs e)
        {
            SpendInterrupt(-5);
        }

        private void interrupt10Button_Click(object sender, EventArgs e)
        {
            SpendInterrupt(-10);
        }

        private void SpendInterrupt(int value)
        {
            if (SelectedCharacter != null)
            {
                if (SelectedCharacter.Initiative + value >= 0)
                {
                    SelectedCharacter.Initiative += value;
                    LogMessage(value + ": " + SelectedCharacter.Name + " spends interrupt.");
                }
            }
        }

        private void interruptXButton_Click(object sender, EventArgs e)
        {
            ChooseInterrupt choose = new ChooseInterrupt(SelectedCharacter);
            if (choose.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SpendInterrupt(choose.Value);
            }
        }

        private void newCombatButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Delete all NPCs and reset player characters?",
                "Reset Combat",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                for (int c = m_Characters.Count - 1; c >= 0; c--)
                {
                    if (!m_Characters[c].PC)
                        m_Characters.RemoveAt(c);
                    m_LogMessages.Clear();
                    CombatTurns = 0;
                }
            }
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            AdvanceTurn();
        }

        private void SetCurrentCharacter(Character character)
        {
            m_CurrentCharacter = character;
            UpdateCharacterDependent();
            if (character != null)
            {
                nextTurnButton.Text = "Next Turn";
                character.WentThisTurn = true;
                //currentTurnStaticLabel.Visible = true;
                currentCharLabel.Text = ">>" + character.Name + "<<";

                string turnMessage = "TURN: " + character.Name;
                if (character.Seize)
                    turnMessage += " (seized)";
                LogMessage(turnMessage);
            }
            else
            {
                nextTurnButton.Text = "Begin Round";
                //currentTurnStaticLabel.Visible = false;
                currentCharLabel.Text = "N/A";
            }
        }

        private bool m_NewTurn = false;
        private bool m_NeedsInitiative = false;

        private void AdvanceTurn()
        {
            //This is where the fun begins.
            if (m_NeedsInitiative)
            {
                //Query for initiatives
                QueryInitiatives query = new QueryInitiatives(m_Characters);
                if (query.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    m_NeedsInitiative = false;
                else
                    return;
            }

            IEnumerable<Character> stillCanAct = m_Characters.Where(c => c.Initiative > 0 && !c.Incapacitated);
            IEnumerable<Character> stillToGo = stillCanAct.Where(c => !c.WentThisTurn);
            if (stillToGo.Any())
            {
                //Someone's turn right now
                if (m_NewTurn)
                {
                    LogMessage("");
                    LogMessage("---- NEW TURN ----");
                    m_NewTurn = false;
                }
                SetCurrentCharacter(stillToGo.OrderByDescending(c => c, CharacterSorter).First());
            }
            else if (stillCanAct.Any())
            {
                //Next combat turn
                foreach (Character c in m_Characters)
                {
                    c.Initiative -= 10;
                    c.TurnReset();
                }
                CombatTurns++;
                m_NewTurn = true;
                AdvanceTurn();
            }
            else
            {
                //New round
                foreach (Character c in m_Characters)
                    c.TurnReset();
                SetCurrentCharacter(null);

                LogMessage("");
                LogMessage("-+-+ NEW ROUND +-+-");

                //Query for initiatives
                QueryInitiatives query = new QueryInitiatives(m_Characters);
                if (query.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    AdvanceTurn();
                else
                    m_NeedsInitiative = true;
            }

            m_NewTurn = false;
        }

        private void delayButton_Click(object sender, EventArgs e)
        {
            DelayAction delayDialog = new DelayAction();
            if (delayDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        public void UpdateCombatSituation()
        {

        }
    }
}
