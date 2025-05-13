namespace CodeMonkeyHelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");
            
            
            //Working with functions
            SayHello("derwaish", addnumbers(12, 10));
            int age = 22;
            age = SayHello("Ali", age);
            Console.WriteLine(age);
            SayHello("Fouzan", 23);
            SayHello("Anas", 22);
            SayHello("Malik", 24);
            Console.WriteLine(addnumbers(1, 2));
            int number = addnumbers(1, 2, 3);
            Console.WriteLine(number);
            Console.WriteLine($"{IsPositive(5)}; {IsPositive(-2)}");

            //Working with arrays and lists
            int[] numbersArray = new int[]{56, 123, 12 };
            int[] egArray = new int[5];
            Console.WriteLine("The length of the numbers Array is: " + numbersArray.Length);
            Console.WriteLine("The length of the egArray is: " + egArray.Length);
            Console.WriteLine(numbersArray[0]);
            Console.WriteLine(System.Array.IndexOf(numbersArray, 123));


            List<int> numberList = new List<int>();
            Console.WriteLine(numberList.Count); 
            numberList.Add(12);
            numberList.Add(112);
            Console.WriteLine(numberList.Contains(112));
            Console.WriteLine(numberList.IndexOf(12));
            Console.WriteLine(numberList.IndexOf(11));
            Console.WriteLine(numberList[0]);
            numberList.RemoveAt(1);
            Console.WriteLine(numberList.Count);



            //Working with loops
            
            
            /*while (true) {
                Console.WriteLine("Something");
            }*/
            
            int i = 0;
            //int i = 5;
            while (i < 3) { 
                Console.WriteLine("Something " + i);
                i++;
            }


            i = 0;
            do
            {
                Console.WriteLine("Do While Loop " + i);
                i++;
            } while (i < 3);


            for (int j = 0; j < 3; j++) { 
                Console.WriteLine("For loop " + j);
            }

            // string[] name = new string[] { "Derwaish", "Fouzan", "Ali", "Anas" };
            List <string> name = new List<string>() { "Derwaish", "Fouzan", "Ali", "Anas" };


            for (int k = 0; k < name.Count; k++) {
                //Console.WriteLine(name[k]);
                Console.WriteLine(name[k]);

            }


            foreach (string na in name) { 
                Console.WriteLine(na);
            }



        }


        static int SayHello(string player, int age)
        {
            //return;
            age++;
            Console.WriteLine($"Hello {player} who is {age}");
            return age; 
        }
        static int addnumbers(int num1, int num2)
        {
            return num1 + num2; 
        }
        static int addnumbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static bool IsPositive(int x) 
        {
            /*if (x >= 0)
            {
                return true;
            }
            else 
            {
                return false;
            }*/

            return x >= 0;
        }
    }
}
