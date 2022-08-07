using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CardDeckApp.Additional
{
    public class JsonFileReader
    {
        public IEnumerable<DeckOfCards> Read(string path)
        {
            try
            {

                string json;

                Console.WriteLine("\nНачало чтения состояния из файла...");

                using (StreamReader reader = new StreamReader(path))
                {
                    json = reader.ReadToEnd();
                }

                Console.WriteLine("\nДанные успешно считаны из файла!");

                Console.WriteLine("\nСодержимое файла:");

                Console.WriteLine(json);

                Console.WriteLine("\nНачало десериализации...");

                List<DeckOfCards> restoredDeck = JsonConvert.DeserializeObject<List<DeckOfCards>>(json);


                Console.WriteLine("\nДанные успешно десериализованы!");

                return restoredDeck;


            }
            catch (Exception ex)
            {
                Console.WriteLine("\nОшибка при чтении состояния из файла!");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
