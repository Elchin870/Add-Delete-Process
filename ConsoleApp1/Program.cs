using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var process = Process.GetProcesses();
                foreach (var item in process)
                {
                    Console.WriteLine($"{item.Id} {item.ProcessName}");

                }
                Console.WriteLine();
                Console.WriteLine("1)New Task");
                Console.WriteLine("2)End Task");
                Console.Write("Secim: ");
                var secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.Write("Enter name of process: ");
                        var nameProcess = Console.ReadLine();
                        Process.Start(nameProcess);
                        break;
                    case "2":
                        try
                        {
                            Console.Write("Enter id of process: ");
                            var idProcess = Console.ReadLine();
                            Process.GetProcessById(Convert.ToInt32(idProcess)).Kill();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Access yoxdur");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input!!!");
                        break;
                }
            }
        }
    }
}
