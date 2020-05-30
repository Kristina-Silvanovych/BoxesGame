using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxes
{
    class Boxes
    {
        public Boxes(CardSet Table, CardSet deck, params Player[] players)
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
            CheckBoxes();
            CheckEnd();
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
                ;
            }

            else
            {
                int index = Players.IndexOf(player);
                return Players[index + 1];
            }
        }

        public bool Request(Question que)
        {
            List<Card> passivePlayerCard = PassivePlayer.PlayerCards.Cards;

            if (passivePlayerCard.FirstOrDefault(c => c.Figure == que.figure) == null)
            {
                ActivePlayer = NextPlayer(ActivePlayer);
                ActivePlayer.PlayerCards.Add(Deck.Pull());
                Refresh();
                return false;
            }

            if (que.amount != 0 && passivePlayerCard.Count(c => c.Figure == que.figure) == 0)
            {
                ActivePlayer = NextPlayer(ActivePlayer);
                ActivePlayer.PlayerCards.Add(Deck.Pull());
                Refresh();
                return false;
            }

            if (que.IsFull())
            {
                foreach (var suit in que.suits)
                {
                    if (passivePlayerCard.FirstOrDefault(c => c.Figure == que.figure && c.Suit == suit) == null)
                    {
                        ActivePlayer = NextPlayer(ActivePlayer);
                        ActivePlayer.PlayerCards.Add(Deck.Pull());
                        Refresh();
                        return false;
                    }
                }

                foreach (var suit in que.suits)
                {
                    ActivePlayer.PlayerCards.Add(PassivePlayer.PlayerCards.Pull(new Card(suit, que.figure)));
                    PassivePlayer = NextPlayer(PassivePlayer);
                    if (PassivePlayer == ActivePlayer) PassivePlayer = NextPlayer(PassivePlayer);
                    Refresh();
                }
                return true;
            }

            return true;

        }

        public void CheckBoxes()
        {

            foreach (var p in Players)
            {    
                List<Card> PlayerCard = p.PlayerCards.Cards;

                foreach (var figure in Enum.GetValues(typeof(CardFigure)))
                {
                    if (PlayerCard.Count(c => c.Figure == (CardFigure)figure)==4)
                    {
                        PlayerCard.RemoveAll(c => c.Figure == (CardFigure)figure);
                        p.Point++;
                    }
                }
           
            }
        }

        public void CheckEnd()
        {
            //перебрать игроков, проверить, есть ли пустой, если есть, то определить победителя по баллам
            
            foreach (var p in Players)
            {
                if (p.PlayerCards.Cards.Count != 0) return;
            }
            //попробуй разобраться с Max
            //Player winner = Players.Max(Players.FiPoint);
        }
    }
}
