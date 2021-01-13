using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sorting_Cards
{
    class Card
    {   //I created these enumerators so we have a list of constants to see what is available, this comes in handy later in the Deck class (lines 22 - 33)
        public enum Suit 
        { Hearts = 1, 
          Diamonds = 2, 
          Clubs = 3, 
          Spade = 4}
        public enum Value
        {
            Two = 2, 
            Three = 3, 
            Four = 4, 
            Five = 5, 
            Six = 6, 
            Seven = 7, 
            Eight = 8, 
            Nine = 9, 
            Ten = 10, 
            Jack = 11, 
            Queen = 12, 
            King = 13, 
            Ace = 14
        }
       
        //properties
        public Suit MySuit { get; set; }
        public Value MyValue { get; set; }
        //overriding the ToString method so the output looks exactly how I want it to
        public override string ToString()
        {
            return MyValue + " of " + MySuit;
        }
    }
}
