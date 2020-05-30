using System;
using System.Collections.Generic;
using System.Linq;
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
                Refresh();
                return false;
            }

            if (que.amount != 0 && passivePlayerCard.Count(c => c.Figure == que.figure) == 0)
            {
                ActivePlayer = NextPlayer(ActivePlayer);
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
            //проверить всех игроков, есть ли 4 карты одной фигуры и если да, сбросить их и добавить баллы
            List<Card> PlayerCard = Players.PlayerCards.Cards;
            foreach (var p in Players)
            {
                int acc = 0;
                int max = int.MinValue;
                if (PlayerCard.Count(c => c.Figure ==  && c.Suit == ))
                {
                    p.PlayerCards.Deal(c);
                    acc++;
                    if (acc > max)
                    {
                        max = acc;
                    }
                }             
            }
        }

        public void CheckEnd()
        {
            //перебрать игроков, проверить, есть ли пустой, если есть, то определить победителя по баллам
            List <Player> playerPoints = CheckBoxes(Players.Cards);
            foreach (var p in Players)
            {
                if (p.PlayerCards == null)
                {
                    CheckBoxes();
                    MessageBox.Show("Congratulations! " + p + "is Winner!!!");
                }
            }
        }
    }
}
