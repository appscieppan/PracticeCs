using System;
using System.Collections.Generic;
using System.Linq;

namespace _20190310{
    class LinQ{
        static void Main(){
            List<double> prices = new List<double>(){
                53.2,
                48.2,
                32.8
            };
            //SQL
            var results1 = from price in prices
                where price * 1.08 > 50.0
                select price * 1.08;

            //Method
            var results2 = prices
                .Select(n => n * 1.08)
                .Where(n => n > 50.0);

                foreach(var result in results1){
                    Console.WriteLine(result);
                }
                
                foreach(var result in results2){
                    Console.WriteLine(result);
            }
        }
    }
}