using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxes
{
    public partial class Form1 : Form
    {
        Card activeCard;
        Boxes game;
        Player mover;
        public Form1()
        {
            InitializeComponent();

            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                comboBox1.Items.Add(figure.ToString());
            }
        }

        private void SetActiveCard(PictureBox pictureBox)
        {
            foreach (var player in game.Players)
            {
                foreach (var card in player.PlayerCards.Cards)
                {
                    if (((GraphicCard)card).Pb == pictureBox)
                    {
                        if (card == activeCard)
                        {
                            activeCard = null;
                            pictureBox.Top -= 10;
                            mover = null;
                        }
                        else
                        {
                            activeCard = card;
                            pictureBox.Top += 10;
                            mover = player;
                        }


                        return;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Boxes(new GraphicsCardSet(pnlTable), new GraphicsCardSet(pnlDeck,36),
                new Player("Bob", new GraphicsCardSet(pnlPlayer1)), new Player("Tom", new GraphicsCardSet(pnlPlayer2)));
            game.SelectActivePlayer = MarkPlayer;

            game.Deal();
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            SetActiveCard(pictureBox);
        }
        //markPassive player
        private void MarkPlayer(Player activePlayer)
        {
            foreach (var player in game.Players)
            {
                if (player == activePlayer)
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = true;
                    }
                else
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = false;
                    }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //формирование Question по эл.управления
            //вызов game.Request(Que)
            CardFigure cardFigure = 0;
            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                if (comboBox1.Text == ((CardFigure)figure).ToString())
                    cardFigure = (CardFigure)figure;
            }

            game.Request(new Question(cardFigure));
        }
    }
}
