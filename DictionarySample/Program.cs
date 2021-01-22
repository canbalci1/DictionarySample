using System;
using System.Collections.Generic;


namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("App", "Apple");
            dictionary.Add("Hua", "Huawei");
            dictionary.Add("Sam", "Samsung");
            dictionary.Add("Xao", "Xaomi");

            

            foreach (var item in dictionary)
            {
                //Tüm Sözlük
                Console.WriteLine(item);
                //Sadece Kısaltma
                Console.WriteLine(item.Key);
                //Sadece Tam İsim
                Console.WriteLine(item.Value);
            }
            //Sözlükte olup olmadığını sorgulama 
            Console.WriteLine(dictionary.ContainsKey("Sny"));
            Console.WriteLine(dictionary.ContainsKey("Sony"));
        }
    }
}
