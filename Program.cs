using System;
using System.Collections.Generic;

namespace RulesOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = new Dictionary<string, string>()
            {
                {"D","&"},
                {"Z","+"},
                {"I","ID|D"},
                {"R","I"},
                {"V","VD"},
                {"H","(A)|R|U"},
                {"U","U^H|H"},
                {"T","U"},
                {"A","AZT|ZT|T"},
                {"B","A"},
                {"A","S"}
            };

            Console.WriteLine("Hello World!");
        }
    }
}
