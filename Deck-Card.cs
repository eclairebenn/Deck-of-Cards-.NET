using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Card
    {
        public string StringVal {get;set;}
        public int Val {get;set;}
        public string Suit {get;set;}

        public Card(string sval, int val, string suit)
        {
            StringVal = sval;
            Val = val;
            Suit = suit;
        }
    }

    class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            Dictionary<string, int> identity = new Dictionary<string, int>();
            string[] cardStr = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for(int v = 1; v<14; v++)
            {
                identity.Add(cardStr[v-1], v);
            }

            string[] cardSuit = {"Clubs", "Spades", "Hearts", "Diamonds"};

            foreach (KeyValuePair<string, int> entry in identity)
            {
                foreach(string suits in cardSuit)
                {
                    Card newCard = new Card(entry.Key, entry.Value, suits);
                    cards.Add(newCard);
                }
            }
        }

        public Card Deal()
        {
            Card dealCard = this.cards[0];
            this.cards.RemoveAt(0);
            return dealCard;
        }

        public void Reset()
        {
            this.cards.Clear();
            this.cards = new Deck().cards;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int idx=0; idx < cards.Count; idx++)
            {
                int swapidx = rand.Next(0,cards.Count-1);
                Card temp = cards[idx];
                cards[idx] = cards[swapidx];
                System.Console.WriteLine("new card str val is {0} val is {1} and suit is {2}", cards[idx].StringVal, cards[idx].Val, cards[idx].Suit);
                cards[swapidx] = temp;
            }
        }
    }
}
