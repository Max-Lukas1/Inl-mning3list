using System;
namespace inlämning3list
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> landsStorlek = new Dictionary<string, int>();
            landsStorlek["Sverige"] = 450;
            landsStorlek["Norge"] = 385;
            landsStorlek["Danmark"] = 43;
            landsStorlek["Finland"] = 338;

            Console.WriteLine("Vilket land vill du veta storleken av?");
            string land = Console.ReadLine();
            Console.WriteLine($"{land}s storlek är {landsStorlek[land]} hundratusentals kvadratkilometer.");
        }
    }
}