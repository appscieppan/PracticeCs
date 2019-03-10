using System;

namespace _20190310{
    class User{
        public string name;
        public User(string name){
            this.name = name;
        }
        public User():this("nobody"){
        }
        public virtual void SayHi(){
            Console.WriteLine($"hi {name}");
        }
    }

    class AdminUser: User{
        //コンストラクタは継承されないこれだけでは。
        //以下の表記が必要
        public AdminUser(string name): base(name){
        }
        public void SayHello(){
            Console.WriteLine($"Hello{name}");
        }

        public override void SayHi(){
            Console.WriteLine($"[admin]hi{name}");
        }
    }
    class MyApp{
        static void Main(){
            User tom = new User("Tom");
            tom.SayHi();
            AdminUser bob = new AdminUser("Bob");
            bob.SayHi();
            bob.SayHello();

        }
    }
}
