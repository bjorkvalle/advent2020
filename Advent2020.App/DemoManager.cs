using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2020.App
{
    public static class DemoManager
    {
        public static void Run()
        {
            Console.WriteLine(@"
Available projects
******************
[0] Day 1: Report Repair
");

            int minSelect = 0, maxSelect = Enum.GetValues(typeof(Demos)).Length;
            var selected = -1;
            var attempts = 0;

            do
            {
                if (attempts > 1 && attempts <= 2)
                    Console.WriteLine("Pick a number, please.");
                else if (attempts == 3)
                    Console.WriteLine("Pick a number FROM THE LIST, please.");
                else if (attempts == 4)
                    Console.WriteLine("Last chance, dude");
                else if (attempts > 4)
                    return;

                Console.Write("Select: ");
                attempts++;
                selected = int.TryParse(Console.ReadLine(), out int s) ? s : -1;
            } while (selected < minSelect && selected > maxSelect);

            switch ((Demos)selected)
            {
                case Demos.ReportRepair:
                    break;
                default:
                    break;
            }
        }
    }
}
