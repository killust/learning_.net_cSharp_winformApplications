using System.Reflection.Metadata;
using coreConsoleApp;

/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        continue; //break;//goto
    Console.WriteLine("Continue writing the string " + i);
}
//working with arrays
//working with single dimensional arrays
string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
foreach (string weekDay in weekDays)
    Console.WriteLine($"{weekDay}");

char[] test = { 'a', 'a', '\0', 'a' };
foreach (char testChar in test)
    Console.WriteLine($"{testChar}");

//working with Multi dimensional arrays
int[,] multiDimensionalArray = new int[4, 2]
{{1,2 }, {2,3 }, {4,5 }, {5,6 } };
foreach (int i in multiDimensionalArray)
    Console.WriteLine($"{i}");
//working with jagged arrays
int[][] jaggedArray = new int[3][];

jaggedArray[0] = [1, 3, 5, 7, 9];
jaggedArray[1] = [0, 2, 4, 6];
jaggedArray[2] = [11, 22];
Console.WriteLine(jaggedArray[1][2]);
//Working with strings 
string str1 = "Hello ";
string str2 = str1;
str1 += str2;
Console.WriteLine(str2);
string str3 = """
    My name is Derwaish
    and this is a raw string literal
    """;
Console.WriteLine(str3);


//OOP connection with Student.cs
Student student = new Student();
student.acceptDetails();
student.Display();



Square s = new Square();
s.Seta(3);
s.Setb(3);
s.Setc(3);
s.Setd(3);
Console.WriteLine(s.Geta());
Console.WriteLine(s.Getb());
Console.WriteLine(s.Getc());
Console.WriteLine(s.Getd());
Console.WriteLine("The area is: " + s.get_area());
Console.WriteLine("this is  working");*/


stringIndexerType stringIndexerType = new stringIndexerType();
stringIndexerType[0] = "string 1";
stringIndexerType[1] = "string 2";
stringIndexerType[2] = "string 3";
stringIndexerType[3] = "string 4";

for (int i = 0; i < 4; i++)
    Console.WriteLine(stringIndexerType[i]);

var f = new
{
    cyber = "Cybersecurity",
    mdk = "Muhammad Derwaish Kamran"
};
Console.WriteLine(f.cyber);
Console.WriteLine(f.mdk);


CalculateDelegate c1 = new CalculateDelegate(DelegateExample.Add);
c1(1);
c1(2);
c1 = new CalculateDelegate(DelegateExample.Mul);
c1(2);
Console.WriteLine(DelegateExample.getNumber());