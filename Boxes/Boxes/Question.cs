using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Boxes
{
    class Question
    {
        //public List<string> list { get; set; }
        //foreach(var figure in Enum.GetValues(typeof(CardFigure)))
        //{
        //    comboBox1.Items.Add(((CardFigure)figure).ToString());
        //}

        public CardFigure figure;
        public int amount;
        public List<CardSuit> suits;

        public Question(CardFigure Figure)
        {
            figure = Figure;
        }

        public Question(CardFigure Figure, int Amount)
        {
            figure = Figure;
            amount = Amount;
        }

        public Question(CardFigure Figure, int Amount, List<CardSuit> Suits)
        {
            figure = Figure;
            amount = Amount;
            suits = Suits;
        }

        public bool IsFull()
        {
            return suits.Count != 0;
        }
    }
}

