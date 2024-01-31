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
        public colorEnum getColor()
        {
            return color;
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

        public bool getIsOpen()
        {
            return isOpen;
        }

        public void setIsOpen(bool isOpen)
        {
            this.isOpen = isOpen;
        }

        public bool getIsSolved()
        {
            return isSolved;
        }

        public void setIsSolved(bool isSolved)
        {
            this.isSolved = isSolved;
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

        // found pairs
        private int _pairsFound = 0;

        // pointer
        private int _pointerFirstCard = -1;
        private int _pointerSecondCard = -1;
        private int _openCards = 0;

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
            if(_currentGameState != gameState.gSStart)
            {
                _currentGameState = gameState.gSRun;
                _timer = 0;
                timer1.Start();

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

                // "flips" the cards
                for (int i = 0; i < 20; i++)
                {
                    putCoverCardOnToPosition(i + 1);
                }

                _pairsFound = 0;
                _openCards = 0;
                _pointerFirstCard = -1;
                _pointerSecondCard = -1;
                _tries = 0;
                textBoxTries.Text = "0";
                textBoxFoundPairs.Text = _pairsFound.ToString();
                textBoxTimer.Text = "0:00";

                for(int index = 0; index < 20; index++)
                {
                    cardField[index].setIsOpen(false);
                    cardField[index].setIsSolved(false);
                }
            }
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


        /*#################################################################################################################################*/

        //Searches for a card in the array with the corresponding position and returns its index in the array
        private int searchForCard(int positionVisual)
        {
            int digitalPosition = 0;
            for (int i = 0; i < 20; i++)
            {
                if (positionVisual == cardField[i].getCardPosition())
                {
                    digitalPosition = i;
                }
            }
            return digitalPosition;
        }

        // Handles the opened cards when a third would be opened
        public void handleOpenCardLimit()
        {
            if (_openCards == 2)
            {
                putCoverCardOnToPosition(_pointerFirstCard);
                putCoverCardOnToPosition(_pointerSecondCard);
                cardField[searchForCard(_pointerFirstCard)].setIsOpen(false);
                cardField[searchForCard(_pointerSecondCard)].setIsOpen(false);
                _pointerFirstCard = -1;
                _pointerSecondCard = -1;
                _openCards = 0;
                _tries++;
                textBoxTries.Text = _tries.ToString();
            }
        }

        // virtually open the cards
        public void openCard(int position)
        {
            if (_pointerFirstCard == -1)
            {
                _pointerFirstCard = position;
            }
            else if (_pointerSecondCard == -1)
            {
                _pointerSecondCard = position;
            }
            handleOpenCardLimit();
            if (_openCards == 0)
            {
                _pointerFirstCard = position;
            }
            _openCards++;
        }
        // extra found pairs check for the last pair
        void checkPairFound()
        {
            if (_pointerFirstCard != -1 && _pointerSecondCard != -1 && cardField[searchForCard(_pointerFirstCard)].getColor().Equals(cardField[searchForCard(_pointerSecondCard)].getColor()))
            {
                cardField[searchForCard(_pointerFirstCard)].setIsSolved(true);
                cardField[searchForCard(_pointerSecondCard)].setIsSolved(true);
                _pointerFirstCard = -1;
                _pointerSecondCard = -1;
                _openCards = 0;
                _tries++;
                textBoxTries.Text = _tries.ToString();
                _pairsFound++;
                textBoxFoundPairs.Text = _pairsFound.ToString();
            }
        }

        // handles the situation when a card is clicked
        public void handleCardPressed(int cardPosition)
        {
            if (cardField[searchForCard(cardPosition)].getIsOpen() == false)
            {
                checkPairFound();
                openCard(cardPosition);
                cardField[searchForCard(cardPosition)].setIsOpen(true);
                switch (cardPosition)
                {
                    case 1:
                        pictureBox1.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 2:
                        pictureBox2.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 3:
                        pictureBox3.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 4:
                        pictureBox4.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 5:
                        pictureBox5.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 6:
                        pictureBox6.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 7:
                        pictureBox7.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 8:
                        pictureBox8.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 9:
                        pictureBox9.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 10:
                        pictureBox10.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 11:
                        pictureBox11.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 12:
                        pictureBox12.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 13:
                        pictureBox13.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 14:
                        pictureBox14.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 15:
                        pictureBox15.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 16:
                        pictureBox16.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 17:
                        pictureBox17.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 18:
                        pictureBox18.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 19:
                        pictureBox19.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                    case 20:
                        pictureBox20.Image = cardField[searchForCard(cardPosition)].getImage();
                        break;
                }
                checkPairFound();
                handleEndGameSituation();
            }
        }

        // Handles the situation when all pairs have been found;
        public void handleEndGameSituation()
        {
            if(_pairsFound == 10)
            {
                _currentGameState = gameState.gSEnd;
                timer1.Stop();
            }
        }

        /*#################################################################################################################################*/
        // BUTTON/ CARD CLICK HANDLING

        // PIC 1 CLICK
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(1);
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
                    handleCardPressed(2);
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
                    handleCardPressed(3);
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
                    handleCardPressed(4);
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
                    handleCardPressed(5);
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
                    handleCardPressed(6);
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
                    handleCardPressed(7);
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
                    handleCardPressed(8);
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
                    handleCardPressed(9);
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
                    handleCardPressed(10);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 11 CLICK
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(11);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 11 CLICK
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(12);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 13 CLICK
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(13);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 14 CLICK
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(14);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 15 CLICK
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(15);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 16 CLICK
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(16);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 17 CLICK
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(17);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 18 CLICK
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(18);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 19 CLICK
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(19);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }

        // PIC 20 CLICK
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            switch (_currentGameState)
            {
                case gameState.gSStart:
                    // do nothing
                    break;
                case gameState.gSRun:
                    handleCardPressed(20);
                    break;
                case gameState.gSEnd:
                    // do nothing
                    break;
            }
        }
    }
}