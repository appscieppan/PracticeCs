/* 
using System;
using _20190310;

//delegate
delegate void MyDelegate();

class Dele{

    static void SayHi(){
        Console.WriteLine("hi!");
    }
    static void SayHello(){
        Console.WriteLine("hello!");
    }

    static void Main(){
        MyDelegate ShowMessage;
        ShowMessage = SayHi;
        ShowMessage += SayHello;
        ShowMessage();
    }
}
*/