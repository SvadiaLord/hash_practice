using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_practice1
{
    public class HashTableExample
    {
        private Dictionary<string, int> _hashTable;
        public HashTableExample()
        {
            _hashTable = new Dictionary<string, int>();
        }
        public void Add(string key, int value) //Добавление элемента
        {
            if (_hashTable.ContainsKey(key))
            {
                Console.WriteLine($"Ключ '{key}' уже существует. Обновление.");
            }
            _hashTable[key] = value;
        }
        public int Get(string key) //Получение значения
        {
            if (_hashTable.TryGetValue(key, out int value))
            {
                return value;
            }
            else
            {
                throw new KeyNotFoundException($"КлЮч '{key}' не найден.");
            }
        }

        public void Remove(string key) //Удаление элемента
        {
            if (_hashTable.Remove(key))
            {
                Console.WriteLine($"Ключ: '{key}' успешно удалён.");
            }
            else
            {
                Console.WriteLine($"Ключ: '{key}' не найден для удаления.");
            }
        }
        public void Display() //Отображение таблицы
        {
            Console.WriteLine("Содержимое hash-таблицы.");
            foreach (var kvp in _hashTable)
            {
                Console.WriteLine($"Ключ: '{kvp.Key}, значение: {kvp.Key}");
            }
        }
        public List<string> GetKeys() //Список для возвращения ключей
        {
            return new List<string>(_hashTable.Keys);
        }
        public void
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTableExample hashTableExample = new HashTableExample();

            hashTableExample.Add("broken arrow", 1);
            hashTableExample.Add("arma3", 2);
            hashTableExample.Add("warno", 3);

            hashTableExample.Display();

            try
            {
                Console.WriteLine($"Значение для 'banana': {hashTableExample.Get("arma3")}");
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            hashTableExample.Remove("warno");
            hashTableExample.Display();

            List<string> keys = hashTableExample.GetKeys();
            Console.WriteLine("Все ключи: ");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
