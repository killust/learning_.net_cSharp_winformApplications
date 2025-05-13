//Working with classes

namespace CodeMonkeyHelloWorld3
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit IronMan = new Unit("IronMan");
            Unit SuperMan = new Unit("SuperMan");
            Console.WriteLine(IronMan.GetHashCode() + " " + SuperMan.GetHashCode());
            //IronMan.name = "Derwaish";
            IronMan.SayHello();
            
            
            //Working with static

           /* Player.SayHello();
            new Player("CodeMonkey");
            Player.SayHello();
            new Player("IronMan");
            Player.SayHello();*/






        }


        private class Unit 
        {
            private string name = "--";
            public Unit(string name)
            {
                this.name = name;
                Console.WriteLine($"Constructing a player! {name}");

                SayHello();
            }

            public void SayHello() 
            {
                Console.WriteLine($"Hello! {name}");
            }


        }
    }
}
