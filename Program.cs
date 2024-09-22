namespace special_date_invitation;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        // var nome  = "Pâmella";
        var pamella = "pâmella";

        bool nomesIguais = string.Compare(name, pamella, StringComparison.CurrentCultureIgnoreCase) == 0;

        if (nomesIguais)
        {

            var currentDate = DateTime.Now;
            var targetDate = new DateTime(2024,9, 30);
            
            TimeSpan difference = targetDate - currentDate;
            double daysToDate = difference.TotalDays;

            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

        }
        else 
        {
            
            Console.WriteLine("You are not supposed to be here.");

        }
        
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);

    }
}
