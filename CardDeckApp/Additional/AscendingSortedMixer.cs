using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Additional
{
    public class AscendingSortedMixer : IMixer
    {
        public DeckOfCards Mix(DeckOfCards deck)
        {
            if(deck.Cards != null && deck.Cards.Count()>1)
            {
                deck.Cards = deck.Cards.OrderBy(c => c.PriorityNumber).ToList();
                
            }
            return deck;

        }
    }
}
