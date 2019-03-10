/**
using System;
using _20190310;

namespace _20190310{
    //構造体
    // 継承ができない
    //　メモリの使い方
    struct Point{
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y){
            X = x;
            Y = y;
        }

        public void GetInfo(){
            Console.WriteLine($"({X}:{Y})");
        }
    }
}
class Str{
    static void Main(){
        Point p1 = new Point(5, 3);
        Point p2 = new Point(12, 3);
        p1.GetInfo();
        p2.GetInfo();
    }
}
*/