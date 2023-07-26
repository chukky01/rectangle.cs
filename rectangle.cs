//Start with this
using System;

public class Program
{
    public static void Main(string[]args)
    {
        //Create the length, breadth, perimeter and area as int
        int l, b, PERIMETER, AREA;
        Console.WriteLine("GIVE ME TWO NUMBERS AND I WILL PRINT OUT THEIR PERIMETER AND THEIR AREA\n");
        
        //Ask the user to give you two numbers and then tell which numbers they entered
        Console.WriteLine("Give me the first number: ");
        l = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered " + l + "\n");
        
        Console.WriteLine("Give me the second number: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered "+ b);
        
        //Define protocol for getting both the perimeter and area
        PERIMETER = 2 *(l+b);
        AREA = l * b;
        Console.WriteLine();
        
        //Print out the result of the two number entered
        Console.WriteLine("The perimeter of the two given numbers is " +PERIMETER );
        Console.WriteLine("The area of the two given numbers is " + AREA);
        
        
        return;
    }
}
