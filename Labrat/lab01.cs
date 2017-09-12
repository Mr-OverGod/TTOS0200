using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Labrat      
{
class lab01{        



public static void tehtava1();
    
        

         
            
  
        
    }
    


}*/

    namespace Labrat { 
class lab01
{
    public static void tehtava1()
    {
        
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme).
            //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
                int luku;
    Console.Write("Anna luku > ");
    luku = int.Parse(Console.ReadLine());
    Console.WriteLine("Annoit luvun " + luku);

            if (luku == 1){
                Console.WriteLine("Annoit luvun yksi");
}
            if (luku == 2){
                Console.WriteLine("Annoit luvun kaksi");
}
            if (luku == 3){
                Console.WriteLine("Annoit luvun kolme");
}
            if (luku > 3) {
                Console.WriteLine("Joku muu luku");
}

            Console.ReadLine();
            
        
            
    }
        public static void tehtava2()
            {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
            int luku;
            Console.WriteLine("Anna oppilaan pisteet > ");
            luku = int.Parse(Console.ReadLine());

            if (luku < 2){Console.WriteLine("Oppilaan numero on 0");}

            if (luku == 2 || luku == 3){Console.WriteLine("Oppilaan numero on 1");}

            if (luku == 4 || luku == 5){Console.WriteLine("Oppilaan numero on 2");}

            if (luku == 6 || luku == 7){Console.WriteLine("Oppilaan numero on 3");}

            if (luku == 8 || luku == 9){Console.WriteLine("Oppilaan numero on 4");}

            if (luku == 10 || luku == 11 || luku == 12){Console.WriteLine("Oppilaan numero on 5");}

            if (luku > 12) {Console.WriteLine("Paska luku");}

            Console.ReadLine();


}

        public static void tehtava3()
            {
           // Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
           int luku1;
            int luku2;
            int luku3;
            int summa;
            int karvo;
           
           Console.WriteLine("Syötä luku ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä vielä toinen luku ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä viimeinen luku");
            luku3 = int.Parse(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            karvo = summa / 3;

            Console.WriteLine("Numeroiden summa on " + summa);
            Console.WriteLine("Numeroiden keskiarvo on " + karvo);
                
            Console.ReadLine();

}

        public static void tehtava4()
            {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
            int ika;
            Console.WriteLine("Anna ikä ");
            ika = int.Parse(Console.ReadLine());

            if (ika < 18) {Console.WriteLine("alaikäinen");}

            if (ika >= 18 && ika <= 65) {Console.WriteLine("aikuinen");}

            if (ika > 65) {Console.WriteLine("seniori");}

            Console.ReadLine();
}

        public static void tehtava5()
            {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
            int aika;
            Console.WriteLine("Anna aika sekunteina ");
            aika = int.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(aika);

            string str = time .ToString(@"hh\:mm\:ss\:fff");

            Console.WriteLine(time);
            
            Console.ReadLine();
}

        public static void tehtava6()
            {
            double matka;
            double kulu;
            double cost;
            Console.WriteLine("Anna matka ");
            matka = int.Parse(Console.ReadLine());

            kulu = matka * 0.0702;
            cost = kulu * 1.595;

            Console.WriteLine("Bensaa kuluu " + kulu + " ,litraa, kustannus " + cost + " euroa");
            

            Console.ReadLine();

}
        public static void tehtava7()
            {
            //4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
            int vuosi;
           int jako;
            int isojako;
            int satajako;
            Console.WriteLine("Anna vuosi > ");
            vuosi = int.Parse(Console.ReadLine());

            isojako = vuosi % 400;
            jako = vuosi % 4;
            satajako = vuosi % 100;
            if (isojako == 0){Console.WriteLine("Vuosi on karkausvuosi");}

            if (isojako != 0){

            
            
            if (jako == 0 && satajako != 0){Console.WriteLine("Vuosi on karkausvuosi");}
            
            else {Console.WriteLine("Vuosi ei ole karkausvuosi");}}

            Console.ReadLine();
}

        public static void tehtava8()
            {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            int luku1;
            int luku2;
            int luku3;
            int muisti;
            Console.WriteLine("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2){muisti = luku2;
            luku2 = luku1;
            luku1 = muisti;
}
            if (luku2 > luku3){muisti = luku3;
            luku3 = luku2;
            luku2 = muisti;
}
            if (luku1 > luku2){muisti = luku2;
            luku2 = luku1;
            luku1 = muisti;
}

            Console.WriteLine("Suurin luku on " + luku3);

            Console.ReadLine();
}

        public static void tehtava9()
            {
           // Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
           int luku;
            int summa;
            summa = 0;
            do {
                Console.WriteLine("Anna luku >");
                luku = int.Parse(Console.ReadLine());
                luku = luku;

                summa = summa + luku;

                Console.WriteLine("Lukujen summa on " + summa);
               }
            while (luku != 0);

            Console.ReadLine();
            }
                public static void tehtava11()
        {
            int luku;
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            for (int i = luku; i > 0; i--)
            {
                for (int j = i - 1; luku > j; j++)
                { Console.Write("*"); }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        public static void tehtava20()
            {
        //Perus laskin
        int operation = 0;
        
        double result = 0;

        //Eka luku
        Console.WriteLine("Anna eka numero :");
        string stringFirstNumber = Console.ReadLine();
        double firstNumber = Convert.ToDouble(stringFirstNumber);

        //Toka luku
        Console.WriteLine("Anna toinen numero :");
        string stringSecondNumber = Console.ReadLine();
        double secondNumber = Convert.ToDouble(stringSecondNumber);

        //Valitaan mitä tehdään
        Console.WriteLine("Mitäs tehrään + (lussataan), - (miinustetaan), * (kerrotaan), / (jaeskellaan), ^ (exponenttiin) or % (jakojäännös) :");
        string stringOperation = Console.ReadLine();

        
        if (stringOperation == "+" || stringOperation == "lussataan")
        {
            operation = 1;
        }
        else if (stringOperation == "-" || stringOperation == "miinustetaan")
        {
            operation = 2;
        }
        else if (stringOperation == "*" || stringOperation == "kerrotaan")
        {
            operation = 3;
        }
        else if (stringOperation == "/" || stringOperation == "jaeskellaan")
        {
            operation = 4;
        }
        else if (stringOperation == "^" || stringOperation == "exponenttiin")
        {
            operation = 5;
        }
        else if (stringOperation == "%" || stringOperation == "jakojäännös")
        {
            operation = 6;
        }

        //Tehdään valitun objektin mukaan

        switch (operation)
        {
            case 1:
                result = firstNumber + secondNumber;
                break;

            case 2:
                result = firstNumber - secondNumber;
                break;

            case 3:
                result = firstNumber * secondNumber;
                break;

            case 4:
                result = firstNumber / secondNumber;
                break;

            case 5:
                result = Math.Pow(firstNumber, secondNumber);
                break;

            case 6:
                result = firstNumber % secondNumber;
                break;
        }
            //Tulostetaan laskun loppu tulos
        Console.WriteLine("\nTulos " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
        Console.ReadKey();
            Console.WriteLine();
    }
  }
}
            


    

