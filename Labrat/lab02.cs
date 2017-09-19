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
                string tiktik = "grrrrprrr\nprrrtiktitkitktiktiktik\n";

                return tiktik;
            }
            public string loyly()
            {
                string ssh = "pshshhsshhsssshhhh";

                return ssh;
            }
        }
        public class Kiuascontrol
        {
            public static void Controlpanel()
            {
                Kiuas harvia = new Kiuas();
                Console.WriteLine("Haluatko k�ynnist�� kiukaan (y/n)?");
                while (true)
                {
                    string vastaus = Console.ReadLine();
                    if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                    {
                        harvia.paalla = true;
                        break;
                    }
                    else if (vastaus.Substring(0, 1) == "n" || vastaus.Substring(0, 1) == "N")
                    {
                        harvia.paalla = false;
                        break;
                    }
                    Console.Write("Haluatko k�ynnist�� kiukaan (y/n)?");
                }
                if (harvia.paalla == true)
                {
                    Console.Write("Mihin asteeseen haluat saunan l�mm�n? ");
                    harvia.lampo = int.Parse(Console.ReadLine());
                    Console.Write("Mihin prosenttiin haluat saunan kosteuden? ");
                    harvia.kosteus = int.Parse(Console.ReadLine());
                    Console.WriteLine(harvia.warming());
                    Console.WriteLine("Kiuas on nyt valmis k�ytt��n! l�mp� on {0} celsiusta ja kosteus {1} prosenttia", harvia.lampo, harvia.kosteus);
                    while (harvia.paalla == true)
                    {

                        Console.Write("Haluatko heitt�� l�yly� (y/n)?");
                        string vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                        {
                            Console.WriteLine(harvia.loyly());
                        }

                        Console.Write("Haluatko lopettaa saunomisen? (y/n)?");
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") harvia.paalla = false;


                    }
                }


                Console.WriteLine("Kiuas on nyt sammutettu! harvia kiitt��!!");

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
                return "hrrrhrrrhrrrhrr";
            }
            public string lingging()
            {
                return "viuhviuhviuhviuhviuhviuh";
            }
        }
        public class Pesukonecontrol
        {
            public static void Controlpanel()
            {
                Pesukone rosenlew = new Pesukone();
                Console.Write("Hei, haluatko pest� pyykki� (y/n)?");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") rosenlew.paalla = true;
                else rosenlew.paalla = false;
                if (rosenlew.paalla == false) { Console.WriteLine("N�kemiin!"); Environment.Exit(1); }
                Console.Write("Mill� l�mp�tilalla haluat pest� pyykkisi? ");
                rosenlew.lampo = int.Parse(Console.ReadLine());
                Console.Write("Kuinka kovan pesun haluat pyykillesi 1-10 (hell�varainen - raju)? ");
                rosenlew.kovuus = int.Parse(Console.ReadLine());
                Console.Write("Haluatko linkouksen (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") rosenlew.linkous = true;
                string linko = "";
                if (rosenlew.linkous == true) linko = "haluat linkouksen";
                else if (rosenlew.linkous == false) linko = "et halua linkousta";
                Console.WriteLine("Valitsit seuraavat vaihtoehdot: L�mp�tila {0} celsius astetta, kovuus {1} ja {2}.", rosenlew.lampo, rosenlew.kovuus, linko);
                Console.Write("Aloitetaanko ohjelma (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                {
                    Console.WriteLine(rosenlew.running());
                    if (rosenlew.linkous == true)
                    {
                        Console.WriteLine("Aloitetaan linkous!");
                        Console.WriteLine(rosenlew.lingging());
                    }
                    Console.WriteLine("Ohjelma on valmis!");
                }


                Console.WriteLine("Ohjelma on lopetettu. Kiitos!!");


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
                return "Tsimm";
            }
            public string change()
            {
                return "Tsuim";
            }

        }
        public class Tvcontrol
        {
            public static void Controlpanel()
            {
                Tv lg = new Tv();
                Console.Write("K�ynnistet��nk� televisio (y/n)? ");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") lg.paalla = true;
                else lg.paalla = false;
                if (lg.paalla == true)
                {
                    Console.WriteLine(lg.startting());
                    do
                    {
                        Console.Write("Valitse joku kanava? ");
                        lg.kanava = int.Parse(Console.ReadLine());
                        Console.Write("S��d� ��nenvoimakkuus kohdilleen? ");
                        lg.volume = int.Parse(Console.ReadLine());
                        Console.WriteLine(lg.change());
                        Console.Write("Valitsit kanavan {0} ja ��nen voimakkuutesi on {1} astetta. Haluatko vaihtaa jotain (y/n)?", lg.kanava, lg.volume);
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "N" || vastaus.Substring(0, 1) == "n")
                        {
                            Console.Write("Haluatko sammuttaa tvn (y/n)? ");
                            vastaus = Console.ReadLine();
                            if (vastaus.Substring(0, 1) == "Y" || vastaus.Substring(0, 1) == "y") lg.paalla = false;
                        }
                    } while (lg.paalla != false);
                    Console.WriteLine("Telvisio sammuu, heihei!");
                    Console.WriteLine(lg.startting());
                }

            }
        }