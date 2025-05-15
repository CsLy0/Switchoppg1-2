using System.ComponentModel.DataAnnotations.Schema;

internal class ifElse
{
    public void Run()
    {
        Console.WriteLine("Hvilken dag er det?");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int Dager))
        {
            switch (Dager)
            {
                case 1:
                    Console.WriteLine("Det er Mandag");
                    break;
                case 2:
                    Console.WriteLine("Det er Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Det er Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Det er Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Det er Fredag");
                    break;
                case 6:
                    Console.WriteLine("Det er Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Det er Søndag");
                    break;
                default:
                    Run();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ikke riktig input. Skriv inn et tall");
            Run();
        }
    }

    public static void Main(string[] args)
    {
        ifElse program = new ifElse();
        program.Run();
    }
}
