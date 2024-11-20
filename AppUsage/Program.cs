namespace Seido.Utilities.ConsoleInput;

class Program
{
    public enum Season { Winter, Spring, Summer, Fall}
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("\n\nConsoleInput Usage Example");

            int _intanswer;
            if (!ConsoleInput.TryReadInt32("Enter an integer", -1, 101, out _intanswer))
            {
                break;
            }
            Console.WriteLine($"You entered {_intanswer}");

            string _stringanswer = null;
            if (!ConsoleInput.TryReadString("Enter a string", out _stringanswer))
            {
                break;
            }
            Console.WriteLine($"You entered {_stringanswer}");
            
            DateTime _dtanswer;
            if (!ConsoleInput.TryReadDateTime("Enter a date and time", out _dtanswer))
            {
                break;
            }
            Console.WriteLine($"You entered {_dtanswer}");

            Season _enAnswer;
            if (ConsoleInput.TryReadEnum<Season>("Enter a Season", out _enAnswer))
            {
                Console.WriteLine($"You entered {_enAnswer}");
            }
            
        } while (true);

        Console.WriteLine("\n\nBye");
    }
}





