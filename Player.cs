using System;
using System.Collections.Generic;


namespace deck_of_cards
{
    class Person
    {
        public string Name {get;set;}
        public List<Card> hand = new List<Card>();

        public Person(string name)
        {
            Name=name;
        }

        public Card Draw(Deck deck)
        {
            Card addCard = deck.Deal();
            hand.Add(addCard);
            return addCard;

        }

        public Card Discard(int indexRemove)
        {
            if(indexRemove > hand.Count-1 || indexRemove < 0)
            {
                System.Console.WriteLine("Invalid Index position");
                return null;
            }
            else
            {
                Card cardRemove = hand[indexRemove];
                hand.RemoveAt(indexRemove);
                System.Console.WriteLine("The card removed has a strval of {0} val of {1} and suit of {2}", cardRemove.StringVal, cardRemove.Val, cardRemove.Suit);
                return cardRemove;                
            }
        }
    }
}