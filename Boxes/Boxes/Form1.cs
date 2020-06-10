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
                cmbFigure.Items.Add(figure.ToString());
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
            Go.Enabled = cmbFigure.Text != "";
            cmbAmount.Visible = cmbFigure.Text != "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Boxes( new GraphicsCardSet(pnlDeck,36),
                MarkAcPlayer,MarkPasPlayer, ShowMessage,
                new Player("Bob", new GraphicsCardSet(pnlPlayer1)),
                new Player("Tom", new GraphicsCardSet(pnlPlayer2)),
                new Player("Jack", new GraphicsCardSet(pnlPlayer3)),
                new Player("Phill", new GraphicsCardSet(pnlPlayer4)));

            game.Deal();
        }

        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            SetActiveCard(pictureBox);
        }

        private void MarkPasPlayer(Player passivePlayer)
        {
            GraphicsCardSet passivePlayerCards = (GraphicsCardSet)passivePlayer.PlayerCards;
            passivePlayerCards.Panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void MarkAcPlayer(Player activePlayer)
        {
            GraphicsCardSet activePlayerCards = (GraphicsCardSet)activePlayer.PlayerCards;
            activePlayerCards.Panel.BorderStyle = BorderStyle.Fixed3D;
            foreach (var player in game.Players)
            {
                if (player == activePlayer)
                {
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = true;
                    }
                }
                else
                {
                    ((GraphicsCardSet)player.PlayerCards).Panel.BorderStyle = BorderStyle.None;
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardFigure cardFigure = Card.GetFigure(cmbFigure.Text);
            bool right = false;

            List<CardSuit> suits = new List<CardSuit>();
            if (cmbAmount.Text == "")
            {
                right = game.Request(new Question(cardFigure));
            }
            else
            {
                foreach (var control in gbxSuits.Controls)
                {
                    CheckBox checkbox = (CheckBox)control;
                    if (checkbox.Checked)
                        suits.Add(Card.GetSuit(checkbox.Text));
                }
                if (suits.Count == 0)
                    right = game.Request(new Question(cardFigure, Convert.ToInt32(cmbAmount.Text)));
                else
                    right = game.Request(new Question(cardFigure, Convert.ToInt32(cmbAmount.Text), suits));
            }
            if (!right)
            {
                cmbAmount.Text = "";
                cmbFigure.Text = "";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSuits.Visible = cmbAmount.Text != "";
        }
    }
}
