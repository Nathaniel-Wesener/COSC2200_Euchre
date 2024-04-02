using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    internal class EuchreGame
    {
        public Player humanPlayer;
        public Player aiPlayer;
        public int pointsToWin;
        public int currentTrump;
        public Card? trumpCard;
        public List<Card> winningcards;
        public Deck deck;
        public int stage;

        public EuchreGame(int pointsToWin)
        {
            humanPlayer = new Player(false);
            aiPlayer = new Player(true);
            this.pointsToWin = pointsToWin;
            deck = new Deck();
            stage = 0;
            winningcards = new List<Card>();
        }

        /// <summary>
        /// Function that generates a list of winning cards based of the suite of the card played and the trump suite.
        /// to be used for the compare cards function and the AI functionality.
        /// </summary>
        /// <param name="suiteTrump"></param>
        /// <param name="suitePlayed"></param>
        public void GenerateList(int suiteTrump, int suitePlayed)
        {
            winningcards = new List<Card>();
            winningcards.Clear();
            Card card = deck.CardMaker(11, suiteTrump);
            winningcards.Add(card);

            if (suiteTrump > 1)
            {
                card = deck.CardMaker(11, suiteTrump + 2);
            }
            else
            {
                card = deck.CardMaker(11, suiteTrump - 2);
            }
            winningcards.Add(card);

            for (int i = 14; i < 9; i--)
            {
                if (i != 11)
                {
                    card = deck.CardMaker(i, suiteTrump);
                    winningcards.Add(card);
                }
            }
            if (suitePlayed != suiteTrump)
            {
                

                for (int y = 14; y < 9; y--)
                {
                    card = deck.CardMaker(y, suitePlayed);
                    winningcards.Add(card);
                }
            }
        }

        /// <summary>
        /// Function that determines what stage the game is in and calls the appropriate functions.
        /// </summary>
        public void gameStage()
        {
            if (stage == 0)
            {
                startGame();
            }
            else if (stage == 1)
            {
                drawTrump();
            }
            else if (stage == 2)
            {
                playATrick();

            } 
        }

        public void startGame()
        {
            aiPlayer.isChoosing = false;
            humanPlayer.isChoosing = true;
            // TODO: add a way to select a random player to go first.
            stage++;
            gameStage();
        }

        /// <summary>
        /// Function that deals card to players and draws the trump card.
        /// </summary>
        public void drawTrump()
        {
            deck.Shuffle();
            if (aiPlayer.isChoosing)
            {
                dealCards(aiPlayer, humanPlayer);
            }
            else
            {
                dealCards(humanPlayer, aiPlayer);
            }
            trumpCard = deck.cards[10];
            if (aiPlayer.isChoosing)
            {
                aiChoice(trumpCard);
            }
            else
            {
                playerChoice(trumpCard);
            }
        }

        void aiChoice(Card possibleCard) 
        {
            int trumpSuite = possibleCard.cardSuiteNum;
            int numOfCardsInSuite = 0;
            int worstCardInHand = 0;
            int i = -1;
            // TODO: it is possible though unlikley that the AI could discard a better card for a weaker one it isn't really gamebreaking but if we have time it should be fixed.
            foreach (Card card in aiPlayer.cardsInHand)
            {
                i++;
                if(card.cardSuiteNum == trumpSuite) { numOfCardsInSuite++; }
                if(card.cardSuiteNum != trumpSuite && card.cardRankNum <= aiPlayer.cardsInHand[worstCardInHand].cardRankNum){ worstCardInHand = i; }
            }

            if (numOfCardsInSuite > 2) 
            {
                currentTrump = trumpSuite;
                aiPlayer.cardsInHand[worstCardInHand] = possibleCard;
                stage = 2;
                aiPlayer.isMaker = true;
                humanPlayer.isMaker = false;
                gameStage();
            }
            else
            {
                // TODO: fix this button enabling as well
                EuchreCardGame.buttonAcceptTrump.enabled = true;
            }
        }
        
        void playerChoice(Card possibleCard) 
        {
            // TODO: fix not being able to enable form controls from here or add a function in the main form that enables and disables controls.
            EuchreCardGame.buttonAcceptTrump.enabled = true;
        }

        /// <summary>
        /// Function that deals cards to the players.
        /// </summary>
        /// <param name="dealer">the player dealing the cards</param>
        /// <param name="dealt">the other player.</param>
        void dealCards(Player dealer, Player dealt)
        {

            dealer.cardsInHand.Clear();
            dealt.cardsInHand.Clear();
            
            for (int i = 0; i < 10; i++)
            {
                if( i%2 == 0)
                {
                    dealt.cardsInHand.Add(deck.cards[i]);
                }
                else
                {
                    dealer.cardsInHand.Add(deck.cards[i]);
                }
            }
        }

        void playATrick()
        {
            if (aiPlayer.isMaker)
            {
                aiMakerTrick();
            }
            else
            {
                playerMakerTrick();
            }
        }
        void aiMakerTrick()
        {
            //TODO: Make the ai decide the best card and then play it.
            
            
            playerResponseTrick();

        }
        void playerMakerTrick()
        {

        }
        void aiResponseTrick()
        {
            if(trumpCard != null && humanPlayer.playedCard != null)
            {
                GenerateList(trumpCard.cardSuiteNum, humanPlayer.playedCard.cardSuiteNum);
                
                List<Card> playableCards = new List<Card>();
                bool cardsInSuite = false;
                foreach (var item in aiPlayer.cardsInHand)
                {
                    if (item.cardSuiteNum == humanPlayer.playedCard.cardSuiteNum)
                    {
                        playableCards.Add(item);
                        cardsInSuite = true;
                    }
                }
                if (cardsInSuite)
                {
                    bool playCard = false;
                    foreach (var card in playableCards)
                    {
                        playCard = compareCards(card, humanPlayer.playedCard);
                        if (playCard)
                        {
                            aiPlayer.cardsInHand.Remove(card);
                            aiPlayer.playedCard = card;
                            break;
                        }
                    }
                    if (!playCard)
                    {
                        aiPlayer.cardsInHand.Remove(playableCards[0]);
                        aiPlayer.playedCard = playableCards[0];
                    }
                    
                }
                else
                {
                    bool playCard = false;
                    foreach (var card in aiPlayer.cardsInHand)
                    {
                        playCard = compareCards(card, humanPlayer.playedCard);
                        if (playCard)
                        {
                            aiPlayer.cardsInHand.Remove(card);
                            aiPlayer.playedCard = card;
                            break;
                        }
                    }
                    if (!playCard)
                    {
                        aiPlayer.cardsInHand.Remove(aiPlayer.cardsInHand[0]);
                        aiPlayer.playedCard = playableCards[0];
                    }
                    
                }
                determineTrickWinner();

            }

        }
        void playerResponseTrick()
        {
            if (trumpCard != null && aiPlayer.playedCard != null)
            {
                GenerateList(trumpCard.cardSuiteNum, aiPlayer.playedCard.cardSuiteNum);
            }
        }

        bool compareCards(Card cardOne, Card cardTwo)
        {
            bool firstCardWins = true;
            
            foreach (var item in winningcards)
            {
                if (item == cardOne)
                {
                    firstCardWins = true;
                    break;
                }
                if (item == cardTwo)
                {
                    firstCardWins = false;
                    break;
                }
            }

            return firstCardWins;
        }

        void determineTrickWinner()
        {
            bool humanWins;
            if (humanPlayer.playedCard != null && aiPlayer.playedCard != null)
            {
                humanWins = compareCards(humanPlayer.playedCard, aiPlayer.playedCard);  

                if (humanWins)
                {
                    aiPlayer.isMaker = false;
                    humanPlayer.isMaker = true;
                    humanPlayer.tricksWon++;
                }
                else
                {
                    humanPlayer.isMaker = false;
                    aiPlayer.isMaker = true;
                    aiPlayer.tricksWon++;
                }

                if(aiPlayer.tricksWon + humanPlayer.tricksWon < 5)
                {
                    playATrick();
                }
                else
                {
                    roundEnd();
                }
            }
            
        }

        void roundEnd()
        {
            if(humanPlayer.tricksWon > aiPlayer.tricksWon)
            {
                humanPlayer.addPoints();
            }
            else
            {
                aiPlayer.addPoints();
            }

            if (humanPlayer.points >= pointsToWin)
            {
                //TODO: Make a victory thing
            }
            else if (aiPlayer.points >= pointsToWin)
            {
                //TODO: Make a loss thing.
            }
            else
            {
                if (humanPlayer.isChoosing)
                {
                    humanPlayer.isChoosing = false;
                    aiPlayer.isChoosing = true;
                }
                else
                {
                    humanPlayer.isChoosing = true;
                    aiPlayer.isChoosing = false;
                }
                stage = 1;
                gameStage();
            }
        }





    }
}
