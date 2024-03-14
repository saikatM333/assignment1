internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("tempreture converter ");
        Console.WriteLine("enter F for giving input in Fahrenheit \nenter C for enter the tempreture value in celcius  ");
        string scale = Console.ReadLine();
        Console.WriteLine("enter the value ");
        double  temp =Convert.ToDouble(Console.ReadLine());
        if (scale =="f" ||  scale == "F")
        {
            double C= (5 / 9 * (temp - 32));
            Console.WriteLine($"{C} Celsius");
            Console.WriteLine(C);
        }
         else if (scale == "C" || scale=="c") {
            double f  = (9/ 5 * temp) + 32;
            Console.WriteLine($"{f} Fahrenheit");
        }
        else
        {
            Console.WriteLine("please enter the coorect scale for conversion ");        }
    }
}