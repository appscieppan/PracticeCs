/*
using System;

namespace _20190310{
        //Generic    
        class MyInteger{
            public void GetThree(int x){
                Console.WriteLine(x);
                Console.WriteLine(x);
                Console.WriteLine(x);
            }
        }

        class MyData<T>{
            public void GetThree(T x){
                Console.WriteLine(x);
                Console.WriteLine(x);
                Console.WriteLine(x);
            }
        }

        class Gen{
            static void Main(){
                MyInteger mi = new MyInteger();
                mi.GetThree(55);
                MyData<string> s = new MyData<string>();
                s.GetThree("hello");
                MyData<double> d = new MyData<double>();
                d.GetThree(32.33);
            }
        }
}
*/