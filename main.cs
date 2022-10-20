// Created by: Ashley Monaghan
// Created on: Oct 2022
//
//This program calculates area of a Elipse

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user imput
        int a;
        int b;
        double area;

        Console.WriteLine("This program calculates the area of an Elipse.");
        Console.WriteLine("");

        Console.Write("Enter length a (cm): ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length b (cm): ");
        b = Convert.ToInt32(Console.ReadLine());
        
        area = Math.PI *(a * b);

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");

        Console.WriteLine("\nDone.");
    }
}