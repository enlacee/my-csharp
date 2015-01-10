using System;

class Task
{
    static public void Main()
    {
        int a;
    
        Console.WriteLine("Enter number and review your table of multiplication");

        a = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Table there {0}", a);
        Console.WriteLine("{0} x 0 = {1} ", a, a*0);
        Console.WriteLine("{0} x 1 = {1} ", a, a*1);
        Console.WriteLine("{0} x 2 = {1} ", a, a*2);
        Console.WriteLine("{0} x 3 = {1} ", a, a*3);
        Console.WriteLine("{0} x 4 = {1} ", a, a*4);
        Console.WriteLine("{0} x 5 = {1} ", a, a*5);
        Console.WriteLine("{0} x 6 = {1} ", a, a*6);
        Console.WriteLine("{0} x 7 = {1} ", a, a*7);
        Console.WriteLine("{0} x 8 = {1} ", a, a*8);
        Console.WriteLine("{0} x 9 = {1} ", a, a*9);
        Console.WriteLine("{0} x 10 = {1} ", a, a*10);
    }


}
