using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CardDeckApp.Models
{
    public class DeckOfCards
    {

        private string _name;
        private IEnumerable<Card> cards;

        [JsonIgnore]
        public IDeckOfCardsValidator deckOfCardsValidator { get; set; } = new GeneralDeckOfCardsValidator();


        public string Name
        {
            get => _name;
            set
            {
                if (value == null)
                {
                    _name = "Колода без названия";
                }
                else
                {
                    _name = value;
                };
            }
        }

        public bool IsSorted
        {
            get
            {
                if (cards != null && cards.Count() > 0)
                {
                    return Cards.SequenceEqual(Cards.OrderBy(c => c.PriorityNumber));
                }
                return false;
            }
        }

        public IEnumerable<Card> Cards
        {
            get => cards;
            set
            {


                if (deckOfCardsValidator.IsValid(value))
                {
                    cards = value;
                }
                else
                {
                    cards = new List<Card>();
                    Console.WriteLine("\nКолода не удовлетворяет условиям!\nСоздана пустая колода!");
                }


            }
        }

        public DeckOfCards(string n, IEnumerable<Card> cards)
        {

            Name = n;
            this.Cards = cards;

        }


        public void AddCard(Card card)
        {
            List<Card> cardsList = new List<Card>(Cards);
            cardsList.Add(card);
            if (deckOfCardsValidator.IsValid(cardsList))
            {
                Cards = cardsList;
            }
            else
            {
                Console.WriteLine("\nОшибка при добавлении карточки!");
            }
        }
    }
}
