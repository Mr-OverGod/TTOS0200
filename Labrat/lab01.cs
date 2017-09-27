using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class lab01
    {
                public static void tehtava19()
        {
            string sana = "putkea";

            
            char[] a = new char[sana.Length];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = '_';
            }
            Console.WriteLine(".....HIRSIPUU.....");
            Console.Write("Sanasi on: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();

            int luku = 0;
            do
            {
                Console.Write("Anna kirjain: ");
                char input = Console.ReadLine().ToCharArray()[0];

                for (int i = 0; i < sana.Length; i++)
                {
                    
                    if (sana[i] == input)
                    {
                        luku++; 
                        a[i] = input;  

                        
                        for (int j = 0; j < a.Length; j++)
                        {
                            Console.Write(a[j] + " ");
                        }
                    }
                }
                
            }

            while (luku < a.Length);
            Console.WriteLine("You guessed it right");
            Console.ReadLine();
        }

  }
}
