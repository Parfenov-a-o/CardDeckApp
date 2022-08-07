using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        IPrinter printer = new ConsolePrinter();
        IMixer mixerRand = new RandomMixer();
        IMixer mixerSortAsc = new AscendingSortedMixer();
        IDeckOfCardsValidator deckOfCardsValidator = new GeneralDeckOfCardsValidator();

        List<DeckOfCards> decksList = new List<DeckOfCards>();

        List<Card> cards1 = new List<Card>()
        {
            new Card("4 буби", 4),
            new Card("5 крести", 5),
            new Card("6 черви", 6),
            new Card("3 крести", 3),
            new Card("2 крести", 2),
            new Card("Король крести", 13),
        };


        List<Card> cards2 = new List<Card>()
        {
            new Card("4 буби", 4),
            new Card("5 крести", 5),
            new Card("8 черви", 8),
            new Card("2 черви", 2),
            new Card("3 крести", 3),
            new Card("10 крести", 10),
            new Card("Король крести", 13),
        };

        List<Card> cards3 = new List<Card>()
        {
            new Card("Шут", 57),
            new Card("Маг", 58),
            new Card("Мир", 76),
            new Card("Солнце", 74),
            new Card("Башня", 71),
        };

        decksList.Add(new DeckOfCards("Стандартная колода 1", cards1));
        decksList.Add(new DeckOfCards("Стандартная колода 2", cards2));
        decksList.Add(new DeckOfCards("Стандартная колода 3", cards3));

        foreach(var deck in decksList)
        {
            Console.WriteLine("\nИнформация о колоде:");
            printer.Print(deck);

            Console.WriteLine("\nСортировка в порядке возрастания:");
            mixerSortAsc.Mix(deck);
            printer.Print(deck);

            Console.WriteLine("\nСортировка в случайном порядке:");
            mixerRand.Mix(deck);
            printer.Print(deck);

            Console.WriteLine("---------------------------------------");
        }


        JsonFileWriter writer = new JsonFileWriter();

        writer.Write(decksList);

        Console.WriteLine("---------------------------------------");

        JsonFileReader reader = new JsonFileReader();

        List<DeckOfCards> restoredDeck = reader.Read("save_file.txt")?.ToList();

        Console.WriteLine("---------------------------------------");

        if (restoredDeck?.Count > 0)
        {
            Console.WriteLine("Результаты десериализации:");
            foreach (var deck in restoredDeck)
            {
                printer.Print(deck);
            }
        }


    }
}
