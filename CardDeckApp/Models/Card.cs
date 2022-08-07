using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckApp.Models
{
    public class Card
    {
        //Имя карты
        public string Name { get; init; }
        //Номер карты
        public int PriorityNumber { get; init; }

        public Card(string n, int PN)
        {
            Name = n;
            PriorityNumber = PN;
        }


    }
}
