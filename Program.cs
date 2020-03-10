using System; //Här berättar för c# vilka bibliotek, som innehåller en massa kod som andra redan har skrivit, ska användas.
              //Så kan jag få tillgång till funktionalitet som jag behöver, t.ex. 
              //är det via bibliotek som jag får möjlighet att skriva ut text på skärmen i vårt konsolprogram via Console.WriteLine().
using System.Collections.Generic;//för att använda List-klassen så måste anges detta bibliotek
using System.Linq;
using System.Text;
using System.Threading;//För att arbeta med "Threads" class som arbetar med "threads".

namespace logBook//En namespace är något som används för att organisera kod, den följt av namnet på programmet 
                 //
{// Här börjar namespace logbook:s kodblock. All kod vi skriver ligger mellan två klammerparenteser och kallas kodblock,som kan innehålla flera anrda kodblock som kallas för underkodblock
    /*
     * 
     * 
     * 
     * */
    class Program// En klass är sätt att sortera och strukturera koden
    {//här börjar klassen program:s kodblock.

        static void Main(string[] args)// Koden börjar i Main-metoden som först laddas när vi startar ett program.
        {//här börjar metoden Main():s kodblock.

            List<string[]> myList = new List<string[]>();//Skapa en lista som innehåller vektorer, inom <>-parenteserna innehållar type av lista objekt
                                                         //Här används typen string av typen vecktor då det blir smidigare att arbeta med Loggboken (En container kan innehålla andra containers)
                                                         // därefter skriver jag namnet på lista som här döper jag den till myList, i och med anväds ordet new skaps plats i minnet för att lagra en lista.
                                                         //återigen anger jag att jag vill att listan ska innehålla string av typn vektor värde
                                                         //så skapas ett nytt objekt, myList till villken jag kan lägga och ta bort string[] värde
            bool isRunning = true;// Här skapar jag en variabel av typen "bool" och tilldelar den ett true värde. Booleansk variabel kan endast innehålla ett av två värden "ture eller false"
            while (isRunning)// skapa en loop som körs tills användren väljer att avsluta programmet och trycker 6. En while-loop fortsätter så länge det som står i parenteserna efter ordet while är sant.
                             // i detta fall skriver jag en booleansk värde som innehåller sant "true" värde, då när jag vill att while-loop ska avbryta tilldelar jag booleansken värde ett falskt"false" värde.

            {// Här börjar while-loppens kodblock

                Console.Clear();//Använd metoden Console.Clear () för att rensa konsol skärmen. Jag användar den för att skapa ett enkelt och gott gränssnit som ska inte innehålla alla texter
                Console.ForegroundColor = ConsoleColor.White;//används lite snygga grejer för att välja linjens färg för menyen
                Console.WriteLine("\n\t\tVälkommen till Loggboken\n\t\t#########################\n\n\tVar vanlig och välj ett alternativ:\n\n\t[1]Spara nya inlägg i loggboken\n\n\t[3]Skriva ut loggar från loggboken\n\n\t[3]Söka inlägg i loggboken via postens titel\n\n\t[4]Redigera loggar via index\n\n\t[5]Ta bort loggar\n\n\t[6]Avsluta program");
                //Via metoden console.Write()(som används för att skriva ut data i konsolfönster) skriv ut meny till användaren för att välja ett alternativ, använding av /n för att börja en ny rad, /t för att göra ett flikutrymme

                Int32.TryParse(Console.ReadLine(), out int meny);// Tar emot användarinput för meny
                                                                 // här anropar jag TryParse metoden för att konvertera ett värde till ett heltal.
                                                                 /*Int32 visar att vi vill ha ett heltal. TryParse kallar på metoden. indata för metoden är Console.ReadLine()och det är
                                                                 användaren får skriva in något. "out" visar att  metoden har utdata som den är en vaiabel av typ int som deklareras och
                                                                 meny är namnet vi ger till den här nya variabeln.*/
                                                                 //
                switch (meny) //Här använder jag switch som lämpar sig bäst för menystrukturer när meny har många olika utfall. switch-satsen är en typ av selektion
                              //I switch-satsen definieras en eller flera case-satser som sedan avslutas med nyckelordet break.
                              //här hanterar swich-satsen variabln meny som skulla jämföra användarens val med varje fall nedan.
                {
                    case 1:// varje case följs av ett värde som direkt jämförs med det uttryck som switch-satsen hanterar
                           //Efter värdet följs ett : och sedan koden som körs när fallet(case) inträffar.
                        Console.Clear();
                        string[] myArray = new string[4];//Jag skapar ett string-objekt som är av type vektoren.Hakparenteserna indikerar att det är en vektor som jag vill ha och inte en vanlig variabel.
                                                         //Ordet new använs för att skapa plats i minnet för att lagra en stringvektor med just tre element.
                        Console.WriteLine("Vilken titel ska inlägget ha:");//Låt användaren mata in titel
                        string tittle = Console.ReadLine();//Via metoden console.ReadLine() tar in data från användaren och sparar texten som skrivs till en string-variabel som jag kallar tittle
                        if (tittle.Length <= 0)
                            tittle = "Den inlägg har ingen titel";
                        else
                            myArray[0] = tittle;//  informationen på titel är sparade i den första element i en vektor, som vi sedan lägger till i listan. genom index tilldela vektorns element olika string värde.
                                                //Genom en siffra indexerar ett specifikt element i vektorn. index är den som står inne i hakparanttesen efter vektorns namnet och börjar på 0
                                                // Index används både för att skriva(värde till) och läsa ett element.

                        Console.WriteLine("Skriv ett meddelande till inlägget:");//Låt användaren mata in meddelande
                        string post = Console.ReadLine();//sparar användarens inmatning i string-varaiabel som döper till post
                        if (post.Length <= 0)
                            post = "Den inlägg har ingen meddelande";
                        else
                            myArray[1] = post;//för att sedan sparar den i andra element av vektorn


                        DateTime myDateAndTime = DateTime.Now;
                        myArray[2] = myDateAndTime.ToString();
                        myArray[3] = myDateAndTime.ToString("dddd");// i den tredje element vill jag att spara tid och datum.



                        myList.Add(myArray);// Efter att sparat element i en vektor,  sedan lägger jag den till i listan med hjälp av add()metoden.
                                            //Add()-metoden tar emot ett värde som indata. Vilken type av objekt den tar beror på vilken typ skrevs och skulle användas när listan skapades
                                            //jag bestämde att jag ville ha vektor så addera jag vektor-värde till listan.

                        MenyAvslut();// Kallar på den standardiserade menyavslutning som skapas för att undvika upprepande kod
                        break;//avslutas en case med ordet break, som alltså avbryter hela switch-satsen

                    case 2:

                        Console.Clear();
                        if (myList.Count > 0)
                        {
                            sortering(myList, 2);
                            Utskrift(myList);
                        }
                        else
                        {
                            Console.WriteLine("\n\tDet finns inga inlägg i loggboken för att skriva ut. Generera lite först.");
                        }
                        MenyAvslut();
                        break;

                    case 3:

                        Console.Clear();
                        if (myList.Count > 0)
                        {
                            sortering(myList, 0);
                            Console.WriteLine("\n\tVilken titel vill du söka?");
                            string key = Console.ReadLine();
                            if (key.Length <= 0)
                                key = "a";

                            int i = 0;
                            int first = 0;
                            int last = myList.Count - 1;
                            while (first <= last)
                            {
                                int mitt = (first + last) / 2;
                                if (string.Compare(key, myList[mitt][i]) > 0)
                                {
                                    first = mitt + 1;
                                }
                                else if (string.Compare(key, myList[mitt][i]) < 0)
                                {
                                    last = mitt - 1;
                                }
                                else
                                {
                                    Console.WriteLine("Titeln som du söker finns på index " + mitt + " i Loggboken  och denna innehåll : " + myList[mitt][i + 1] + " , den skrivs den : " + myList[mitt][i + 2]);
                                    break;
                                }

                            }
                            if (first > last)
                            {
                                Console.WriteLine("sökningen inte lyckades");
                            }

                            Utskrift(myList); // Skriver ut hela listan med vår metod.
                        }
                        else
                        {
                            Console.WriteLine("\n\tDet finns inga inlägg i loggboken för att söka för.Generera lite först");
                        }
                        MenyAvslut();
                        break;

                    case 4:
                        Console.Clear();
                        bool isEdit = true;
                        while (isEdit)
                        {

                            if (myList.Count > 0)
                            {
                                Console.WriteLine("ange index på inlägg som du vill redigera ");
                                if (Int32.TryParse(Console.ReadLine(), out int index))//Här använder vi TryParse som en bool. Om konverteringen fungerar och det inte blir några fel,
                                                                                      // så blir det "sant", och går in i IF-satsen som ett villkor.Om det inte fungerar går den in i 
                                                                                      //else istället, då dess utslag blir falskt
                                {
                                    if (0 <= index && index < myList.Count)
                                    {


                                        Console.WriteLine("Vilken titel ska det nya inlägget ha:");
                                        string tittle2 = Console.ReadLine();
                                        myList[index][0] = tittle2;

                                        Console.WriteLine("Skriv ett meddelande till det nya inlägget:");
                                        string post2 = Console.ReadLine();
                                        myList[index][1] = post2;

                                        Console.WriteLine("den har ändrat");
                                        isEdit = false;
                                    }

                                    else
                                    {
                                        Console.WriteLine(" Var Vänlig och välja mellan 0 och " + (myList.Count - 1));

                                    }
                                }


                                else
                                {
                                    Console.Clear();

                                    Console.WriteLine("fel inmatning");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Det finns inga inlägg i loggboken för att redigera. Generera lite först");
                                isEdit = false;
                            }
                        }
                        MenyAvslut();
                        break;

                    case 5:
                        Console.Clear();

                        if (myList.Count > 0)
                        {
                            bool isRemoving = true;
                            while (isRemoving)
                            {

                                Console.WriteLine("Vill du ta bort all loggar?\n [1]ja\n [2]nej\n");
                                string answer = Console.ReadLine();
                                if (answer.ToLower() == "ja" || answer == "1")
                                {
                                    myList.RemoveRange(0, myList.Count);
                                    Console.WriteLine("Du har tagit bort all loggar ");
                                    isRemoving = false;
                                }
                                else if (answer.ToLower() == "nej" || answer == "2")
                                {

                                    Console.WriteLine("Du vill inte ta bort loggar");
                                    isRemoving = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nVar vanlig och välja 1 eller 2, ja eller nej\n");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\tDet finns inga inlägg i loggboken för att at bort. Generera lite först");
                        }

                        MenyAvslut();
                        break;

                    case 6:
                        Console.WriteLine("\n\tTack för att du användar vår loggbok program!");
                        Thread.Sleep(1000);
                        isRunning = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tVälj ett nummer mellan 1-6 i menyn.");
                        MenyAvslut();
                        break;

                }
            }
        }//Här slutar metoden Main():s kodblock




        static void sortering(List<string[]> myList, int d)
        {


            int max = myList.Count - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {

                    if (string.Compare(myList[j][d], myList[j + 1][d]) > 0)
                    {
                        string[] temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;

                    }
                }
            }

        }


        static void MenyAvslut()
        {
            Console.WriteLine("\n\tTryck ENTER för att återvända till menyn.");
            Console.ReadLine();
        }

        static void Utskrift(List<string[]> myList)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nindex");
            int index = 0;
            foreach (var item in myList)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n" + index);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t  **" + item[0] + "**" + "\n\t\t" + item[3] + ", " + item[2] + "\n   " + item[1] + "\n\n\t**********\n");// Skriv ut lite snygga grejer
                index++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }//Här slutar klassen program:s kodblock
}