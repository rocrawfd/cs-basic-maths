Console.WriteLine("Welcome to the AREA CALCULATOR");

Console.Write("Please enter the length of the room in cm: ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the width of the room in cm: ");
int width = int.Parse(Console.ReadLine()!);

int roomArea = length * width;

Console.WriteLine("The area of the room is: " + roomArea +"cm");
Console.WriteLine("Press any key to move onto the NUMBER ANALYSER");
Console.ReadKey();


Console.Write("\nWelcome to the NUMBER ANALYSER");
Console.Write("\nPlease enter a number: ");
int number = int.Parse(Console.ReadLine()!);

bool isNumberEven = number%2 == 0;
bool isGreaterThanFive = number>5 == true;

Console.Write("It is " + isNumberEven + " that the number is even and it is " + isGreaterThanFive + " that the number is greater than 5\n");
Console.WriteLine("Press any key to move on to the AREA CALCULATOR");
Console.ReadKey();


Console.WriteLine("\nWelcome to the AREA OF A CIRCLE CALCULATOR"); 
Console.Write("Please enter the circle radius: ");
double radius = double.Parse(Console.ReadLine()!);
double circleArea = System.Math.PI * (radius * radius);
Console.WriteLine("Area of the circle is " + circleArea);

