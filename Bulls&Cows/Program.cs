public class Program
{
    private static string result = "1234";
    private static void Main(string[] args)
    {
        string input = string.Empty;
        
        Console.WriteLine("Введите число для угадывания:");        
        input = Console.ReadLine();
       
        CheckResult(input);
        do
        {
            Console.WriteLine("Введите число для угадывания:");
            input = Console.ReadLine();

            if (!CheckCorrect(input))
            {
                Console.WriteLine("Неверный формат!");
            };

        } while (!CheckResult(input));
      
        Console.WriteLine("МАЛАДЕЦ");
    }

    private static bool CheckResult(string input)
    {
        byte bulls = 0;
        byte cows = 0;

        for (int i = 0; i < 4; i++)
        {
            if (result.Contains(input[i]))
            {
                var indexOfResult = result.IndexOf(input[i]);
                if (indexOfResult == i) 
                {
                    bulls++;
                }
                else
                {
                    cows++;
                }
            }
        }
        Console.Write($"Быков: {bulls}; Коров: {cows}\n");
        
        return bulls == 4;
    }

    private static bool CheckCorrect(string input)
    {
       if (input.Length != 4 ) return false;
       return int.TryParse(input, out var val);
    }
}