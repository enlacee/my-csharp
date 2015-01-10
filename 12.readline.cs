class Exercise12
{
    /*
    * OUT program
    * 
    */
    static public void Main()
    {
        int a, b, suma;
        
        System.Console.WriteLine("Enter First Number:");
        a = System.Convert.ToInt32(System.Console.ReadLine());
        
        System.Console.WriteLine("Enter Second Number:");
        b = System.Convert.ToInt32(System.Console.ReadLine());

        suma = a + b;

        System.Console.WriteLine("That Sum of {0} and {1} is {2}"
        ,a ,b , suma); 
    }
}
