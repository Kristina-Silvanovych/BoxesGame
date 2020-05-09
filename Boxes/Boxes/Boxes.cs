using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Boxes
    {
        public Boxes(CardSet deck, CardSet table, params Player[] players)
        {
            Deck = deck;
            Table = table;
            Players = new List<Player>(players);
            ActivePlayer = players[0];
        }

        public CardSet Deck { get; set; }
        public CardSet Table { get; set; }
        public List<Player> Players { get; set; }
        public Player ActivePlayer { get; set; }

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(4));
            }
            Refresh();
        }

        public void Refresh()
        {
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
            }
            Table.Show();
        }

    }
}
