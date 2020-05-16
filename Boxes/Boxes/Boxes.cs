using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Boxes
    {
        public Boxes(CardSet deck, params Player[] players)
        {
            Deck = deck;
            Players = new List<Player>(players);
            ActivePlayer = players[0];
        }

        public CardSet Deck { get; set; }
        public List<Player> Players { get; set; }
        public Player ActivePlayer { get; set; }
        public Player PassivePlayer { get; set; }

        public Action<Player> SelectActivePlayer;
        public Action<string> Message;

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(4));
            }
            Refresh();
            ActivePlayer = Players[0];
            PassivePlayer = Players[1];
        }

        public void Refresh()
        {
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
            }
        }

        //NextPlayer(Player player)

        //bool Request( Answ answ)
        //SelectActivePlayer(activePlayer)
        //if(Answer.amount==0 || f)


        //CheckBoxes()

        //CheckEnd()

    }
}
