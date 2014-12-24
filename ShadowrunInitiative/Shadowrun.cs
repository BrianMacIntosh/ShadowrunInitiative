using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ShadowrunInitiative
{
    public enum CombatSituation
    {
        PHYSICAL,
        ASTRAL,
        MATRIX,
    }

    public enum MatrixLevel
    {
        AR,
        COLD_SIM,
        HOT_SIM,
    }

    public static class Shadowrun
    {
        private static Random m_Random = new Random();

        public static int d6()
        {
            return m_Random.Next(6) + 1;
        }

        public static int d6(int qty)
        {
            int roll = qty;
            for (int c = 0; c < qty; c++)
                roll += m_Random.Next(6);
            return roll;
        }

        public static int RollInitiative(CombatSituation situation, Character character)
        {
            int ir = character.Intuition + character.Reaction;
            int id = character.Intuition + character.DataProcessing;
            switch (situation)
            {
                case CombatSituation.PHYSICAL:
                    return ir + d6();
                case CombatSituation.ASTRAL:
                    return (2 * character.Intuition) + d6(2);
                case CombatSituation.MATRIX:
                    switch (character.MatrixLevel)
                    {
                        case MatrixLevel.AR:
                            return ir + d6();
                        case MatrixLevel.COLD_SIM:
                            return id + d6(3);
                        case MatrixLevel.HOT_SIM:
                            return id + d6(4);
                        default:
                            throw new NotImplementedException();
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }

    /// <summary>
    /// Stores data and stats on one character.
    /// </summary>
    public class Character : INotifyPropertyChanged
    {
        public string Name;

        public MatrixLevel MatrixLevel = MatrixLevel.AR;

        public bool PC
        {
            get { return m_PC; }
            set
            {
                m_PC = value;
                NotifyPropertyChanged("PC");
            }
        }
        private bool m_PC = false;

        public bool Incapacitated
        {
            get { return m_Incapacitated; }
            set
            {
                m_Incapacitated = value;
                NotifyPropertyChanged("Incapacitated");
            }
        }
        private bool m_Incapacitated = false;

        public int Edge, Reaction, Intuition, DataProcessing;

        public int Initiative
        {
            get { return m_Initiative; }
            set
            {
                m_Initiative = Math.Max(0, value);
                NotifyPropertyChanged("Initiative");
            }
        }
        private int m_Initiative = 0;

        public bool WentThisTurn = false;

        public bool Seize = false;

        public void TurnReset()
        {
            WentThisTurn = false;
            Seize = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// IComparer for comparing character speed.
    /// </summary>
    public class CharacterSpeedComparer : IComparer<Character>
    {
        private static Random s_Random = new Random();

        public int Compare(Character a, Character b)
        {
            if (!a.Seize && b.Seize)
                return -1;
            else if (a.Seize && !b.Seize)
                return 1;

            if (a.Initiative < b.Initiative)
                return -1;
            else if (a.Initiative > b.Initiative)
                return 1;

            if (a.Edge < b.Edge)
                return -1;
            else if (a.Edge > b.Edge)
                return 1;

            if (a.Reaction < b.Reaction)
                return -1;
            else if (a.Reaction > b.Reaction)
                return 1;

            if (a.Intuition < b.Intuition)
                return -1;
            else if (a.Intuition > b.Intuition)
                return 1;

            return (s_Random.Next() % 2) * 2 - 1;
        }
    }
}
