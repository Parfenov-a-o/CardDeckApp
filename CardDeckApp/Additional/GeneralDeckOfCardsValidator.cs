using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Additional
{
    public class GeneralDeckOfCardsValidator : IDeckOfCardsValidator
    {
        private readonly int _maxCardsCount = 100;

        public bool IsValid(IEnumerable<Card> cards)
        {
            if(cards.Count()>0)
            {
                return ((cards.Count() < _maxCardsCount) && !(cards.Select(c => c.Name).Distinct().Count() < cards.Count()));
            }
            return false;
            
        }
    }
}
