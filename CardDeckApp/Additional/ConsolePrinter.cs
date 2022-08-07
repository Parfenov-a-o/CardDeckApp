using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Additional
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(DeckOfCards deck)
        {
            if(deck.Name!=null && deck.Cards!=null)
            {
                Console.WriteLine($"\nНазвание колоды: {deck.Name}" +
                  $"\nКоличество карт в колоде: {deck.Cards.Count()}");

                if (deck.Cards.ToList().Count > 0)
                {
                    foreach (var card in deck.Cards)
                    {
                        Console.WriteLine($"Карта: \"{card.Name}\" Ранг: {card.PriorityNumber}");
                    }
                }

                if (deck.IsSorted)
                {
                    Console.WriteLine("Отсортирована ли колода: Да");
                }
                else
                {
                    Console.WriteLine("Отсортирована ли колода: Нет");
                }
            }



        }
    }
}
