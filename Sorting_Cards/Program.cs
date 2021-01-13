/*Title: Card Sorting Console Application
 * Author: Shannon Chesterfield
 * Description: This program will create a deck of cards, shuffle them, and deal a hand of cards to the player. 
 * They then have the option to sort their hand of cards.
 */
using System;

namespace Sorting_Cards
{
    class Program : DealCards
    {
        
        static void Main(string[] args)
        {
            string title = @"
                        
                     _____               _      _____            _   _             
                    /  __ \             | |    /  ___|          | | (_)            
                    | /  \/ __ _ _ __ __| |    \ `--.  ___  _ __| |_ _ _ __   __ _ 
                    | |    / _` | '__/ _` |     `--. \/ _ \| '__| __| | '_ \ / _` |
                    | \__/\ (_| | | | (_| |    /\__/ / (_) | |  | |_| | | | | (_| |
                     \____/\__,_|_|  \__,_|    \____/ \___/|_|   \__|_|_| |_|\__, |
                                                                              __/ |
                                                                             |___/  ";
            Console.WriteLine(title);
            Console.WriteLine("\n*** Un-Sorted Hand ***\n");
            DealCards hand = new DealCards();
            hand.DealUnsorted();
            //I could have had this program sort the cards and then display them
            //but I wanted to emphasize what is actually happening by making the user press a button to sort the hand
            Console.WriteLine("\n*** Press Space to sort this hand ***\n");
            Console.ReadKey();
            hand.sortCards();
            Console.WriteLine("\n*** Cards have been sorted ***");
            Console.ReadKey();
            
        }
    }
}
