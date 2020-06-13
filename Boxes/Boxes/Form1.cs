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
        bool right = false;
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
            //for test
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btncheck.Enabled = cmbFigure.Text != "";
            cmbAmount.Visible = cmbFigure.Text != "";
            btncheck.Top = cmbFigure.Top;
            btncheck.Left = 870;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbFigure.Visible = true;
            btncheck.Visible = true;
            game = new Boxes( new GraphicsCardSet(pnlDeck,36),
                MarkAcPlayer,MarkPasPlayer, ShowMessage,
                new GraphicsPlayer("Bob", new GraphicsCardSet(pnlPlayer1), lbl1),
                new GraphicsPlayer("Tom", new GraphicsCardSet(pnlPlayer2),lbl2),
                new GraphicsPlayer("Jack", new GraphicsCardSet(pnlPlayer3),lbl3),
                new GraphicsPlayer("Max", new GraphicsCardSet(pnlPlayer4),lbl4));

            game.Deal();
            button1.Enabled = false;
        }

        private void ShowMessage(string message)
        {
            //lblMessage.ForeColor = right ? Color.Red : Color.Green;

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
            passivePlayerCards.Panel.BackColor = Color.Red;
            ((GraphicsPlayer)passivePlayer).LabelName.BackColor = Color.Salmon;
        }
        private void MarkAcPlayer(Player activePlayer)
        {
            GraphicsCardSet activePlayerCards = (GraphicsCardSet)activePlayer.PlayerCards;
            activePlayerCards.Panel.BackColor = Color.DarkGreen;
            foreach (var player in game.Players)
            {
                if (player == activePlayer)
                {
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = true;
                    }

                    ((GraphicsPlayer)player).LabelName.BackColor = Color.GreenYellow;
                }
                else
                {
                    ((GraphicsCardSet)player.PlayerCards).Panel.BackColor = Color.White;
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = false;
                    }
                    ((GraphicsPlayer)player).LabelName.BackColor = Color.White;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardFigure cardFigure = Card.GetFigure(cmbFigure.Text);


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
            if (!right || (right && suits.Count != 0))
            {
                cmbAmount.Text = "";
                cmbFigure.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                btncheck.Left = 772;
                btncheck.Top = 373;

            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSuits.Visible = cmbAmount.Text != "";
            btncheck.Top = cmbAmount.Top;
            btncheck.Left = 870;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btncheck.Top = gbxSuits.Top;
            btncheck.Left = 870;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btncheck.Top = gbxSuits.Top;
            btncheck.Left = 870;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            btncheck.Top = gbxSuits.Top;
            btncheck.Left = 870;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            btncheck.Top = gbxSuits.Top;
            btncheck.Left = 870;
        }
    }
}
