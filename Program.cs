namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double hoursWorked = 0.0;            //input
            double rate = 0.0;                  //input
            double salary = 0.0;                //output

            Console.WriteLine("Enter hours worked");
            hoursWorked = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of pay");
            rate =Convert.ToDouble(Console.ReadLine());

            //program logic
            salary = hoursWorked * rate;

            Console.WriteLine("Salary is \tR" + salary);

        }
    }
}
