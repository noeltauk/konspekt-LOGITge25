using System;
using System.ComponentModel.Design;
using System.Globalization; //<----- enne nimeruumi peab olema, selles failis/klassis kasutatud paketid/moodulid ja süteemi muudele osadele viidatakse sellele
// süsteemi muuks osaks võib olla kas os'i võimalused või muud projektid. teised projektid viidatakse tavaliselt solution failist (.sln)

namespace EsimeneProjekt       // nimega namespace või {} sulud sisaldavad kontenerit kus asub terve programmi nime
{
    internal class Program // programmi klass, mis on konteiner
    {
        static void Main(string[] args) // "main" on see mis alati käivitatakse 
        {
            /* näiteprogramm 1*/
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles."); // print(kontojääk + " puuehte on alles")
            //Console.WriteLine("Palun sisesta oma hästi tehtud töö boonus: ");
            //int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("Palun sisesta oma hästi tehtud töö boonus: "))
            //kontojääk = kontojääk + boonus; // same python
            //Console.WriteLine("Sinu lõppväljavõte on: " + kontojääk + " puulehte");

            /* näiteprogramm 2 */
            /*
             * klient tahab et programm teeks: 
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */

            //int kasutajaVanus = 0; 
            //Console.WriteLine("Kui vana sa oled?");
            //kasutajaVanus = int.Parse(Console.ReadLine());
            //if (kasutajaVanus >= 18)
            //{
            //    Console.WriteLine("Tere, siin on sinu mojito 🍹");
            //}
            //else 
            //{
            //    Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 🤡");
            //}

            /*
             näiteprogramm 3:

            klient tahab et programm teeks:
             - küsib kasutajalt tema kasutajaNime
             - küsib kasutajalt tema parooli
             - logib kasutaja sisse kui mõlemad on õiged
             */
            // hint: mida teeb &&?

            /* siia käib vooskeemi järgi kirjutatud kood näidisülesanne 3 kohta */

            ////ctrl + k + c/u

            //int mingiArv = 4;

            //mingiArv = mingiArv + 15; //
            //mingiArv = mingiArv * 15; //
            //mingiArv = mingiArv - 15; //
            //mingiArv = mingiArv / 15; //


            //mingiArv += 15; //
            //mingiArv -= 15; //
            //mingiArv *= 15; //
            //mingiArv /= 15; //

            ///* näiteülesanne 4 */
            //Console.WriteLine("Palun sisesta oma vanus"); 
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //int kasutajavanus = int.Parse(Console.ReadLine()); 
            //// tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            //Console.WriteLine("Palun sisesta oma vanavanema vanus"); 
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //int kasutajaVanavanemaVanus = int.Parse(Console.ReadLine()); 
            //// tekitame muutuja kasutajaVanavanemaVanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            //int vanusteVahe = kasutajaVanavanemaVanus - kasutajavanus; 
            //// tekitame uue täisarvu muutuja kuhu omistame avaldise kasutajaVanavanemaVanus - kasutajavanus tulemuse
            //Console.WriteLine(kasutajaVanavanemaVanus - kasutajavanus);
            //// saab ka otse kuvada, ilma muutujata
            //Console.WriteLine("Kui palju sa vanem oled?");
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //kasutajavanus += int.Parse(Console.ReadLine());
            //// kasutame omistusoperaatorit, et lisada muutujale kasutaja poolt esitatud täisarvu
            //Console.WriteLine("vanuste vahe on nüüd: "+(kasutajaVanavanemaVanus - kasutajavanus));
            //// kuvame uuesti vanuste vahe koos tekstiga

            /* näiteülesanne 5 */

            //Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (m)?");
            //float kaugus = float.Parse(Console.ReadLine());
            //if ( kaugus <= 1.00 && kaugus >= 0.00 )
            //{
            //    Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            //}
            //else if (kaugus <= 2.00 && kaugus >= 1.01)
            //{
            //    Console.WriteLine("Noh tuleb juba, jõuad veel!");
            //}
            //else if (kaugus <= 3.00 && kaugus >= 2.01 )
            //{
            //    Console.WriteLine("TUBLI kolm meetrit umbes, peaaegu, vist... not sure");
            //}
            //else if (kaugus < 0)
            //{
            //    Console.WriteLine("MIKS SA TAGURPIDI VISKAD?!?!?!");
            //}
            //else
            //{
            //    Console.WriteLine("Ossaraks, seda on varsti orbiidilt näha");
            //}

            /* näiteülesanne 6 */
            // kirjuta programm mis
            /*
            küsib kasutajalt tema vanust, ✅
            kui vanus on väiksem kui 0 või sama kui 0, kuva kasutajale sõnum ajarändureid me ei teeninda ✅
            kui vanus on suurem kui 0 aga väiksem kui 18, küsi kasutajalt tema nime, ning tagasta sõnum kallis <nimi>, palun kutsu oma lapsevanem siia. ✅
            kui vanus on suurem kui 18, küsi kasutajalt tema eesnime, ja perekonnanime ✅
            tee tingimuskontroll, mis kontrollib et eesnimi ei oleks tühi, või perekonnanimi ei oleks tühi, ning tagasta sõnum sisestama pidi mõlemad nime ✅
            kui aga mõlemad nimed on olemas, siis tagasta kasutajale tema ees ja perekonnanimega tervitus. ✅
            */
            /*
            Console.WriteLine("Palun sisesta oma vanus, kirjuta täisarvuna: ");
            int isikuVanus = 0;
            isikuVanus = int.Parse(Console.ReadLine());
            if (isikuVanus <= 0)
            {
                Console.WriteLine("Ajarändureid me ei teeninda");
            }
            else if (isikuVanus > 0 && isikuVanus < 18)
            {
                Console.WriteLine("Palun sisesta oma nimi:");
                string kasutajaNimi = "";
                kasutajaNimi = Console.ReadLine();
                Console.WriteLine($"Kallis {kasutajaNimi}, palun kutsu siia oma lapsevanem.");
            }
            else
            {
                Console.WriteLine("Palun kirjuta siia oma Eesnimi:");
                string eesNimi = "";
                eesNimi = Console.ReadLine();
                Console.WriteLine("Palun kirjuta siia ka oma Perekonnanimi:");
                string perekonnaNimi = "";
                perekonnaNimi = Console.ReadLine();
                if(eesNimi == "" || perekonnaNimi == "")
                {
                    Console.WriteLine("Sisestama pidi mõlemad nimed >:C");
                }
                else
                {
                    Console.WriteLine($"Tere päevast {eesNimi} {perekonnaNimi}!");
                }
            }


              Näiteülesanne 7 - "kalkulaator" */
            /*  Console.WriteLine("palun sisesta esimene arv");
                float arv1 = 0.0f;
                arv1 = float.Parse(Console.ReadLine());

                Console.WriteLine("palun sisesta teine arv");
                float arv2 = 0.0f;
                arv2 = float.Parse(Console.ReadLine());

                Console.WriteLine("mis tüüpi tehet sa teha soovid? (+ - / * ^ V)");
                string tehtetüüp = "";
                tehtetüüp = Console.ReadLine();

                double tehteTulemus = 0.0d;
                if (tehtetüüp != "")
                {
                    switch (tehtetüüp)
                    {
                        default:
                            Console.WriteLine("tehtetüüp pole valitud, tehet ei sooritata");
                            break;
                        case "+":
                            tehteTulemus = arv1 + arv2;
                            break;
                        case "-":
                            tehteTulemus = arv1 - arv2;
                            break;
                        case "/":
                            tehteTulemus = arv1 / arv2;
                            break;
                        case "*":
                            tehteTulemus = arv1 * arv2;
                            break;
                        case "^":
                            tehteTulemus = Math.Pow(arv1, arv2);
                            break;
                        case "V":
                            tehteTulemus = Math.Pow(arv1, 1 / arv2);
                            break;
                    }
                    Console.WriteLine($"tehte tulemus on {arv1} {tehtetüüp} {arv2} = {tehteTulemus}");
                }
                else
                {
                    Console.WriteLine("tehtetüüp pole valitud, tehet ei sooritata");
                }
            */
            Console.WriteLine("palun sisesta esimene arv");
            float arv1 = 0.0f; // igapool on siin . aga kui mina oma arvutis seda proovin siis pean panema hoopis ,  ????
            arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("palun sisesta teine arv");
            float arv2 = 0.0f;// siin ka...??
            arv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("mis tüüpi tehet sa teha soovid? (+ - / * ^ V)");
            string tehtetüüp = "";
            tehtetüüp = Console.ReadLine();

            double tehteTulemus = 0.0d;

            if (tehtetüüp != "")
            {


                if (tehtetüüp == "+")
                {
                    tehteTulemus = arv1 + arv2;
                }
                else if (tehtetüüp == "-")
                {
                    tehteTulemus = arv1 - arv2;
                }
                else if (tehtetüüp == "*")
                {
                    tehteTulemus = arv1 * arv2;
                }
                else if (tehtetüüp == "^")
                {
                    tehteTulemus = Math.Pow(arv1, arv2);
                }
                else if (tehtetüüp == "/")
                {
                    tehteTulemus = arv1 / arv2;
                }
                else if (tehtetüüp == "V")
                {
                    tehteTulemus = Math.Pow(arv1, 1 / arv2);
                }
                else
                {
                    Console.WriteLine("tehtetüüp pole valitud, tehet ei sooritata");
                    return;
                }
                Console.WriteLine($"tehte tulemus on {arv1} {tehtetüüp} {arv2} = {tehteTulemus}");
            }
            else
            {
                Console.WriteLine("tehtetüüp pole valitud, tehet ei sooritata");
            }
                
        /*
         * int arv = 9001;
        Console.WriteLine(arv);
        double doublearv = arv;
        Console.WriteLine(doublearv);

        double uusdouble = 6.7;
        Console.WriteLine(uusdouble);
        int uusarv = (int)uusdouble;
        Console.WriteLine(uusarv);

        double uusinf1 = 1.23d;
        float newfloa1 = (float)uusinf1;
        long uuslong = (long)newfloa1;
        int uusint = (int)uuslong;
        char uuschar1 = (char)uusint;

        int lõpp = uuschar1;
        long lõpplong = lõpp;
        float floa2 = lõpplong;
        double doubleandnextperson = floa2;

        */


        // üleval harjutused

        https://meet.google.com/qjt-wofj-gdb

            //  all teooria

            ///*   -= S Ü N T A K S =-                             */
            Console.WriteLine("'Ommik"); // seeeeeeeeeeeeeeeeee
            string dm = Console.ReadLine(); // erm see on teine
            Console.WriteLine(":D");
            // ; <-- iga koodilause peab sellega lõppema
            // console - see on windowsi süsteemi/C# käsurea adreseermise pakett. millega saab erinevaid käsurea operatasioone teha; :D
            // . näitab alamkäsku/aadressi  nagu folderis olevat uut kohta, seda kasustakse et eelnevast objektist tulenevalt saada mingi meetod funktsioon
            // antud juhul adresseeritakse reas 174 (16.01.2026)  console tööriista
            // WriteLine on funktsioon mis praegu on olemas, see kuvab käsureale teksti või parameetreid
            // () sulud see sisaldab infot või parameetreid mis on funktsiooniks vajalikud
            // {} ma vihkan neid, tähistab koodiplokki konteineri jaoks
            // [] erm, tähistab massiivi (
            // "" tähistavad sõne (ehk string?) andmetüüpi. need andmed käivad "" vahel
            // string on andmetüüp mis käib muutuja (variable) ees. andmetüübis asuvad ka vajalikud funktsioonid mis on selle tüübiga seotud
            // dm (teine) on variable, mis omab stringi andmeid ja omistatakse omistusoperatsiooniga readline
            // readline (teine) funktsioon, loeb kasutaja poolt sisestatud string andmeid
            // // tähistab ülejäänud ühele reale kommentaari
            // /* */ nagu sulud, tähistavad suuremaid kommentaare kui 1 rida
            // /// funktsiooni summary kommentaar, kirjeldab meetodeid mille tekst kuvatakse välja tooltipina
            // tab - taane - aitab arendajal aru saada kuskohas või millise ploki sees kood praegu asub ning aitab järge pidada


            ///*   -= L I H T A N D M E T Ü Ü B I D =-             */
            //string tekst = "mingisugune inimloetav tekstike"; //tekst
            //char täht = 'A';
            //int arv = 1; //täisarv
            //float komakohagaarv = 1.5f; //32bit
            //double suuremkomakohagaarv = 1.5d; //64bit
            //decimal kümnendsüsteemiskomakohagaarv = 1.5M;
            //var x = 123; //Umbmäärase andmetüübiga ajutine muutuja
            //var y = "ABC";
            //bool jahvõiei = false; //kas true või false.

            ///* Muutuja nime näide: */
            ////string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud

            // 1    2 3   4  5
            string ap = "def";  /* 1. muutuja kirjutatakse alustades andmetüübist (string, int jne) selleta ei tööta. 2.
                                 * 2. siis on nimi, ja tavaliselt eesmärki nende nimedega.
            camelCase soovitatud, ehk esimene on väike ja siis uued sõnad suurega. 
                                   3. = ehk omistusoperaator, mis annad andmed 
                                   4. omistamisandmed
                                   5. lauselõpp */

            /*   -= O M I S T U S O P E R A A T O R I D =-          */
            // =    -> üksik võrdusmärk omistab muutja sisse väärtuse, mida adresseeritakse muutuja enda nimega
            int muutuja = 1;
            // +=   -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            muutuja += 2;
            // -=   -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva väärtuse
            muutuja -= 1;
            // *=   -> võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
            muutuja *= 3;
            // /=   -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            muutuja /= 4;
            // %=   -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi.
            muutuja %= 2;

            // ++   -> on kiirtehe, mis muutujale liidab ainult ühe juurde.
            muutuja++;
            // --   -> on kiirtehe, mis muutujast lahutab ainult ühe maha.
            muutuja--;

            /*   -= V Õ R D L U S O P E R A A T O R I D =-          */
            // ==   ->  "on võrdne/on täpselt sama" - Võrdusmärkide ühel pool olev objekt peab vastama
            //          oma olemuselt täpselt võrdusmärkide teisel pool oleva objektiga
            // >    ->  "on suurem kui" - Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt
            // <    ->  "on väiksem kui" - Märgist vasakul pool olev objekt peaks olema väiksem kui paremal pool olev objekt
            // >=   ->  "on suurem kui, või samavõrdne" - Märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem
            //          kui paremal pool olev objekt
            // <=   ->  "on väiksem kui, või samavõrdne" - Märgist vasakul pool olev objekt peaks olema maksimaalselt sama suur või väiksem
            //          kui paremal pool olev objekt
            // !=   ->  "ei tohi olla" võrdusmärgi vasakul pool olev objekt ei tohi omada IDENTSET kuju paremal pool oleva objektiga, kõik muud
            //          väärtused on lubatud.

            /*   -= L O O G I L I S E D    T E H T E D =-          */
            // &&   ->  "AND" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
            //          mõlemal pool märki "&&" olevad tingimused omakorda annavad oma avaldise tulemusena "true"
            //          või teisisõnu: true + true = true
            // ||   ->  "OR" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
            //          ühel pool märki "||" olev tingimus annab oma avaldise tulemusena "true", ei ole vahet millisel pool märki
            //          või teisisõnu: true + false = true
            // !    ->  "NOT" loogiline tehe, mida kasutatakse tingimuse avaldise tulemuse inverteerimiseks. Tulemus mis muidu tagastaks "true",
            //          hüüumärgi abil nüüd tagastab false, ja vastupidi - tulemus mis muidu tagastaks "false", nüüd tagastab "true".
            //          ehk teisisõnu: true = false / false = true

            /*   -= T I N G I M U S L A U S E =-                   */
            if (true)       //  Kaitstud sõna "if" kutsub esile tingimuslause, mille tingimuse avaldis on sellele järgnevate () sulgude vahel.
            {               //  Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui tingimuse avaldis annab tulemusena "true",
                            //  "false" tulemuse puhul jäetakse kood vahele
            }
            else if (true)  //  Kaitstud sõnad "else" ja "if" (koos "else if") kutsuvad esile sekundaarse tingimuslause, mille tingimus on samamoodi
                            //  sellele järgnevate sulgude vahel, ning millele peab alati eelnema kas "if" või teine "else if". Else if tingimust
                            //  kontrollitakse ainult siis, kui sellele eelnev tingimus tagastab avaldise tulemusena "false".
            {               //  Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui else if tingimuslause avaldis annab tulemusena "true",
                            //  "false" tulemuse puhul jäetakse kood vahele ning minnakse edasi järgneva tingimuse või teostatava koodi juurde.
            }
            else            //  Kaitstud sõna "else" kutsub esile järeltingimuslause, millele peab eelnema alati kas "if" või "else if" tingimuslause, ning
            {               //  mille koodiploki sisu täidetakse ilma oma tingimuse avaldise kontrollita (ei oma avaldist) kuna else koodiplokk teostatakse
                            //  kõikide teiste tingimuste läbikukkumisel (kõik eelnevad tagastavad tulemusena "false")
            }

            /*  -= teisendamine / castimine =-  
            // castimine on arvu teisendamine ühest liigist teise või see mis ma teen järvel üksi
            automaatsne castimine on see kui väiksemast andmetüübist teisendatakse suuremasse
            manuaalne on siis kui seda tehakse suuremast väiksemasse, peab sulud ette panema koos soovitud andmetüübiga



            */



            // see on manuaalne
            double uusinf2 = 1.23d; // algus castimine
            float newfloa2 = (float)uusinf2; // saadakse float ja nimetatkse floatina
            long uuslon2 = (long)newfloa2; // jne jne long
            int uusin2 = (int)uuslon2; // jne jne int
            char uuschar2 = (char)uusin2; // jne jne char

            // see on automaatne
            int lõp2 = uuschar2; // jne jne tagasi
            long lõpplon2 = lõp2; // jne jne long
            float floa3 = lõpplon2; // jne jne float
            double doubleandnextperso2 = floa3; // jne jne double

            // suuremast väiksemasse teisendamine kaotab resulutsiooni, mida ei saa tagasi isegi kui teed sama tagurpidi
        }
    }
}
