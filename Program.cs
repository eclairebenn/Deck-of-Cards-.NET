using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck firstDeck = new Deck();
            firstDeck.Deal();
            firstDeck.Reset();
            firstDeck.Shuffle();
            Person firstPerson = new Person("Jimmy");
            firstPerson.Draw(firstDeck);
            firstPerson.Draw(firstDeck);
            firstPerson.Draw(firstDeck);
            firstPerson.Draw(firstDeck);
            firstPerson.Draw(firstDeck);
            firstPerson.Discard(3);
            firstPerson.Discard(0);
            firstPerson.Discard(300);
            firstPerson.Discard(-1);

        }
    }
}
