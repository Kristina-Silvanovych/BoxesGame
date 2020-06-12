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
        public CardFigure figure { get; set; }
        public int amount { get; set; }
        public List<CardSuit> Suits { get; set; }

        public Question(CardFigure Figure)
        {
            figure = Figure;
        }

        public Question(CardFigure Figure, int Amount)
        {
            figure = Figure;
            amount = Amount;
        }

        public Question(CardFigure Figure, int Amount, List<CardSuit> suits)
        {
            figure = Figure;
            amount = Amount;
            Suits = suits;
        }

        public bool IsFull()
        {
            return Suits!=null && Suits.Count != 0;
        }
    }
}

