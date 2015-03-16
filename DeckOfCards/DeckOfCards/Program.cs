using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
       
        //defining my random number generator
        
        Random rng = new Random();

        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0, -19}", deck1.DealCard().CardStirng());
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }

            Console.ReadKey();

        }
    }


    class Deck
    {
        
        //defining my properties for the deck of cards and discarded cards
        public List<Card> DeckOfCards { get; set;}
        public List<Card> DiscardedCards {get; set;}
        public int CardsRemaining = 52;
        
        //this is the information for the begining deck of cards to build it.  
        public Deck()
        {
            this.DeckOfCards = new List<Card>();
            this.DiscardedCards = new List<Card>();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 14; j++)
                {
                    this.DeckOfCards.Add(new Card((Rank)i, (Suit)j ));
                }
            }
        }
        
        //this is the code on how to shuffel the deck of card after it is made
        public string Shuffel(List<string> DeckOfCards)
        {
            List<Card> suffeledDeckOfCards = new List<Card>();
            Random rng = new Random();
            int shuffel = 1;

            shuffel = rng.Next(1, 53);

            for (int i = 1; i <= 52; i++)
            {
                suffeledDeckOfCards.Add(i.ToString());
            }



        }
        
        //dealing the cards and keeping a list of the cards that have been drawn
        public List<Card> Deal(int numberOfCards)
        {
            List<Card> cardsToDeal = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                Card drawn = this.DeckOfCards.Last();
                //Add cards to list
                cardsToDeal.Add(drawn);
                //remove cards
                this.DeckOfCards.Remove(drawn);
            }
            return cardsToDeal;

        }

        
        //getting rid of a card and keeping track of the amount of cards left.  
        public string Discard(Card card) 
        {
            if (CardsRemaining < DeckOfCards.Count)
            {
                return DeckOfCards[CardsRemaining++];
            }
            else
            {
                return null;
            }

        }

             
    }

    //this is the information to actually build a specific card, suit and rank.  
    class Card
    {
       enum Rank
        {
         Two = 2,
         Three,
         Four,
         Five,
         Six,
         Seven,
         Eight,
         Nine,
         Ten,
         Jack, 
         Queen,
         King,
         Ace 
        }   

        enum Suit
        {
            Hearts = 1,
            Diamonds,
            Spades,
            Clubs
        }

        public Rank CardRank { get; set; }
                
        public Suit CardSuit { get; set; }

        public Card (Rank rank,  Suit suit)
            {
                this.CardRank = rank;
                this.CardSuit = suit;        
            }
        
        //this allows the card to have a rank and a suit.  
        public string CardString()
        {
            this.Rank + "of" + this.Suit;
        }





    }   

}
