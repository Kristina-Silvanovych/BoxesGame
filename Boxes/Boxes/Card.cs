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

        public static CardFigure GetFigure(string figureString)
        {
            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                if (figureString == ((CardFigure)figure).ToString())
                    return (CardFigure)figure;
            }
            throw new Exception();
        }

        public static CardSuit GetSuit(string suitString)
        {
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
            {
                if (suitString == ((CardSuit)suit).ToString())
                    return (CardSuit)suit;
            }
            throw new Exception();
        }

    }
}

