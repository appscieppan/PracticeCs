/*
using System;
using System.Collections.Generic;

namespace _20190310{
    class Dictionary{
        static void Main(){
            Dictionary<string, int> users = new Dictionary<string, int>(){
                {"taguchi", 50},
                {"uchi", 80},
            };
            users.Add("dotinstall", 40);
            Console.WriteLine(users["uchi"]); // 80
            users["taguchi"] = 60;
            foreach(KeyValuePair<string, int> user in users){
                Console.WriteLine($"{user.Key}:{user.Value}");
            }
        }
    }
}
*/