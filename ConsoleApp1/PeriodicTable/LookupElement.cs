using System;

namespace ConsoleApp1.PeriodicTable
{
    static class LookupElement
    {
        public static void SearchLoop()
        {
            while (true)
            {
                PeriodicTable pt = new PeriodicTable();

                Console.Write("Select search mode [1: Atomic Number, 2: Symbol, 3: Name, 4: quit]: ");
                string mode = Console.ReadLine();
                if (mode == "4") return;

                Console.Write("Search: ");
                string search = Console.ReadLine();
                Element element;

                try
                {
                    switch (mode)
                    {
                        case "1":
                            element = pt.GetElement(Convert.ToInt32(search));
                            break;
                        case "2":
                            element = pt.GetElement(search);
                            break;
                        case "3":
                            element = pt.GetElementByName(search);
                            break;
                        default:
                            Console.WriteLine("ERROR: Invalid input detected.");
                            continue;
                    }
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    // supress exception from being thrown
                    Console.WriteLine("ERROR: No matching element was found.");
                    continue;
                }
                Console.WriteLine("Atomic Number: {0}", element.AtomicNumber);
                Console.WriteLine("Name: {0}", element.Name);
                Console.WriteLine("Symbol: {0}", element.Symbol);
                Console.WriteLine("Weight: {0}M", element.AtomicWeight);
                Console.WriteLine();
            }
        }
    }
}
