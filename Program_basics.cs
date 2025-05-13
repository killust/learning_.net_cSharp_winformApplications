//Working with the basics in C#
Console.WriteLine("Hello World");
Console.WriteLine("CodeMonkey");


//Working with variables
int age = 32, health = 100, speed = 5;
Console.WriteLine(age);
age = age + 1;
Console.WriteLine(age);
age++;
Console.WriteLine(age);
age += 1;
Console.WriteLine(age);

Console.WriteLine(age + ", " + health + ", " + speed);
Console.WriteLine(age + health);

double Age = 35.5;
Console.WriteLine(Age);
float position = 35.5f;
Console.WriteLine(position);
string name = "Code Monkey";
Console.WriteLine(Age);
Console.WriteLine("My name is " + name + " I am " + age + " years old.");

Console.WriteLine("My name is name I am age years old.");

Console.WriteLine($"My name is {name} I am {age} years old.");

Console.WriteLine("My name is \"Code Monkey\".");

char character = 'a';

bool isPlayer = true;
bool isEnemy = false;

var myVariable = 10;
var myVariable1 = 10.2;
var myVariable2 = 10.3f;
var myVariable3 = false;
var myVariable4 = "false";
var myVariable5 = 'a';


Console.WriteLine(5 + 6 + " Number");
Console.WriteLine("Number " + 5 + 6);



//Type Conversion
int ageUniverseInt = 12;
long ageUniverse = ageUniverseInt;

int ageInt = (int)35.9f;
Console.WriteLine($"{ageInt}  {ageUniverseInt}");



int h = 1;
int hmax = 10;
Console.WriteLine(h / hmax);
Console.WriteLine((float)h / hmax);


string o = "43";
var y = Convert.ToInt32(o);
Console.WriteLine(y);



//Working with conditionals
bool isplayer = false;
if ((true && false) || (true && false))
{
    Console.Write("Inside if\n");
}
else 
{
    Console.WriteLine("Not inside if");
}


//In C# indentation does not matter
if(false)
     Console.WriteLine("Inside if");
     Console.WriteLine("Inside if2");



if (false)
{
    Console.WriteLine("Inside if");
    Console.WriteLine("Inside if2");
}



if (age > 30)
{
    Console.WriteLine("your age is greater than 30");
}
else if (age == 30)
{
    Console.WriteLine("your age is than 30");
}
else 
{
    Console.WriteLine("You are still young");
}

//Working with switch

string names = "Mohsin";
switch (names) 
{
    case "Ali":
        Console.WriteLine("Hello Ali");
        break;
    case "derwaish":
        Console.WriteLine("Hello derwaish");
        break;
    case "Mohsin":
    case "sadoon":
        Console.WriteLine("Hello sadoon");
        break;
    default:
        Console.WriteLine("Wrong name");
        break;
}