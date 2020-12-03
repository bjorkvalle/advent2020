using Advent2020.App.DayOne;
using System;

namespace Advent2020.App
{
    public class DemoManager
    {
        private enum Demos
        {
            ReportRepairOne,
            ReportRepairTwo,
            Nada = 99
        }

        public void Run()
        {
            var demo = Demos.Nada;

            do
            {
                DisplayMenu();
                demo = SelectDemo();

                switch (demo)
                {
                    case Demos.ReportRepairOne:
                        {
                            Console.WriteLine("\nRunning \"REPORT REPAIR\" demo 1!");
                            new ReportRepair().RunFirstDemo();
                            break;
                        }
                    case Demos.ReportRepairTwo:
                        {
                            Console.WriteLine("\nRunning \"REPORT REPAIR\" demo 2!");
                            new ReportRepair().RunSecondDemo();
                            break;
                        }
                    default:
                        break;
                }
            } while (demo != Demos.Nada);
        }

        private void DisplayMenu()
        {
            Console.WriteLine(@"
Available projects
******************
[0] Day 1: Report Repair, demo 1
[1] Day 1: Report Repair, demo 2
[99] End
");
        }

        private Demos SelectDemo()
        {
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
                    return Demos.Nada;

                Console.Write("Select: ");
                attempts++;
                selected = int.TryParse(Console.ReadLine(), out int s) ? s : -1;
            } while (!Enum.IsDefined(typeof(Demos), selected));

            return (Demos)selected;
        }
    }
}
