using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public enum CardFigure
    {
        six,
        seven,
        eight,
        nine,
        ten,
        Queen,
        King,
        Jack,
        Ace
    }

    public enum CardSuit
    {
        Diamond,
        Club,
        Heart,
        Spade
    }
    class Card
    {
        public CardSuit Suit { get; set; }
        public CardFigure Figure { get; set; }

        public Card(CardSuit suit, CardFigure figure)
        {
            Suit = suit;
            Figure = figure;
        }

        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Figure, Suit);
        }

        public int BoxesValue()
        {
            switch (Figure)
            {
                case CardFigure.six:
                    return 6;
                case CardFigure.seven:
                    return 7;
                case CardFigure.eight:
                    return 8;
                case CardFigure.nine:
                    return 9;
                case CardFigure.ten:
                    return 10;
                case CardFigure.Queen:
                    return 10;
                case CardFigure.King:
                    return 10;
                case CardFigure.Jack:
                    return 10;
                case CardFigure.Ace:
                    return 10;
                default:
                    return 0;
            }
        }
    }
}

