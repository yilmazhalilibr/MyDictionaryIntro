using System;

namespace MyDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Halil",25);
            myDictionary.Add("Ahmet", 18);
            myDictionary.Add("Engin", 35);
            myDictionary.Add("Murat", 49);





            Console.WriteLine(myDictionary.DictKey.Length);
            Console.WriteLine(myDictionary.DictValue.Length);
            Console.ReadLine();

        }
    }

}
