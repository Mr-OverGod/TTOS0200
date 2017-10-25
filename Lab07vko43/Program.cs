using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string nimi;
                string filupath = @"D:\K9037";
                //luodaan Streamwriter olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filupath + @"\testi.txt");
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
