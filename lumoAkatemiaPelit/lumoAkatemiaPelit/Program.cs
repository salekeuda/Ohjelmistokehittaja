using System;

namespace lumoAkatemiaPelit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tehtava1();
            //tehtava2();
            tehtava3();
        }
        static void tehtava1()
        {
            Console.WriteLine("Valitse (k)ivi, (p)aperi tai (s)akset: ");
            string pelaaja = Console.ReadLine().ToLower();

            //tarkistetaan pelaajan syöte
            if (pelaaja != "k" && pelaaja != "p" && pelaaja != "s")
            {
                Console.WriteLine("Virheellinen syöte! Valitse k, p tai s.");
                return;
            }
            //arvotaan tietokoneen valinta
            Random rand = new Random();
            int tietokoneenValinta = rand.Next(0, 3); // 0 = kivi, 1 = paperi, 2 = sakset

            string tietokone = tietokoneenValinta switch
            {
                0 => "k",
                1 => "p",
                2 => "s",
                _ => throw new Exception("Tuntematon virhe arvonnassa")
            };

            Console.WriteLine($"Tietokone valitsi: {tietokone}");

            //määritellään voittaja
            if (pelaaja == tietokone)
            {
                Console.WriteLine("Tasapeli!");
            }
            else if ((pelaaja == "k" && tietokone == "s") ||
                     (pelaaja == "p" && tietokone == "k") ||
                     (pelaaja == "s" && tietokone == "p"))
            {
                Console.WriteLine("Voitit!");
            }
            else
            {
                Console.WriteLine("Hävisit!");
            }
            
        }
        static void tehtava2()
        {
            // Lauseet
            string[] lauseet =
            {
        "Laitteen aivot, joka suorittaa käskyt.",
        "Tietokoneen lyhytaikainen muisti.",
        "Ohjelma, joka hallitsee koko tietokonetta.",
        "Laite, jolla syötetään tietoa tietokoneelle.",
        "Laite, jolla tietoa näytetään käyttäjälle."
    };

            // Niitä vastaavat käsitteet
            string[] kasitteet =
            {
        "prosessorI",
        "ram",
        "käyttöjärjestelmä",
        "näppäimistö",
        "näyttö"
    };

            // Arvotaan yksi lause
            Random rnd = new Random();
            int index = rnd.Next(lauseet.Length);

            Console.WriteLine("Mikä käsite vastaa seuraavaa lausetta:");
            Console.WriteLine(lauseet[index]);
            Console.Write("Vastauksesi: ");

            string vastaus = Console.ReadLine().Trim().ToLower();

            // Tarkistus
            if (vastaus == kasitteet[index].ToLower())
            {
                Console.WriteLine("Oikein!");
            }
            else
            {
                Console.WriteLine($"Väärin. Oikea vastaus on: {kasitteet[index]}");
            }
        }
        static void tehtava3()
        {
            string[] sanat = {
        "MIELENKIINTOINEN","NEUVOSTOLIITTO","KANSAINVÄLINEN","YKSINKERTAINEN","TSEKKOSLOVAKIA",
        "AMERIKKALAINEN","VALTIONEUVOSTO","KÄYTÄNNÖLLINEN","LUONNOLLISESTI","TALOUDELLINEN",
        "PUHEENJOHTAJA","HUOMATTAVASTI","MAHDOLLISUUS","SUHTEELLINEN","TAVALLISESTI",
        "TARPEELLINEN","RUOTSALAINEN","LUONNOLLINEN","KIRJALLISUUS","JONKINLAINEN",
        "KRISTILLINEN","ASIANOMAINEN","VIRANOMAINEN","ENSIMMÄINEN","MAHDOLLINEN",
        "SUOMALAINEN","VARSINAINEN","YHTEISKUNTA","TARKASTELLA","SUUNNITELLA",
        "PRESIDENTTI","SUUNNITELMA","SOSIAALINEN","KOKONAISUUS","POLIITTINEN",
        "SAMANLAINEN","YHDYSVALLAT","TÄYDELLINEN","TULEVAISUUS","ERINOMAINEN",
        "KESKUSTELLA","TEKNILLINEN","VÄLTTÄMÄTÖN","JÄRJESTELMÄ","OSOITTAUTUA",
        "PAIKALLINEN","AIKAANSAADA","KESKUUDESSA","MINKÄLAINEN","KANSALAINEN",
        "KESKIMÄÄRIN","PAIKKAKUNTA","HARVINAINEN","VUOSIKYMMEN","TARKOITTAA",
        "TAVALLINEN","KIRJOITTAA","KIINNITTÄÄ","NIMENOMAAN","YKSITYINEN",
        "SEURAKUNTA","HUOMATTAVA","TYÖNTEKIJÄ","EDELLYTTÄÄ","AINOASTAAN",
        "OSALLISTUA","TODELLINEN","TOIMENPIDE","LÖYTÖRETKI","KESKUSTELU",
        "LOPULLINEN","TEOLLISUUS","VALTAKUNTA","OMINAISUUS","KIRJAILIJA",
        "VIRALLINEN","NEUVOTTELU","MERKITTÄVÄ","HARJOITTAA","TOISTAINEN",
        "KAIKKIALLA","OPISKELIJA","OIKEASTAAN","KANSAKOULU","SUOSITELLA",
        "PAIKALLAAN","ITSENÄINEN","YLIOPPILAS","KUITENKIN","SUORITTAA",
        "SELLAINEN","TÄLLAINEN","VAIKUTTAA","AIHEUTTAA","KÄSITELLÄ",
        "ERITYINEN","ESIMERKKI","TARKOITUS","MUODOSTAA","VALMISTAA",
        "ERILAINEN","JÄRJESTÄÄ","VIIMEINEN","ILMOITTAA","SAAVUTTAA",
        "RATKAISTA","MUODOSTUA","TOISAALLA","MYÖHEMMIN","VARSINKIN",
        "PROSENTTI","EDELLINEN","TOIMITTAA","SIJOITTAA","SELVITTÄÄ",
        "TIETENKIN","NOUDATTAA","LISÄÄNTYÄ","TOTEUTTAA","KUSTANNUS",
        "YLIOPISTO","YMPÄRILLÄ","ERIKOINEN","VAHVISTAA","KANNATTAA",
        "TILAISUUS","ULKOPUOLI","NIMITTÄIN","SÄILYTTÄÄ","TAPAHTUMA",
        "MENETELMÄ","KULJETTAA","LÄMPÖTILA","VALMISTUA","EDUSKUNTA",
        "VALKOINEN","EDELLYTYS","MIELIPIDE","VAIHDELLA","SUHTAUTUA",
        "UUDELLEEN","KILOMETRI","JULKAISTA","KAIKKIAAN","LUKUMÄÄRÄ",
        "RAJOITTAA","VÄHINTÄÄN","ETEENPÄIN","KUUNNELLA","KÄSITTELY",
        "MELKOINEN","SEITSEMÄN","HUOLEHTIA","KRISTITTY","YMPÄRISTÖ",
        "VUOSISATA","POHJOINEN","SUNNUNTAI","KAHDEKSAN","KESKEINEN",
        "EDULLINEN","JÄRJESTYS","KOHDISTUA","TEKEMINEN","TUNNUSTAA",
        "KOKOONTUA","MAATALOUS","KASVATTAA","TAPAHTUA","JOKAINEN",
        "OSOITTAA","TOIMINTA","SEURAAVA","KAUPUNKI","TUTKIMUS",
        "HELSINKI","ESIINTYÄ","AJATELLA","RAKENTAA","VASTAAVA",
        "HALLITUS","VOIMAKAS","VAIKUTUS","ERITTÄIN","MUKAINEN",
        "PERUSTAA","EDELLEEN","ILMEINEN","MERKITYS","YMMÄRTÄÄ",
        "OPETTAJA","ALOITTAA","PUOLESTA","HYVÄKSYÄ","NYKYINEN",
        "MOLEMMAT","EDUSTAJA","AIKAISIN","KYMMENEN","TIETYSTI",
        "YHTEINEN","TAULUKKO","KILPAILU","RIITTÄVÄ","RATKAISU",
        "VARMASTI","KÄSITTÄÄ","KÄYTÄNTÖ","KEHITTÄÄ","RAKENNUS",
        "KUUKAUSI","VÄHÄINEN","LÄHETTÄÄ","TUTUSTUA","PERUSTUA",
        "KOKONAAN","TUOTANTO","KESKELLÄ","NYKYISIN","SISÄLTÄÄ",
        "KUMPIKIN","ONNISTUA","KUNINGAS","TAKAISIN","ILMESTYÄ",
        "KATSELLA","VAATIMUS","JOHDOSTA","YHDISTYS","ARVIOIDA",
        "PAREMMIN","SOVELTAA","PERIAATE","KEHITTYÄ","EHDOTTAA",
        "PUNAINEN","SISÄLTYÄ","SAIRAALA","VALITTAA","VIIMEKSI",
        "MILJOONA","YHDISTÄÄ","ESITELLÄ","HISTORIA","RAAMATTU",
        "MINUUTTI","MOMENTTI","PALVELUS","SISÄINEN","TUNNETTU",
        "AIKAINEN","NORMAALI","OLOSUHDE","VARUSTAA","SUINKAAN",
        "SOVELTUA","TASAINEN","YHTEENSÄ","AIHEUTUA","HENKINEN",
        "PARANTAA","EUROOPPA","VANHEMPI","VÄHEMMÄN","MENETTÄÄ",
        "OSITTAIN","NIMITTÄÄ","RAKASTAA","AINEISTO","ENGLANTI",
        "LOPETTAA","MAASEUTU","HERÄTTÄÄ","ILMOITUS","JULKINEN",
        "TAISTELU","LAUSUNTO","LIIKENNE","SELITTÄÄ","ILMAISTA",
        "PALVELLA","NÄKÖINEN","VIERESSÄ","NÄYTELMÄ","VÄHENTÄÄ",
        "MOOTTORI","PITKÄLLÄ","PYSÄHTYÄ","TYÖVOIMA","ERIKSEEN",
        "JULISTAA","SUORITUS","TODISTAA","KOKEILLA"
    };

            Random rnd = new Random();
            string sana = sanat[rnd.Next(sanat.Length)];

            char[] arvaukset = new string('_', sana.Length).ToCharArray();
            int virheet = 0;
            const int maxVirheet = 10;

            while (virheet < maxVirheet && new string(arvaukset) != sana)
            {
                Console.WriteLine("\nSana: " + new string(arvaukset));
                Console.Write("Arvaa kirjain: ");
                char kirjain = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (sana.Contains(kirjain))
                {
                    for (int i = 0; i < sana.Length; i++)
                        if (sana[i] == kirjain)
                            arvaukset[i] = kirjain;
                }
                else
                {
                    virheet++;
                    Console.WriteLine($"Väärin! Virheitä: {virheet}/{maxVirheet}");
                }
            }

            if (new string(arvaukset) == sana)
                Console.WriteLine($"\nVoitit! Sana oli: {sana}");
            else
                Console.WriteLine($"\nHävisit! Sana oli: {sana}");
        }
    }
}
