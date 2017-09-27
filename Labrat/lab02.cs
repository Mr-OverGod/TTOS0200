using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labrat
    { 
   class lab02
    {
        public class Kiuas
        {
            public bool paalla { get; set; }

            public int lampo { get; set; }

            public int kosteus { get; set; }

            public Kiuas(bool paalla, int Teho, int kosteus) : base()
            {
                this.paalla = paalla;

                this.lampo = Teho;

                this.kosteus = kosteus;
            }
            public Kiuas()
            {
            }
            public string warming()
            {
                string tiktik = "tik tok\ntik tok\ntik tok\n";

                return tiktik;
            }
            public string loyly()
            {
                string suhina = "ssshshhhh";

                return suhina;
            }
        }
        public class Kiuassaato
        {
            public static void Controlpanel()
            {
                Kiuas sauna = new Kiuas();

                Console.WriteLine("K‰ynnistet‰‰nkˆ kiuas (y/n)??");

                while (true)
                {
                    string vastaus = Console.ReadLine();
                    if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                    {
                        sauna.paalla = true;
                        break;
                    }
                    else if (vastaus.Substring(0, 1) == "n" || vastaus.Substring(0, 1) == "N")
                    {
                        sauna.paalla = false;
                        break;
                    }
                    Console.Write("K‰ynnistet‰‰nkˆ kiuas (y/n)??");
                }
                if (sauna.paalla == true)
                {
                    Console.Write("Kiukaan asteet? > ");

                    sauna.lampo = int.Parse(Console.ReadLine());

                    Console.Write("Mik‰ kosteus % > ");

                    sauna.kosteus = int.Parse(Console.ReadLine());

                    Console.WriteLine(sauna.warming());

                    Console.WriteLine("Sauna on ready!! l‰mpˆ on {0} celsiusta ja kosteus {1} prosenttia", sauna.lampo, sauna.kosteus);

                    while (sauna.paalla == true)
                    {

                        Console.Write("Haluatko heitt‰‰ lˆyly‰ (y/n)?");

                        string vastaus = Console.ReadLine();

                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                        {
                            Console.WriteLine(sauna.loyly());
                        }

                        Console.Write("Haluatko lopettaa saunomisen? (y/n)?");

                        vastaus = Console.ReadLine();

                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") sauna.paalla = false;


                    }
                }


                Console.WriteLine("Sauna on vaihteeksi kylm‰");

                Console.ReadLine();

            }
        }
        public class Pesukone
        {
            public bool paalla { get; set; }

            public int lampo { get; set; }

            public int kovuus { get; set; }

            public bool linkous { get; set; }

            public Pesukone(bool paalla, int lampo, int kovuus, bool linkous) : base()
            {
                this.paalla = paalla;

                this.lampo = lampo;

                this.kovuus = kovuus;

                this.linkous = linkous;
            }
            public Pesukone()
            {
            }
            public string running()
            {
                return "hurhurhur";
            }
            public string lingging()
            {
                return "pv zk pv pv zk pv zk kz zk pv pv pv zk pv zk zk pzk pzk pvzkpkzvpvzk kkkkkk bsch"; //Google beatboxin
            }
        }
        public class Pesukonesaato
        {
            public static void Controlpanel()
            {
                Pesukone linkomaatti = new Pesukone();

                Console.Write("Pest‰‰nkˆ pyykit (y/n)?");

                string vastaus = Console.ReadLine();

                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") linkomaatti.paalla = true;

                else linkomaatti.paalla = false;

                if (linkomaatti.paalla == false) { Console.WriteLine("Ei sitten"); Environment.Exit(1); }

                Console.Write("Valitse l‰mpˆtila > ");

                linkomaatti.lampo = int.Parse(Console.ReadLine());

                Console.Write("Kuinka kovan pesun haluat pyykillesi 1-5 (Silk - Bricks)? "); //You really can wash bricks with washing machine

                linkomaatti.kovuus = int.Parse(Console.ReadLine());

                Console.Write("Lingotaanko (y/n)? ");

                vastaus = Console.ReadLine();

                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") linkomaatti.linkous = true;

                string linko = "";

                if (linkomaatti.linkous == true) linko = "Yuup Lingotaan";

                else if (linkomaatti.linkous == false) linko = "Ei Lingota";

                Console.WriteLine("Pesun l‰mpˆtila {0} celsius astetta, kovuus {1} ja {2}.", linkomaatti.lampo, linkomaatti.kovuus, linko);

                Console.Write("Aloitetaanko ohjelma (y/n)? ");

                vastaus = Console.ReadLine();

                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                {
                    Console.WriteLine(linkomaatti.running());

                    if (linkomaatti.linkous == true)
                    {
                        Console.WriteLine("Linko party");

                        Console.WriteLine(linkomaatti.lingging());
                    }
                    Console.WriteLine("Vaateet pesty!");
                }


                Console.WriteLine("Ohjelma on lopetettu.");

                Console.ReadLine();


            }
        }
        public class Tv
        {
            public bool paalla { get; set; }

            public int kanava { get; set; }

            public int volume { get; set; }

            public Tv(bool paalla, int kanava, int volume) : base()
            {
                this.paalla = paalla;

                this.kanava = kanava;

                this.volume = volume;
            }
            public Tv()
            {
            }
            public string startting()
            {
                return "Jeesus tulee";
            }
            public string ending() { return "Jeesus menee"; } // Or does he

            public string change()
            {
                return "Piip"; //Kutsutaan joka kerta kun tehd‰‰n muutoksia
            }

        }
        public class Tvsaato
        {
            public static void Controlpanel()
            {
                Tv telkkari = new Tv();

                Console.Write("Avataanko televisio (y/n)? ");

                string vastaus = Console.ReadLine();

                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") telkkari.paalla = true;

                else telkkari.paalla = false;

                if (telkkari.paalla == true)
                {
                    Console.WriteLine(telkkari.startting());
                    do
                    {
                        Console.Write("Kanava? > ");

                        telkkari.kanava = int.Parse(Console.ReadLine());

                        Console.Write("ƒ‰nenvoimakkuus? > ");

                        telkkari.volume = int.Parse(Console.ReadLine());

                        Console.WriteLine(telkkari.change());

                        Console.Write("Valitsit kanavan {0} ja ‰‰nen voimakkuutesi on {1} astetta. Haluatko vaihtaa jotain (y/n)?", telkkari.kanava, telkkari.volume);

                        vastaus = Console.ReadLine();

                        if (vastaus.Substring(0, 1) == "N" || vastaus.Substring(0, 1) == "n")
                        {
                            Console.Write("Haluatko sammuttaa tvn (y/n)? ");
                            vastaus = Console.ReadLine();
                            if (vastaus.Substring(0, 1) == "Y" || vastaus.Substring(0, 1) == "y") telkkari.paalla = false;
                        }
                    } while (telkkari.paalla != false);

                    Console.WriteLine("**Pimeys**");

                    Console.WriteLine(telkkari.ending());

                    Console.ReadLine();
                }

            }
        }
    }
}