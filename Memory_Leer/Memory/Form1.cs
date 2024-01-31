using System;
using System.Resources;

namespace Memory
{
    // Enum for each color
    public enum colorEnum
    {
        black,
        grey,
        darkRed,
        red,
        green,
        orange,
        yellow,
        blue,
        purple,
        brown
    }

    /*#################################################################*/

    // Struct for the cards
    public struct Card
    {
        colorEnum color;
        int cardPosition;
        bool isOpen;
        bool isSolved;
        Image theImage;

        // Constructor to initialize a Card
        public Card(colorEnum color, int cardPosition, Image theImage)
        {
            this.color = color;
            this.cardPosition = cardPosition;
            this.theImage = theImage;
            isOpen = false;
            isSolved = false;
        }

        // Get method for the Image
        public Image getImage()
        {
            return theImage;
        }

        public void setCardPosition(int newPosition)
        {
            cardPosition = newPosition;
        }

        public int getCardPosition()
        {
            return cardPosition;
        }   
    }

    /*#################################################################*/

    //FORM1 CLASS
    public partial class Form1 : Form
    {
        //INIT
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            initializeCardField();
        }

        // enum for gameState when clicking cards
        private enum gameState
        {
            gSStart,
            gSRun,
            gSEnd
        }



        /*#################################################################*/
        // VARIABLES

        // timer
        private int _timer = 0;

        // counter for tries
        private int _tries = 0;

        // pointer
        private int _pointerFirstCard = 0;
        private int _pointerSecondCard = 0;

        // current game state
        private gameState _currentGameState = gameState.gSStart;

        // field of cards
        private Card[] cardField = new Card[20];


        /*#################################################################*/
        // SPECIAL FUNCTIONS/ ACTIONS IN THE GAME

        // method to initialize each card and the cardfield
        private void initializeCardField()
        {
            //pictureBox1.Image = Memory.Properties.Resources._01Black;
            //Card(color,position)
            cardField[0] = new Card(colorEnum.black, 1, Memory.Properties.Resources._01Black);
            cardField[1] = new Card(colorEnum.black, 2, Memory.Properties.Resources._01Black);
            cardField[2] = new Card(colorEnum.grey, 3, Memory.Properties.Resources._02Grey);
            cardField[3] = new Card(colorEnum.grey, 4, Memory.Properties.Resources._02Grey);
            cardField[4] = new Card(colorEnum.darkRed, 5, Memory.Properties.Resources._03DarkRed);
            cardField[5] = new Card(colorEnum.darkRed, 6, Memory.Properties.Resources._03DarkRed);
            cardField[6] = new Card(colorEnum.red, 7, Memory.Properties.Resources._04Red);
            cardField[7] = new Card(colorEnum.red, 8, Memory.Properties.Resources._04Red);
            cardField[8] = new Card(colorEnum.green, 9, Memory.Properties.Resources._05Green);
            cardField[9] = new Card(colorEnum.green, 10, Memory.Properties.Resources._05Green);
            cardField[10] = new Card(colorEnum.orange, 11, Memory.Properties.Resources._06Orange);
            cardField[11] = new Card(colorEnum.orange, 12, Memory.Properties.Resources._06Orange);
            cardField[12] = new Card(colorEnum.yellow, 13, Memory.Properties.Resources._07Yellow);
            cardField[13] = new Card(colorEnum.yellow, 14, Memory.Properties.Resources._07Yellow);
            cardField[14] = new Card(colorEnum.blue, 15, Memory.Properties.Resources._08Blue);
            cardField[15] = new Card(colorEnum.blue, 16, Memory.Properties.Resources._08Blue);
            cardField[16] = new Card(colorEnum.purple, 17, Memory.Properties.Resources._09Purple);
            cardField[17] = new Card(colorEnum.purple, 18, Memory.Properties.Resources._09Purple);
            cardField[18] = new Card(colorEnum.brown, 19, Memory.Properties.Resources._10Brown);
            cardField[19] = new Card(colorEnum.brown, 20, Memory.Properties.Resources._10Brown);

            //put the cards from the "digital" field onto the "visual" field
            for (int index = 0; index < 20; index++)
            {
                putCardOnToPosition(index + 1, cardField[index]);
            }
        }

        // "Covers" or flips the card at designated position
        public void putCoverCardOnToPosition(int position)
        {
            switch (position)
            {
                case 1:
                    pictureBox1.Image = Memory.Properties.Resources.Background; break;
                case 2:
                    pictureBox2.Image = Memory.Properties.Resources.Background; break;
                case 3:
                    pictureBox3.Image = Memory.Properties.Resources.Background; break;
                case 4:
                    pictureBox4.Image = Memory.Properties.Resources.Background; break;
                case 5:
                    pictureBox5.Image = Memory.Properties.Resources.Background; break;
                case 6:
                    pictureBox6.Image = Memory.Properties.Resources.Background; break;
                case 7:
                    pictureBox7.Image = Memory.Properties.Resources.Background; break;
                case 8:
                    pictureBox8.Image = Memory.Properties.Resources.Background; break;
                case 9:
                    pictureBox9.Image = Memory.Properties.Resources.Background; break;
                case 10:
                    pictureBox10.Image = Memory.Properties.Resources.Background; break;
                case 11:
                    pictureBox11.Image = Memory.Properties.Resources.Background; break;
                case 12:
                    pictureBox12.Image = Memory.Properties.Resources.Background; break;
                case 13:
                    pictureBox13.Image = Memory.Properties.Resources.Background; break;
                case 14:
                    pictureBox14.Image = Memory.Properties.Resources.Background; break;
                case 15:
                    pictureBox15.Image = Memory.Properties.Resources.Background; break;
                case 16:
                    pictureBox16.Image = Memory.Properties.Resources.Background; break;
                case 17:
                    pictureBox17.Image = Memory.Properties.Resources.Background; break;
                case 18:
                    pictureBox18.Image = Memory.Properties.Resources.Background; break;
                case 19:
                    pictureBox19.Image = Memory.Properties.Resources.Background; break;
                case 20:
                    pictureBox20.Image = Memory.Properties.Resources.Background; break;
            }
        }

        /* puts a card on to the designated position on the UI
         */
        public void putCardOnToPosition(int position, Card thisCard)
        {
            switch (position)
            {
                case 1:
                    pictureBox1.Image = thisCard.getImage(); break;
                case 2:
                    pictureBox2.Image = thisCard.getImage(); break;
                case 3:
                    pictureBox3.Image = thisCard.getImage(); break;
                case 4:
                    pictureBox4.Image = thisCard.getImage(); break;
                case 5:
                    pictureBox5.Image = thisCard.getImage(); break;
                case 6:
                    pictureBox6.Image = thisCard.getImage(); break;
                case 7:
                    pictureBox7.Image = thisCard.getImage(); break;
                case 8:
                    pictureBox8.Image = thisCard.getImage(); break;
                case 9:
                    pictureBox9.Image = thisCard.getImage(); break;
                case 10:
                    pictureBox10.Image = thisCard.getImage(); break;
                case 11:
                    pictureBox11.Image = thisCard.getImage(); break;
                case 12:
                    pictureBox12.Image = thisCard.getImage(); break;
                case 13:
                    pictureBox13.Image = thisCard.getImage(); break;
                case 14:
                    pictureBox14.Image = thisCard.getImage(); break;
                case 15:
                    pictureBox15.Image = thisCard.getImage(); break;
                case 16:
                    pictureBox16.Image = thisCard.getImage(); break;
                case 17:
                    pictureBox17.Image = thisCard.getImage(); break;
                case 18:
                    pictureBox18.Image = thisCard.getImage(); break;
                case 19:
                    pictureBox19.Image = thisCard.getImage(); break;
                case 20:
                    pictureBox20.Image = thisCard.getImage(); break;
            }
        }

        /*#################################################################*/
        // BUTTONS

        /* BUTTON START
         */
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (gameState.gSStart == _currentGameState)
            {
                timer1.Start();
                //pictureBox1.Image = Memory.Properties.Resources.Background;

                //Generate a new random 20-field
                int[] rField = new int[20];
                bool check = false; // check to see if searched number is in the array
                for (int index = 0; index < 20; index++)
                {
                    var rng = new Random();
                    var number = rng.Next(0, 21);
                    int newNumber = number;
                    for (int index2nd = 0; index2nd < 20; index2nd++)
                    {
                        if (rField[index2nd] == newNumber)
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        check = false;
                        index--;
                    }
                    else
                    {
                        rField[index] = newNumber;
                    }
                }

                // set new positions
                for (int i = 0; i < 20; i++)
                {
                    cardField[i].setCardPosition(rField[i]);
                }
                /*
                //put the cards from the "digital" field onto the "visual" field
                for (int index = 0; index < 20; index++)
                {
                    putCardOnToPosition(cardField[index].getCardPosition(), cardField[index]);
                }
                _currentGameState = gameState.gSRun;
                */

                // "flips" the cards
                for (int i = 0; i < 20; i++)
                {
                    putCoverCardOnToPosition(i + 1);
                }

                // change current game state
                _currentGameState = gameState.gSRun;

            }
        }

        /* BUTTON RESTART
         */
        private void buttonRestart_Click(object sender, EventArgs e)
        {

        }



        /*#################################################################*/
        // TIMER HANDLING

        /* TIMER TICK action
         */
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _timer++; // inc timer

            // handling minutes and seconds
            int minutes = 0;
            int seconds = 0;
            minutes = _timer / 60;
            seconds = _timer % 60;

            // sysout minutes
            textBoxTimer.Text = minutes.ToString();
            textBoxTimer.Text += ":";

            // sysout and handles seconds
            if (seconds < 10)
            {
                textBoxTimer.Text += "0";

            }
            textBoxTimer.Text += seconds.ToString();
        }


        /*#################################################################*/

        //Searches for a card in the array with the corresponding position and returns its index in the array
        private int searchForCard(int positionVisual)
        {
            int digitalPosition = 0;
            for (int i = 0; i < 20; i++)
            {
                if (positionVisual == cardField[i].getCardPosition())
                {
                    digitalPosition = cardField[i].getCardPosition();
                }
            }
            return digitalPosition;
        }

        // PIC 1 CLICK
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox1.Image = cardField[searchForCard(1)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 2 CLICK
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox2.Image = cardField[searchForCard(2)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 3 CLICK
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox3.Image = cardField[searchForCard(3)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 4 CLICK
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox4.Image = cardField[searchForCard(4)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 5 CLICK
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox5.Image = cardField[searchForCard(5)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 6 CLICK
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox6.Image = cardField[searchForCard(6)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 7 CLICK
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox7.Image = cardField[searchForCard(7)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 8 CLICK
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox8.Image = cardField[searchForCard(8)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }


        // PIC 9 CLICK
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox9.Image = cardField[searchForCard(9)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 10 CLICK
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox10.Image = cardField[searchForCard(10)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox11.Image = cardField[searchForCard(11)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox12.Image = cardField[searchForCard(12)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox13.Image = cardField[searchForCard(13)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox14.Image = cardField[searchForCard(14)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox15.Image = cardField[searchForCard(15)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox16.Image = cardField[searchForCard(16)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox17.Image = cardField[searchForCard(17)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox18.Image = cardField[searchForCard(18)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    pictureBox19.Image = cardField[searchForCard(19)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    int check = searchForCard(20);
                    pictureBox20.Image = cardField[searchForCard(20)].getImage();

                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }
    }
}