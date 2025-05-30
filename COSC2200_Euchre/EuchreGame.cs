﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2200_Euchre
{
    public class EuchreGame : EuchreCardGame
    {
        public EuchreCardGame form;
        public Player humanPlayer;
        public Player aiPlayer;
        public int pointsToWin;
        public int currentTrump;
        public Card? trumpCard;
        public List<Card> winningcards;
        public Deck deck;
        public int stage;

        public EuchreGame(int pointsToWin, EuchreCardGame form)
        {
            this.form = form;
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
            winningcards.Clear();
            Card card = deck.CardMaker(11, suiteTrump);
            winningcards.Add(card);

            if (suiteTrump > 1)
            {
                card = deck.CardMaker(11, suiteTrump - 2);
                
            }
            else
            {
                card = deck.CardMaker(11, suiteTrump + 2);
                
            }
            winningcards.Add(card);

            for (int i = 14; i > 9; i--)
            {
                if (i != 11)
                {
                    card = deck.CardMaker(i, suiteTrump);
                    winningcards.Add(card);
                }
            }
            if (suitePlayed != suiteTrump)
            {
                

                for (int y = 14; y > 9; y--)
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
            form.addToHistory("Game Start");
            gameStage();
        }

        /// <summary>
        /// Function that deals card to players and draws the trump card.
        /// </summary>
        public void drawTrump()
        {
            // Set bothe players tricks one count too 0.
            aiPlayer.tricksWon = 0;
            humanPlayer.tricksWon = 0;

            form.trickCounterLabelAI(aiPlayer.tricksWon);
            form.trickCounterLabelHuman(humanPlayer.tricksWon);

            // Shuffle the deck then deal.
            deck.Shuffle();
            if (aiPlayer.isChoosing)
            {
                dealCards(aiPlayer, humanPlayer);
            }
            else
            {
                dealCards(humanPlayer, aiPlayer);
            }
            form.displayCardsInHand(humanPlayer.cardsInHand);
            trumpCard = deck.cards[10];
            form.displayTrumpCanditate(trumpCard);
            
            // Send to different functions depending on which player is choosing.
            if (aiPlayer.isChoosing)
            {
                aiChoice(trumpCard);
            }
            else
            {
                playerChoice(trumpCard);
            }
        }

        /// <summary>
        /// Function that lets the ai decide whether or not it wants the trump.
        /// </summary>
        /// <param name="possibleCard">The card that was drawn for trump.</param>
        public void aiChoice(Card possibleCard) 
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
                form.addToHistory("AI accepted the trump card " + possibleCard.toString());
                stage = 2;
                aiPlayer.isMaker = true;
                humanPlayer.isMaker = false;
                if (trumpCard != null)
                {
                    form.changeCurrentTrump(trumpCard.cardSuiteStr);  
                }
                
                gameStage();
            }
            else
            {
                if (humanPlayer.isChoosing)
                {
                    playerSecondTrumpChoice();
                    form.addToHistory("Both players refused trump! player chooses trump wild.");
                }
                else
                {
                    playerChoice(possibleCard);
                    form.addToHistory("AI refused the trump!");

                }
            }
        }
        

        void playerChoice(Card possibleCard) 
        {
            
            form.enableDisableButtonAcceptTrump(true);
            form.buttonDeclineTrump.Enabled = true;
        }
        void playerSecondTrumpChoice()
        {
            //TODO: Enable Combobox etc. -IL
            form.comboBoxSelectTrump.Enabled = true;
            form.comboBoxSelectTrump.Items.Clear();
            form.comboBoxSelectTrump.Text = "";
            form.comboBoxSelectTrump.Items.Add("Hearts");
            form.comboBoxSelectTrump.Items.Add("Clubs");
            form.comboBoxSelectTrump.Items.Add("Diamonds");
            form.comboBoxSelectTrump.Items.Add("Spades");
            form.comboBoxSelectTrump.SelectedIndex = -1;

            form.buttonAcceptTrump.Enabled = true;
        }
        public void playerChoseTrumpWild(int newtrump)
        {
            // sets the wild trump choice for the played
            currentTrump = newtrump;
            Card card = deck.CardMaker(10, newtrump);
            form.changeCurrentTrump(card.cardSuiteStr);
            stage++;
            form.addToHistory("Player chose trump " + card.cardSuiteStr);
            gameStage();
            


        }

        public void aiChoseWild()
        {
            int hearts = 0;
            int clubs = 0;
            int diamonds = 0;
            int spades = 0;

            foreach (Card item in aiPlayer.cardsInHand)
            {
                if (item.cardSuiteNum == 0){ hearts++; }
                else if(item.cardSuiteNum == 1) { clubs++; }
                else if (item.cardSuiteNum == 2) { diamonds++; }
                else { spades++; }
            }

            Card card;
            if (hearts >= clubs)
            {
                if (hearts >= diamonds)
                {
                    if (hearts >= spades)
                    {
                        currentTrump = 0;
                        card = deck.CardMaker(10, 0);
                        form.changeCurrentTrump(card.cardSuiteStr);

                    }
                    else
                    {
                        currentTrump = 3;
                        card = deck.CardMaker(10, 3);
                        form.changeCurrentTrump(card.cardSuiteStr);
                    }
                }
                else if (diamonds >= spades)
                {
                    currentTrump = 2;
                    card = deck.CardMaker(10, 2);
                    form.changeCurrentTrump(card.cardSuiteStr);
                }
                else
                {
                    currentTrump = 3;
                    card = deck.CardMaker(10, 3);
                    form.changeCurrentTrump(card.cardSuiteStr);
                }
            }
            else
            {
                if (clubs >= diamonds)
                {
                    if (clubs >= spades)
                    {
                        currentTrump = 1;
                        card = deck.CardMaker(10, 1);
                        form.changeCurrentTrump(card.cardSuiteStr);
                    }
                    else
                    {
                        currentTrump = 3;
                        card = deck.CardMaker(10, 3);
                        form.changeCurrentTrump(card.cardSuiteStr);
                    }
                }
                else
                {
                    if(diamonds >= spades)
                    {
                        currentTrump = 2;
                        card = deck.CardMaker(10, 2);
                        form.changeCurrentTrump(card.cardSuiteStr);
                    }
                    else
                    {
                        currentTrump = 3;
                        card = deck.CardMaker(10, 3);
                        form.changeCurrentTrump(card.cardSuiteStr);
                    }
                }
                
            }
            aiPlayer.isMaker = true;
            humanPlayer.isMaker = false;
            stage++;
            form.addToHistory("AI chose trump " + card.cardSuiteStr);
            gameStage();

        }




        public void AcceptTrump()
        {
            //TODO: activate when player clicks accept trump. then sets the trump in the class and moves 
            // to the next game stage. -FB

            if (trumpCard != null)
            {
                int worstCardInHand = 0;
                currentTrump = trumpCard.cardSuiteNum;
                int i = -1;
                foreach (Card card in humanPlayer.cardsInHand)
                {
                    i++;
                    if (card.cardSuiteNum != currentTrump && card.cardRankNum <= humanPlayer.cardsInHand[worstCardInHand].cardRankNum) { worstCardInHand = i; }
                }
                humanPlayer.cardsInHand[worstCardInHand] = trumpCard;
                humanPlayer.isMaker = true;
                aiPlayer.isMaker = false;
                form.displayCardsInHand(humanPlayer.cardsInHand);
                form.buttonAcceptTrump.Enabled = false;
                form.buttonDeclineTrump.Enabled = false;
                form.addToHistory("Player chose the trump card " + trumpCard.toString());
                stage++;
                gameStage();
            }
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

        /// <summary>
        /// Function that starts tricks being played.
        /// </summary>
        void playATrick()
        {
            if (aiPlayer.isMaker)
            {
                
                form.changeCurrentMaker("AI");
                aiMakerTrick();
            }
            else
            {
                form.changeCurrentMaker("You");
                playerMakerTrick();
            }
        }
        void aiMakerTrick()
        {
            //TODO: Make the ai decide the best card and then play it. -NW
            List<Card> trumpCards = new List<Card>();
            bool hasTrumpCards = false;
            foreach (Card card in aiPlayer.cardsInHand)
            {
                if(card.cardSuiteNum == currentTrump)
                {
                    hasTrumpCards = true;
                    trumpCards.Add(card);
                }
            }
            if (hasTrumpCards)
            {
                Card cardToPlay = trumpCards[0];

                foreach (var item in trumpCards)
                {
                    if (item.cardRankNum == 11)
                    {
                        cardToPlay = item;
                        break;
                    }
                    else if(item.cardRankNum > cardToPlay.cardRankNum)
                    {
                        cardToPlay = item;
                    }
                }
                aiPlayer.playedCard = cardToPlay;
                aiPlayer.cardsInHand.Remove(cardToPlay);
            }
            else
            {
                aiPlayer.playedCard = aiPlayer.cardsInHand[0];
                aiPlayer.cardsInHand.RemoveAt(0);
            }
            form.displayAIPlayedCard(aiPlayer.playedCard);
            GenerateList(currentTrump, aiPlayer.playedCard.cardSuiteNum);
            playerResponseTrick();

        }
        void playerMakerTrick()
        {
            form.addNewItemsToCardsToPlay(humanPlayer.cardsInHand);
        }

        public void playerPlayed(int index)
        {
            // TODO: activate when the player plays a card and displays that card. removes the played card from the
            // players hand and ssets their played card to that card. displays the new hand with the removed card.
            // call the ai response trick function. - FB
            // bool hasTrumpCards = humanPlayer.cardsInHand.Any(card => card.cardSuiteNum == currentTrump);
            humanPlayer.playedCard = humanPlayer.cardsInHand[index];
            humanPlayer.cardsInHand.RemoveAt(index);
            form.displayHumanPlayedCard(humanPlayer.playedCard);
            form.displayCardsInHand(humanPlayer.cardsInHand);
            GenerateList(currentTrump, humanPlayer.playedCard.cardSuiteNum);
            aiResponseTrick();
        }
    
        void aiResponseTrick()
        {
            if(trumpCard != null && humanPlayer.playedCard != null)
            {
                
                GenerateList(currentTrump, humanPlayer.playedCard.cardSuiteNum);
                
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
                            aiPlayer.playedCard = card;
                            aiPlayer.cardsInHand.Remove(card);
                            break;
                        }
                    }
                    if (!playCard)
                    {
                        
                        aiPlayer.playedCard = playableCards[0];
                        aiPlayer.cardsInHand.Remove(playableCards[0]);
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
                            aiPlayer.playedCard = card;
                            aiPlayer.cardsInHand.Remove(card);
                            break;
                        }
                    }
                    if (!playCard)
                    {
                        aiPlayer.playedCard = aiPlayer.cardsInHand[0];
                        aiPlayer.cardsInHand.Remove(aiPlayer.cardsInHand[0]);
                        
                    }
                    
                }
                if(aiPlayer.playedCard != null)
                {
                    form.displayAIPlayedCard(aiPlayer.playedCard);
                }
                
                determineTrickWinner();
            }

        }
        
        void playerResponseTrick()
        {
            bool validCards = false;
            
            List<Card> playableCards = new List<Card>();
            if (aiPlayer.playedCard != null)
            {
                GenerateList(currentTrump, aiPlayer.playedCard.cardSuiteNum);
                foreach (var item in humanPlayer.cardsInHand)
                {
                    if(item.cardSuiteNum == aiPlayer.playedCard.cardSuiteNum)
                    {
                        validCards = true;
                        playableCards.Add(item);
                    }
                }
                if (validCards)
                {
                    form.addNewItemsToCardsToPlay(playableCards);
                }
                else
                {
                    form.addNewItemsToCardsToPlay(humanPlayer.cardsInHand);
            
                }
            }
        }

        public void playerResponded(int index)
        {
            //TODO: function that is implemented when the player has played a card in response.
            //must set the players played card to the one they played and remove that card from their hand.
            //then compare cards. - NW

            bool validCards = false;
            List<Card> playableCards = new List<Card>();
            if (aiPlayer.playedCard != null)
            {
                foreach (var item in humanPlayer.cardsInHand)
                {
                    if (item.cardSuiteNum == aiPlayer.playedCard.cardSuiteNum)
                    {
                        validCards = true;
                        playableCards.Add(item);
                    }
                }
                if (validCards)
                {
                    humanPlayer.playedCard = playableCards[index];
                    humanPlayer.cardsInHand.Remove(humanPlayer.playedCard);
                }
                else
                {
                    humanPlayer.playedCard = humanPlayer.cardsInHand[index];
                    humanPlayer.cardsInHand.Remove(humanPlayer.playedCard);

                }
            }
            determineTrickWinner();


        }

        /// <summary>
        /// Function that compares two cards to determine which one is better in the current euchre context.
        /// </summary>
        /// <param name="cardOne">the first card</param>
        /// <param name="cardTwo">the second card</param>
        /// <returns>true if the first card is better, false if the second card is better.</returns>
        bool compareCards(Card cardOne, Card cardTwo)
        {
            bool firstCardWins = true;
            foreach (var item in winningcards)
            {
                if (item.Equals(cardOne))
                {
                    firstCardWins = true;
                    //form.addToHistory("this card wins " + cardOne.toString());
                    break;
                }
                else if (item.Equals(cardTwo))
                {
                    firstCardWins = false;
                    //form.addToHistory("this card wins " + cardTwo.toString());
                    break;
                }
            }

            return firstCardWins;
        }





        /// <summary>
        /// Function that determines who won the trick.
        /// </summary>
        void determineTrickWinner()
        {
            bool humanWins;
            if (humanPlayer.playedCard != null && aiPlayer.playedCard != null)
            {
                humanWins = compareCards(humanPlayer.playedCard, aiPlayer.playedCard);  

                if (humanWins)
                {
                    form.addToHistory("Human played " + humanPlayer.playedCard.toString() + " AI played " + aiPlayer.playedCard.toString() + " Human won!");
                    aiPlayer.isMaker = false;
                    humanPlayer.isMaker = true;
                    humanPlayer.tricksWon++;
                    form.trickCounterLabelHuman(humanPlayer.tricksWon);
                }
                else
                {
                    form.addToHistory("Human played " + humanPlayer.playedCard.toString() + " AI played " + aiPlayer.playedCard.toString() + " AI won!");
                    humanPlayer.isMaker = false;
                    aiPlayer.isMaker = true;
                    aiPlayer.tricksWon++;
                    form.trickCounterLabelAI(aiPlayer.tricksWon);
                }

                // Determine wheter the round is over.
                if((aiPlayer.tricksWon + humanPlayer.tricksWon) < 5)
                {
                    form.clearTextBoxes();
                    playATrick();
                }
                else
                {
                    form.clearTextBoxes();
                    roundEnd();
                }
            }
            
        }

        /// <summary>
        /// Function that determines who won the round then allocates points. If a player has enough points to
        /// win it triggers their victory. If no player has enough points to win it starts another round.
        /// </summary>
        void roundEnd()
        {
            // Determine winner and add points.
            if(humanPlayer.tricksWon > aiPlayer.tricksWon)
            {
                humanPlayer.addPoints();
            }
            else
            {
                aiPlayer.addPoints();
            }

            // Determine if a player has enough points to win the game.
            if (humanPlayer.points >= pointsToWin)
            {
                //TODO: Make a victory thing - IL
                MessageBox.Show("Congratulations! You win the game!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (aiPlayer.points >= pointsToWin)
            {
                //TODO: Make a loss thing. - IL
                MessageBox.Show("Sorry! You lose the game!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Start a new round.
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
                form.comboBoxPlayCard.SelectedIndex = -1;
                form.comboBoxPlayCard.Text = string.Empty;
                stage = 1;
                gameStage();
            }
        }

    }
}
