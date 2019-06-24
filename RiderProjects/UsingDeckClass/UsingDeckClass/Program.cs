using System;

namespace UsingDeckClass {
    class Program {
        public static void Main(string[] args) {
            
            // create and print a deck of cards
            Deck deck = new Deck();
            // deck.Print();
            Console.WriteLine();
            
            // access and print Empty value
            bool deckEmpty = deck.Empty;
            Console.WriteLine("Deck Empty: " + deckEmpty);

            Console.WriteLine();
            
            // shuffle the deck
            deck.Shuffle();
            deck.Print();
            
            // cut the deck at the middle
            Console.WriteLine();
            deck.Cut(26);
            deck.Print();

            Card topCard = deck.TakeTopCard();

            Console.WriteLine("Top card: " + topCard.Rank + 
                              " of " + topCard.Suit);
        }
    }
}