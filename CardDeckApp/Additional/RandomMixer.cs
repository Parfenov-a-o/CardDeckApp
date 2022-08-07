using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Additional
{
    public class RandomMixer : IMixer
    {
        public DeckOfCards Mix(DeckOfCards deck)
        {
            if(deck.Cards!=null && deck.Cards.Count()>1)
            {
                Random rnd = new Random();

                List<Card> cards = new List<Card>(deck.Cards);

                for (int i = cards.Count - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);

                    var temp = cards[j];
                    cards[j] = cards[i];
                    cards[i] = temp;
                }

                deck.Cards = cards;
            }

            return deck;

        }
    }
}
