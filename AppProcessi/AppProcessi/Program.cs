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

            //lancio del blocco note
            Process.Start("Notepad.exe");
            //lancio del blocco note per indirizzo assoluto
            Process.Start("Notepad.exe", @"C:\Users\studenti\source\repos\App-processi\App-processi\Hello-World.txt");
            //lancio di wikipedia su chrome
            Process.Start("Chrome.exe", "https://it.wikipedia.org/wiki/Patata_(alimento)");
            //creazione nuovo processo
            var app = new Process();
            //si specifica che il processso è il blocco note
            app.StartInfo.FileName = @"Notepad.exe";
            //si specifica l'indirizzo
            app.StartInfo.Arguments = @"C:\Users\studenti\source\repos\App-processi\App-processi\Hello-World.txt";
            //si lancia il processo
            app.Start();
            //si imposta la priorità massima al processo
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //si aspetta che il processo sia teminato per andare avanti
            // app.WaitForExit();
            Console.WriteLine("Programma Terminato!");
            //si crea una lista con tutti i processi
            var processes = Process.GetProcesses();
            //si chiudono tutti i processi del bkocco note
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
