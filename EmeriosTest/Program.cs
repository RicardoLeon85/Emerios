using EmeriosTest.Controller;
using EmeriosTest.Entities;
using System;

namespace EmeriosTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                var fromFile = new FromFile();
                Info matriz = fromFile.ReadInfo;

                ManageInfo manageInfo = new ManageInfo();
                string result = manageInfo.Calculate(matriz);

                Console.WriteLine("Result: " + result);
                Console.Write("Press Enter to close window ...");
                Console.Read();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
