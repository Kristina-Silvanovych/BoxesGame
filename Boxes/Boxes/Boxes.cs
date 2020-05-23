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

        public int Count
        {
            get { return Players.Count; }
        }

        public CardSet Deck { get; set; }
        public List<Player> Players { get; set; }
        public Player ActivePlayer { get; set; }
        public Player PassivePlayer { get; set; }

        public Action<Player> SelectActivePlayer;

        public Action<Player> SelectPassivePlayer;

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

        public Player NextPlayer(Player player)
        {
                if (player == Players[Count - 1])
                {
                    return Players[0];
;               }
                
                else 
                {
                    int index = Players.IndexOf(player);
                    return Players[index + 1];
                }
        }

        public bool Request(Answer answer)
        {
            if (!answer.IsFull())
            {
                return false;
            }
            else
            {
                if ()
                {
                    SelectPassivePlayer(PassivePlayer);
                }
                else SelectActivePlayer(ActivePlayer);
            }
            return false;
        }

        public void CheckBoxes(CardSet card)
        {
            if ()
            { 
            
            }
        }

        public int CheckEnd(CardSet card)
        {
            for (int acc = 0; acc <= card.CheckBoxes(); acc++)
            {
                return acc;
            }
            return 0;
        }
    }
}
