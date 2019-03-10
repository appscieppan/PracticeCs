/*
using System;
using _20190310;

class Ram{
    static void Main(){

        MyDelegate ShowMessage;

        //匿名メソッド
        ShowMessage = delegate{
            Console.WriteLine("hi");
        };
        //ラムダ式 引数=>処理
        ShowMessage += () =>{
            Console.WriteLine("Hello");
        };

        ShowMessage();

    }
}
*/