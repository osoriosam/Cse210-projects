using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string sign = "";
        int x;
        int remainder;
        Console.WriteLine("Hello, what is your grade pecentage?");
        string percentage_grade = Console.ReadLine();
        x = int.Parse(percentage_grade);
        if (x < 60)
        {
            letter = "F";
        }
        else if(x < 70)
        {
            letter = "D";
        }
        else if(x < 80)
        {
            letter = "C";
        }
        else if(x < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }
        remainder = x % 10;
        if (remainder < 3)
        {
            sign = "-";
        }
        else if (remainder >=7)
        {
            sign = "+";
        }
        if (letter == "F")
        {
            sign = "";
        }
        if (letter == "A")
        {
            if(sign == "+")
            {
                sign = "";
            }
        }
        Console.WriteLine($"Your letter grade is {letter}{sign}");
        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed!!!");
        }
        else
        {
            Console.WriteLine("Unfortunately this time you don't passed, but keep trying and good luck next time");
        }
    }
}