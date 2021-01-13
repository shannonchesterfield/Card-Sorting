using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sorting_Cards
{
    class DealCards : Deck
    {  
        private Card[] playerHand;
        private Card[] sortedplayerHand;

        public DealCards()
        {
            //declaring that a players hand will only contain 5 cards and creating an array to hold the players hand as well as an array to hold the items once sorted
            playerHand = new Card[5];
            sortedplayerHand = new Card[5];
        }
        //this method will deal a player a hand of unsorted cards
        public void DealUnsorted()
        {
            setUpDeck();
            getHand();
            displayCards();
        }

        public void getHand()
        {
            //looping to "draw" cards from the top of the "deck"
            for (int i = 0; i < 5; i++)
            {
                playerHand[i] = getDeck[i];
            }
        }

        public void sortCards()
        {
            //I thought this would be a good time to utilize the LINQ functionalities, because I like the integrated querying system
            var sorter = from hand in playerHand
                              orderby hand.MyValue
                              select hand;
            //once the sorter is finished, we just copy those values to the sorted player hand
            var index = 0;
            foreach(var element in sorter.ToArray())
            {
                sortedplayerHand[index] = element;
                index++;
            }
            //printing each item in the newly populated array
            foreach (var item in sortedplayerHand)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void displayCards()
        {   //I probably could have created a special case within this method so we can do all of the display functions here
            //but to save time and hair pulling, I just created this class to display the unsorted player hand
            foreach (var item in playerHand)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
