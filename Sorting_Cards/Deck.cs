using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sorting_Cards
{   //I wanted the deck class to inherit everything form the Card class, to keep things simple and to avoid having to redundantly reference everything
    class Deck : Card
    {
        //declaring the number of total cards available
        const int NUMBER_OF_CARDS = 52;
        //creating an array to hold all cards
        public Card[] deck;
        //in lines 15-19 I created this constructor which declares that a "deck" will always consist of a constant amount of cards (52 in this scenario)
        public Deck()
        {
            deck = new Card[NUMBER_OF_CARDS];

        }
        //retrieves deck of cards once it is populated, so we may "draw" from it later in the DealCards class
        public Card[] getDeck { get { return deck; } }
        public void setUpDeck()
        {
            int i = 0;
            //this foreach loop will create cards of every value and suit, using my enumerator from the Card class as a reference
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach(Value v in Enum.GetValues(typeof(Value)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            //this method can be called outside of setupDeck, but I chose to shuffle it as soon as the deck is created
            ShuffleCards();
        }
        //the ShuffleCards method takes advantage of the Fisher-Yates shuffling algorithm 
        //URL to the wiki for the shuffling algorithm --> https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        public void ShuffleCards()
        {
            Random r = new Random();
            Card temp;

            //run the shuffle function 1000 times, to make sure the deck is shuffled well. This can really be any number, I chose 1000 because it seemed thourough 
            for (int shuffles = 0; shuffles < 1000; shuffles++)
            {
                for (int i = 0; i < NUMBER_OF_CARDS; i++)
                {
                    //the secondCard could be any random number, but I declared 13 since there are 13 cards available in one suit
                    int secondCard = r.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCard];
                    deck[secondCard] = temp;
                }
            }
        }

    }
}
