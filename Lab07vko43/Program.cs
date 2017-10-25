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
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //luodaan Streamwriter olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö
                string teksti = File.ReadAllText(filu);
                Console.WriteLine(teksti);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
