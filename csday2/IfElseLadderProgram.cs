class ifElseLadderProgram
{
    public static void Main()
    {
        System.Console.WriteLine("Enter First Number : ");
        int num1 = Convert.ToInt32(System.Console.ReadLine();)
        
        System.Console.WriteLine("Enter second Number : ");
        int num2 = Convert.ToInt32(System.Console.ReadLine();)
        
        System.Console.WriteLine("Enter Third Number : ");
        int num3 = Convert.ToInt32(System.Console.ReadLine();)



if (num1 > num2 && num2 > num3)
        {
            System.Console.WriteLine($"Larger Number is : {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            System.Console.WriteLine($"Larger Number is : {num2}");
        }
        else
        {
            System.Console.WriteLine($"Larger Number is : {num3}");
        }

    }
}