
using CardGame.Enums;
using CardGame.Models;

namespace CardGame
{
    // This mini project helps us practice Access Modifiers, Abstract Classes and Methods,
    // and Method Overriding

    // We build the base class for Card Game and then create two types of Card Games,
    // Poker and BlackJack

    class Program
    {
        static void Main(string[] args)
        {
            // Check what methods player will have access to when playing Poker
            PokerDeck pokerDeck = new PokerDeck();
            List<PlayingCardModel> pokerHand = new List<PlayingCardModel>();

            pokerDeck.ShuffleDeck();
            pokerHand = pokerDeck.DealCards();
            pokerDeck.RequestCards(pokerHand.Take(2).ToList());


            BlackjackDeck blackjackdeck = new BlackjackDeck();
            var hand = blackjackdeck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit");
            Console.ReadLine();
        }
    }

    // Deck is a base class that every Card Game needs to have.
    // We will use the standard poker deck:
    //  - 4 suits
    //  - Ace through 10 plus Jack, Queen and King
    public abstract class Deck
    {
        // Because we have some abstract methods in this class. We need to access
        // the variables in this class ==> protected, not private
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        // Not changing between different types of card games
        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }

        // Different types of card games may shuffle the deck differently ==> virtual
        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }

        // Need a method to deal card, but it will be vary depending on different
        // types of card games (e.g. 5 cards for a hand in poker, 2 cards for blackjack)
        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            // Take() returns a specified number of contiguous elements from a
            // start of a sequence - IEnumerable type.
            // First() returns the first element of a sequence.
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);

            return output;

        }
    }

    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        // We will simplify this and give 5 cards to each person all at once.
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> playerHand = new List<PlayingCardModel>();

            for (int i = 0; i < 5; i++)
            {
                playerHand.Add(DrawOneCard());
            }

            return playerHand;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> playerHand = new List<PlayingCardModel>();

            foreach (var card in cardsToDiscard)
            {
                playerHand.Add(DrawOneCard());
                playerHand.Remove(card); //-- I added this line. Need to discard that card from player's hand
                discardPile.Add(card);
            }

            return playerHand;
        }
    }

    public class BlackjackDeck : Deck
    {
        public BlackjackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> playerHand = new List<PlayingCardModel>();

            for (int i = 0; i < 2; i++)
            {
                playerHand.Add(DrawOneCard());
            }

            return playerHand;
        }

        // In Blackjack, we can only draw one card at a time
        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
