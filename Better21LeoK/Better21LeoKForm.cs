using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better21LeoK
{
    public partial class frmBetter21LeoK : Form
    {
        //global variables
        List<Image> dealerAndUserCards = new List<Image>();
        int randomCard, dealerValue1, dealerValue2, dealerValue3, userValue1, userValue2, dealerTotal, userTotal, numOfWins;
        List<Image> deckOfCards = new List<Image>();
        Random randomNumGenerator = new Random();

        public frmBetter21LeoK()
        {
            InitializeComponent();

            //disable play again
            this.btnPlayAgain.Enabled = false;

            //call procedures
            CreateDeck();
            RandomCards();

            //hide userCard3
            this.picUserCard3.Hide();

            //display the number of wins
            numOfWins = 0;
            this.lblWins.Text = "Wins: " + numOfWins;
        }

        private void CreateDeck()
        {
            //clear the list
            deckOfCards.Clear();

            //populate the list with 52 cards, all different
            //Ace's
            deckOfCards.Add(Properties.Resources.AC);
            deckOfCards.Add(Properties.Resources.AD);
            deckOfCards.Add(Properties.Resources.AH);
            deckOfCards.Add(Properties.Resources.AS);
            //2's
            deckOfCards.Add(Properties.Resources._2C);
            deckOfCards.Add(Properties.Resources._2D);
            deckOfCards.Add(Properties.Resources._2H);
            deckOfCards.Add(Properties.Resources._2S);
            //3's
            deckOfCards.Add(Properties.Resources._3C);
            deckOfCards.Add(Properties.Resources._3D);
            deckOfCards.Add(Properties.Resources._3H);
            deckOfCards.Add(Properties.Resources._3S);
            //4's
            deckOfCards.Add(Properties.Resources._4C);
            deckOfCards.Add(Properties.Resources._4D);
            deckOfCards.Add(Properties.Resources._4H);
            deckOfCards.Add(Properties.Resources._4S);
            //5's
            deckOfCards.Add(Properties.Resources._5C);
            deckOfCards.Add(Properties.Resources._5D);
            deckOfCards.Add(Properties.Resources._5H);
            deckOfCards.Add(Properties.Resources._5S);
            //6's
            deckOfCards.Add(Properties.Resources._6C);
            deckOfCards.Add(Properties.Resources._6D);
            deckOfCards.Add(Properties.Resources._6H);
            deckOfCards.Add(Properties.Resources._6S);
            //7's
            deckOfCards.Add(Properties.Resources._7C);
            deckOfCards.Add(Properties.Resources._7D);
            deckOfCards.Add(Properties.Resources._7H);
            deckOfCards.Add(Properties.Resources._7S);
            //8's
            deckOfCards.Add(Properties.Resources._8C);
            deckOfCards.Add(Properties.Resources._8D);
            deckOfCards.Add(Properties.Resources._8H);
            deckOfCards.Add(Properties.Resources._8S);
            //9's
            deckOfCards.Add(Properties.Resources._9C);
            deckOfCards.Add(Properties.Resources._9D);
            deckOfCards.Add(Properties.Resources._9H);
            deckOfCards.Add(Properties.Resources._9S);
            //10's
            deckOfCards.Add(Properties.Resources._10C);
            deckOfCards.Add(Properties.Resources._10D);
            deckOfCards.Add(Properties.Resources._10H);
            deckOfCards.Add(Properties.Resources._10S);
            //J's
            deckOfCards.Add(Properties.Resources.JC);
            deckOfCards.Add(Properties.Resources.JD);
            deckOfCards.Add(Properties.Resources.JH);
            deckOfCards.Add(Properties.Resources.JS);
            //Q's
            deckOfCards.Add(Properties.Resources.QC);
            deckOfCards.Add(Properties.Resources.QD);
            deckOfCards.Add(Properties.Resources.QH);
            deckOfCards.Add(Properties.Resources.QS);
            //K's
            deckOfCards.Add(Properties.Resources.KC);
            deckOfCards.Add(Properties.Resources.KD);
            deckOfCards.Add(Properties.Resources.KH);
            deckOfCards.Add(Properties.Resources.KS);
        }

        private void RandomCards()
        {
            //clear dealerAndUserCards
            dealerAndUserCards.Clear();

            //check to see if the deck of cards has less than 5 images
            if (deckOfCards.Count() <= 5)
            {
                CreateDeck();
            }

            //get a random cards and add them to dealerAndUserCards
            for (int counter = 0; counter <= 5; counter++)
            {
                //generate a random number between 1 and the number of cards in deckOfCards
                randomCard = randomNumGenerator.Next(1, deckOfCards.Count());

                //add a random card to dealerAndUserCards at the index of counter
                dealerAndUserCards.Insert(counter, deckOfCards[randomCard]);

                //remove the card from deckOfCards at the randomCard index
                deckOfCards.RemoveAt(randomCard);
            }

            //call display cards
            DisplayCards();
        }

        private void DisplayCards()
        {
            //display the front of the cards for the dealer
            this.picDealerCard1.Image = Properties.Resources.Front;
            this.picDealerCard2.Image = Properties.Resources.Front;
            this.picDealerCard3.Image = Properties.Resources.Front;

            //display the users cards
            this.picUserCard1.Image = dealerAndUserCards[0];
            this.picUserCard2.Image = dealerAndUserCards[1];

            //finding userValue1
            if (picUserCard1.Image == Properties.Resources.AC)
            {
                userValue1 = 1;
            }
            else if (picUserCard1.Image == Properties.Resources.AD)
            {
                userValue1 = 1;
            }
            else if (picUserCard1.Image == Properties.Resources.AH)
            {
                userValue1 = 1;
            }
            else if (picUserCard1.Image == Properties.Resources.AS)
            {
                userValue1 = 1;
            }
            else if (picUserCard1.Image == Properties.Resources._2C)
            {
                userValue1 = 2;
            }
            else if (picUserCard1.Image == Properties.Resources._2D)
            {
                userValue1 = 2;
            }
            else if (picUserCard1.Image == Properties.Resources._2H)
            {
                userValue1 = 2;
            }
            else if (picUserCard1.Image == Properties.Resources._2S)
            {
                userValue1 = 2;
            }
            else if (picUserCard1.Image == Properties.Resources._3C)
            {
                userValue1 = 3;
            }
            else if (picUserCard1.Image == Properties.Resources._3D)
            {
                userValue1 = 3;
            }
            else if (picUserCard1.Image == Properties.Resources._3H)
            {
                userValue1 = 3;
            }
            else if (picUserCard1.Image == Properties.Resources._3S)
            {
                userValue1 = 3;
            }
            else if (picUserCard1.Image == Properties.Resources._4C)
            {
                userValue1 = 4;
            }
            else if (picUserCard1.Image == Properties.Resources._4D)
            {
                userValue1 = 4;
            }
            else if (picUserCard1.Image == Properties.Resources._4H)
            {
                userValue1 = 4;
            }
            else if (picUserCard1.Image == Properties.Resources._4S)
            {
                userValue1 = 4;
            }
            else if (picUserCard1.Image == Properties.Resources._5C)
            {
                userValue1 = 5;
            }
            else if (picUserCard1.Image == Properties.Resources._5D)
            {
                userValue1 = 5;
            }
            else if (picUserCard1.Image == Properties.Resources._5H)
            {
                userValue1 = 5;
            }
            else if (picUserCard1.Image == Properties.Resources._5S)
            {
                userValue1 = 5;
            }
            else if (picUserCard1.Image == Properties.Resources._6C)
            {
                userValue1 = 6;
            }
            else if (picUserCard1.Image == Properties.Resources._6D)
            {
                userValue1 = 6;
            }
            else if (picUserCard1.Image == Properties.Resources._6H)
            {
                userValue1 = 6;
            }
            else if (picUserCard1.Image == Properties.Resources._6S)
            {
                userValue1 = 6;
            }
            else if (picUserCard1.Image == Properties.Resources._7C)
            {
                userValue1 = 7;
            }
            else if (picUserCard1.Image == Properties.Resources._7D)
            {
                userValue1 = 7;
            }
            else if (picUserCard1.Image == Properties.Resources._7H)
            {
                userValue1 = 7;
            }
            else if (picUserCard1.Image == Properties.Resources._7S)
            {
                userValue1 = 7;
            }
            else if (picUserCard1.Image == Properties.Resources._8C)
            {
                userValue1 = 8;
            }
            else if (picUserCard1.Image == Properties.Resources._8D)
            {
                userValue1 = 8;
            }
            else if (picUserCard1.Image == Properties.Resources._8H)
            {
                userValue1 = 8;
            }
            else if (picUserCard1.Image == Properties.Resources._8S)
            {
                userValue1 = 8;
            }
            else if (picUserCard1.Image == Properties.Resources._9C)
            {
                userValue1 = 9;
            }
            else if (picUserCard1.Image == Properties.Resources._9D)
            {
                userValue1 = 9;
            }
            else if (picUserCard1.Image == Properties.Resources._9H)
            {
                userValue1 = 9;
            }
            else if (picUserCard1.Image == Properties.Resources._9S)
            {
                userValue1 = 9;
            }
            else if (picUserCard1.Image == Properties.Resources._10C)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources._10D)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources._10H)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources._10S)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.JC)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.JD)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.JH)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.JS)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.QC)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.QD)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.QH)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.QS)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.KC)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.KD)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.KH)
            {
                userValue1 = 10;
            }
            else if (picUserCard1.Image == Properties.Resources.KS)
            {
                userValue1 = 10;
            }

            //finding userValue2
            if (picUserCard2.Image == Properties.Resources.AC)
            {
                userValue2 = 1;
            }
            else if (picUserCard2.Image == Properties.Resources.AD)
            {
                userValue2 = 1;
            }
            else if (picUserCard2.Image == Properties.Resources.AH)
            {
                userValue2 = 1;
            }
            else if (picUserCard2.Image == Properties.Resources.AS)
            {
                userValue2 = 1;
            }
            else if (picUserCard2.Image == Properties.Resources._2C)
            {
                userValue2 = 2;
            }
            else if (picUserCard2.Image == Properties.Resources._2D)
            {
                userValue2 = 2;
            }
            else if (picUserCard2.Image == Properties.Resources._2H)
            {
                userValue2 = 2;
            }
            else if (picUserCard2.Image == Properties.Resources._2S)
            {
                userValue2 = 2;
            }
            else if (picUserCard2.Image == Properties.Resources._3C)
            {
                userValue2 = 3;
            }
            else if (picUserCard2.Image == Properties.Resources._3D)
            {
                userValue2 = 3;
            }
            else if (picUserCard2.Image == Properties.Resources._3H)
            {
                userValue2 = 3;
            }
            else if (picUserCard2.Image == Properties.Resources._3S)
            {
                userValue2 = 3;
            }
            else if (picUserCard2.Image == Properties.Resources._4C)
            {
                userValue2 = 4;
            }
            else if (picUserCard2.Image == Properties.Resources._4D)
            {
                userValue2 = 4;
            }
            else if (picUserCard2.Image == Properties.Resources._4H)
            {
                userValue2 = 4;
            }
            else if (picUserCard2.Image == Properties.Resources._4S)
            {
                userValue2 = 4;
            }
            else if (picUserCard2.Image == Properties.Resources._5C)
            {
                userValue2 = 5;
            }
            else if (picUserCard2.Image == Properties.Resources._5D)
            {
                userValue2 = 5;
            }
            else if (picUserCard2.Image == Properties.Resources._5H)
            {
                userValue2 = 5;
            }
            else if (picUserCard2.Image == Properties.Resources._5S)
            {
                userValue2 = 5;
            }
            else if (picUserCard2.Image == Properties.Resources._6C)
            {
                userValue2 = 6;
            }
            else if (picUserCard2.Image == Properties.Resources._6D)
            {
                userValue2 = 6;
            }
            else if (picUserCard2.Image == Properties.Resources._6H)
            {
                userValue2 = 6;
            }
            else if (picUserCard2.Image == Properties.Resources._6S)
            {
                userValue2 = 6;
            }
            else if (picUserCard2.Image == Properties.Resources._7C)
            {
                userValue2 = 7;
            }
            else if (picUserCard2.Image == Properties.Resources._7D)
            {
                userValue2 = 7;
            }
            else if (picUserCard2.Image == Properties.Resources._7H)
            {
                userValue2 = 7;
            }
            else if (picUserCard2.Image == Properties.Resources._7S)
            {
                userValue2 = 7;
            }
            else if (picUserCard2.Image == Properties.Resources._8C)
            {
                userValue2 = 8;
            }
            else if (picUserCard2.Image == Properties.Resources._8D)
            {
                userValue2 = 8;
            }
            else if (picUserCard2.Image == Properties.Resources._8H)
            {
                userValue2 = 8;
            }
            else if (picUserCard2.Image == Properties.Resources._8S)
            {
                userValue2 = 8;
            }
            else if (picUserCard2.Image == Properties.Resources._9C)
            {
                userValue2 = 9;
            }
            else if (picUserCard2.Image == Properties.Resources._9D)
            {
                userValue2 = 9;
            }
            else if (picUserCard2.Image == Properties.Resources._9H)
            {
                userValue2 = 9;
            }
            else if (picUserCard2.Image == Properties.Resources._9S)
            {
                userValue2 = 9;
            }
            else if (picUserCard2.Image == Properties.Resources._10C)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources._10D)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources._10H)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources._10S)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.JC)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.JD)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.JH)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.JS)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.QC)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.QD)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.QH)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.QS)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.KC)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.KD)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.KH)
            {
                userValue2 = 10;
            }
            else if (picUserCard2.Image == Properties.Resources.KS)
            {
                userValue2 = 10;
            }


            //add userValue1 and userValue2
            userTotal = userValue1 + userValue2;

            //display the user total
            this.lblUserTotal.Text = "Your Total: " + userTotal;

            Console.WriteLine("userValue1 = " + userValue1);
            Console.WriteLine("userValue2 = " + userValue2);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            //reset variables
            dealerTotal = 0;
            userTotal = 0;
            numOfWins = 0;

            //clear deckOfCards
            deckOfCards.Clear();

            //call procedures
            CreateDeck();
            RandomCards();
        }

        private void mniClearWins_Click(object sender, EventArgs e)
        {
            //set wins to 0
            numOfWins = 0;
            this.lblWins.Text = "Wins: " + numOfWins;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //call randomcards
            RandomCards();

            //enable and disable buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            this.btnPlayAgain.Enabled = false;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //display the dealers cards
            this.picDealerCard1.Image = dealerAndUserCards[2];
            this.picDealerCard2.Image = dealerAndUserCards[3];
            this.picDealerCard3.Image = dealerAndUserCards[4];

            //get dealerValue1

            //get dealerValue2

            //get dealerValue3

            //get dealerTotal and userTotal
            dealerTotal = dealerValue1 + dealerValue2 + dealerValue3;
            userTotal = userValue1 + userValue2;

            //display dealerTotal and userTotal
            lblUserTotal.Text = "Your total: " + userTotal;
            lblDealerTotal.Text = "Dealer total: " + dealerTotal;

            //check to see who wins and loses
            if (userTotal == dealerTotal)
            {
                this.lblResult.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblResult.Text = "Blackjack! You Win";
                numOfWins++;
            }
            else if (dealerTotal == 21)
            {
                this.lblResult.Text = "Blackjack! Dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblResult.Text = "Dealer Wins";
            }
            else if (dealerTotal > 21)
            {
                if (userTotal < 21)
                {
                    this.lblResult.Text = "You Win!";
                    numOfWins++;
                }
                else
                {
                    this.lblResult.Text = "Dealer Wins";
                }
            }
            else if (userTotal > dealerTotal)
            {
                this.lblResult.Text = "You Win";
                numOfWins++;
            }
            else if (userTotal < dealerTotal)
            {
                this.lblResult.Text = "Dealer Wins";
            }

            //enable and disable buttons
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnPlayAgain.Enabled = true;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //variables
            int userValue3 = 0;

            //show userCard3
            picUserCard3.Show();

            //generate a random number between 1 and the number of cards in deckOfCards
            randomCard = randomNumGenerator.Next(1, deckOfCards.Count());

            //add a random card to dealerAndUserCards at the index of counter
            dealerAndUserCards.Insert(5, deckOfCards[randomCard]);

            //remove the card from deckOfCards at the randomCard index
            deckOfCards.RemoveAt(randomCard);

            //display the card
            picUserCard3.Image = dealerAndUserCards[5];

            //get userValue3

            //display the dealers cards
            this.picDealerCard1.Image = dealerAndUserCards[2];
            this.picDealerCard2.Image = dealerAndUserCards[3];
            this.picDealerCard3.Image = dealerAndUserCards[4];

            //get dealerValue1

            //get dealerValue2

            //get dealerValue3

            //get dealerTotal and userTotal
            dealerTotal = dealerValue1 + dealerValue2 + dealerValue3;
            userTotal = userValue1 + userValue2 + userValue3;

            //display dealerTotal and userTotal
            lblUserTotal.Text = "Your total: " + userTotal;
            lblDealerTotal.Text = "Dealer total: " + dealerTotal;

            //check to see who wins and loses
            if (userTotal == dealerTotal)
            {
                this.lblResult.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblResult.Text = "Blackjack! You Win";
                numOfWins++;
            }
            else if (dealerTotal == 21)
            {
                this.lblResult.Text = "Blackjack! Dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblResult.Text = "Dealer Wins";
            }
            else if (dealerTotal > 21)
            {
                if (userTotal < 21)
                {
                    this.lblResult.Text = "You Win!";
                    numOfWins++;
                }
                else
                {
                    this.lblResult.Text = "Dealer Wins";
                }
            }
            else if (userTotal > dealerTotal)
            {
                this.lblResult.Text = "You Win";
                numOfWins++;
            }
            else if (userTotal < dealerTotal)
            {
                this.lblResult.Text = "Dealer Wins";
            }

            //enable and disable buttons
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnPlayAgain.Enabled = true;
        }
    }
}
