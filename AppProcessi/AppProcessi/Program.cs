using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcessi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercitazione sulla gestione dei processi");

            Process.Start("Notepad.exe");

            Process.Start("Notepad.exe", @"C:\Users\studenti\source\repos\App-processi\App-processi\Hello-World.txt");

            Process.Start("Chrome.exe", "https://it.wikipedia.org/wiki/Patata_(alimento)");

            var app = new Process();

            app.StartInfo.FileName = @"Notepad.exe";

            app.StartInfo.Arguments = @"C:\Users\studenti\source\repos\App-processi\App-processi\Hello-World.txt";

            app.Start();

            app.PriorityClass = ProcessPriorityClass.RealTime;

            // app.WaitForExit();

            Console.WriteLine("Programma Terminato!");

            var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                if (p.ProcessName == "notepad")
                {
                    p.Kill();
                }
            }

            Console.ReadLine();
        }
    }
}
