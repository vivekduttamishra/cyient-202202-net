using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListTest01();

            //we can initialize a list with few values
            //ListTest02();


            //SetTest01();

            var countryDb = new Dictionary<string, CountryInfo>();

            countryDb.Add("IN", new CountryInfo() { Name = "India", Capital = "New Delhi", Currency = "INR" });

            //we can also add new value using indexer

            countryDb["JP"] = new CountryInfo() { Name = "Japan", Capital = "Tokyo", Currency = "YEN" };
            countryDb["UK"] = new CountryInfo() { Name = "United Kigdom", Capital = "London", Currency = "GBP" };
            //DictionaryTest01(countryDb);

            foreach(var key in countryDb.Keys)
            {
                Console.WriteLine($"{key} --->  {countryDb[key]}");
            }


        }

        private static void DictionaryTest01(Dictionary<string, CountryInfo> countryDb)
        {
            Console.WriteLine($"countryDb.Count = {countryDb.Count}");
            Console.WriteLine($"countryDb.ContainsKey(IN) ----> {countryDb.ContainsKey("IN")}");
            Console.WriteLine($"countryDb.ContainsKey(DE) ----> {countryDb.ContainsKey("DE")}");


            PrintInfo(countryDb, "IN");
            PrintInfo(countryDb, "JP");

            countryDb["UK"] = new CountryInfo() { Name = "Great Britain", Capital = "London", Currency = "Pound" };
            PrintInfo(countryDb, "UK");
            PrintInfo(countryDb, "DE");
            PrintInfo(countryDb, "FR");
        }

        static void PrintInfo(Dictionary<string,CountryInfo> db, string key)
        {
            if(db.ContainsKey(key))
            {
                var country = db[key];
                Console.WriteLine($"Country : {country.Name}" );
                Console.WriteLine($"\tCapital: {country.Capital}");
                Console.WriteLine($"\tCurrency: {country.Currency}");
            }
            else
            {
                Console.WriteLine($"No country found with code : {key}");
            }
                
        }


        private static void SetTest01()
        {
            var set = new HashSet<int>() { 2, 3, 9, 2, 6 };

            //how many items are there is this set?
            Console.WriteLine($"set.Count = {set.Count}");

            Console.WriteLine($"set.Contains(9) = {set.Contains(9)}");
            Console.WriteLine($"set.Contains(5) = {set.Contains(5)}");

            foreach (var value in set)
                Console.WriteLine(value);
        }

        private static void ListTest02()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine($"number.Count = {numbers.Count}");
            Console.WriteLine($"numbers[2]   = {numbers[2]}");  //3

            //Trying to access invalid index throws error

            numbers[100] = 1;
        }

        private static void ListTest01()
        {
            var numbers = new List<int>();  //it doesn't need know how many items will come
            for (int i = 0; i < 2000; i++)
                numbers.Add(i);  //we can add as many as we like

            //it has Count instead of Length
            Console.WriteLine($"total values in the list is {numbers.Count}");

            //we can use normal for loop with indexer
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}\t");
            }

            //we can use for-each loop to access them
            // let us find the sum of all numbers
            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            Console.WriteLine($"\nsum of all numbers is {sum}");
        }
    }
}
