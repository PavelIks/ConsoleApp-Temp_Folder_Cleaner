using System;
using System.IO;

namespace TempFolderCeaner
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var Directorys in Directory.GetDirectories($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Temp\"))
            {
                try
                {
                    Directory.Delete(Directorys.ToString(), true);
                    Console.WriteLine("true (Удалено)", Console.ForegroundColor = ConsoleColor.DarkGreen);
                }
                catch (Exception)
                {
                    Console.WriteLine("false (Не подлежит удалению)", Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            }
            foreach (var Files in Directory.GetFiles($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Temp\"))
            {
                try
                {
                    File.Delete(Files.ToString());
                    Console.WriteLine("true (Удалено)", Console.ForegroundColor = ConsoleColor.DarkGreen);
                }
                catch (Exception)
                {
                    Console.WriteLine("false (Не подлежит удалению)", Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            }
            Console.Read();
        }
    }
}