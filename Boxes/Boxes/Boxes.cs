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
        public Boxes(CardSet deck,
            Action<Player> selectActivePlayer,
            Action<Player> selectPassivePlayer,
             Action<string> showMessage,
            params Player[] players)
        {
            Deck = deck;
            SelectActivePlayer = selectActivePlayer;
            SelectPassivePlayer = selectPassivePlayer;
            Message = showMessage;
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

        private Action<Player> SelectActivePlayer;

        private Action<Player> SelectPassivePlayer;

        private  Action<string> Message;

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(4));
            }

            ActivePlayer = Players[0];
            PassivePlayer = Players[1];
            Refresh();
        }

        public void Refresh()
        {
            CheckBoxes();
            CheckEnd();
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
            }

            SelectActivePlayer(ActivePlayer);
            SelectPassivePlayer(PassivePlayer);
        }

        public Player NextPlayer(Player player)
        {
            if (player == Players[Count - 1])
            {
                return Players[0];
                
            }

            else
            {
                int index = Players.IndexOf(player);
                return Players[index + 1];
            }
        }

        public void Req()
        {
            ActivePlayer.PlayerCards.Add(Deck.Pull());
            ActivePlayer = NextPlayer(ActivePlayer);
            PassivePlayer = NextPlayer(ActivePlayer);
            Refresh();
        }
        public bool Request(Question que)
        {
            List<Card> passivePlayerCard = PassivePlayer.PlayerCards.Cards;

            if (passivePlayerCard.FirstOrDefault(c => c.Figure == que.figure) == null)
            {
                Req();
                Message($"Player don't have {que.figure}");
                return false;
            }

            if (que.amount != 0 && passivePlayerCard.Count(c => c.Figure == que.figure) != que.amount)
            {
                Req();
                Message($"Player don't have {que.amount} {que.figure}");
                return false;
            }

            if (que.IsFull())
            {
                foreach (var suit in que.Suits)
                {
                    if (passivePlayerCard.FirstOrDefault(c => c.Figure == que.figure && c.Suit == suit) == null)
                    {
                        Req();
                        Message($"Player have another set");
                        return false;
                    }
                }

                foreach (var suit in que.Suits)
                {
                    ActivePlayer.PlayerCards.Add(PassivePlayer.PlayerCards.Pull(
                        PassivePlayer.PlayerCards.Cards.FindIndex(c => c.Figure == que.figure && c.Suit == suit)));
                }
                PassivePlayer = NextPlayer(PassivePlayer);
                if (PassivePlayer == ActivePlayer) PassivePlayer = NextPlayer(PassivePlayer);
                Refresh();
                Message($"Player have these cards. Next step");
                return true;
            }
            Message($"Player have this card. Choose next.");
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
            foreach (var p in Players)
            {
                if (p.PlayerCards.Cards.Count != 0) return;
            }
            
            Player winner = Players.Max();
        }

    }
}
