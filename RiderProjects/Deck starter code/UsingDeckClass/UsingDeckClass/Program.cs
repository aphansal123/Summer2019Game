using System;

namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // create and print a deck of cards
            Deck deck = new Deck();
            deck.Print();
        }
    }
}
