using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CardDeckApp.Additional
{
    public class JsonFileWriter
    {
        public void Write(IEnumerable<DeckOfCards> decksList)
        {
            try
            {
                Console.WriteLine("\nЗапуск сериализации данных...");

                string json = JsonConvert.SerializeObject(decksList);

                Console.WriteLine("\nДанные успешно сериализованы!");

                Console.WriteLine("\nРезультат сериализации данных:");

                Console.WriteLine(json);

                Console.WriteLine("\nНачало записи в текстовый файл...");

                using(StreamWriter writer = new StreamWriter("save_file.txt",false))
                {
                    writer.Write(json);
                }

                Console.WriteLine("\nДанные успешно записаны в файл!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nОшибка при записи в файл!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
