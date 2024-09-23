namespace special_date_invitation;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var pamella = "pâmella";

        bool nomesIguais = string.Compare(name, pamella, StringComparison.CurrentCultureIgnoreCase) == 0;
        
        Random random = new Random();

        if (nomesIguais)
        {
            
            var dateOptions = datesList();
            
            int randomIndex = random.Next(dateOptions.Count);
            string datezin = dateOptions[randomIndex];

            var currentDate = DateTime.Now;
            var targetDate = new DateTime(2024,9,30);

            TimeSpan difference = targetDate - currentDate;
            int daysToDate = (int)difference.TotalDays;

            Console.WriteLine(Figgle.FiggleFonts.Standard.Render($"{Environment.NewLine}Você vai num encontro comigo! S2"));
            Console.WriteLine($"{Environment.NewLine}Nosso encontro é no dia {targetDate:d} e faltam {daysToDate} dias pra chegar! ;)");
            Console.WriteLine($"{Environment.NewLine}{datezin}. Bora?");

        }
        else 
        {

            var wrongPersonOptions = whatAreYouDoingHere();
            int randomIndex = random.Next(wrongPersonOptions.Count);
            string whatDoYouWant = wrongPersonOptions[randomIndex];
            Console.WriteLine($"{Environment.NewLine}{whatDoYouWant}. Cai fora.");

        }
        
        Console.Write($"{Environment.NewLine}Pressione uma tecla...");
        Console.ReadKey(true);

    }

    private static List<string> datesList() {

        List<string> datesList =
        [
            "Ver o pôr do sol da varanda.",
            "Tomar um banho de banheira.",
            "Tomar uma cerveja pé na areia no Cavalo Marinho Beach.",
            "Sambinha na Pedra do Sal.",
            "Rolézinho na areia da praia aproveitando a paisagem.",
            "Tomar um vinho e ouvir uma música gostosinha.",
        ];

        return datesList;

    }

    private static List<string> whatAreYouDoingHere() {

        List<string> whatAreYouDoingHere = 
        [
            "Sai fora que esse convite é pra outra pessoa.",
            "Você não deveria estar aqui.",
            "Não tem nada aqui pra você.",
            "Nops.",
            "Esse programa não é pra você.",
            "Esse garoto de programa não é pra você.",
        ];

        return whatAreYouDoingHere;
        
    }
}
