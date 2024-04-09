using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Sol.Data;

namespace Area.Sol.Logic
{
    public class Menu
    {
        public static void show()
        {
            ConsoleKeyInfo mnuChoice;
            Aree aree = new ();

            do
            {
                #region Opzioni menu A SCHERMO
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Calcola Area (numeri interi e con la virgola)");
                Console.WriteLine(new string('*', 50));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A) Triangolo");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("B) Quadrato");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("C) Carchio\n");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("ESCI - premi f");
                Console.ResetColor();
                Console.WriteLine(new string('_', 30));
                mnuChoice = Console.ReadKey();
                #endregion

                switch ((Enums.Choices)mnuChoice.Key)
                {
                    #region call Metodi
                    case Enums.Choices.triangolo:
                        {
                            aree.triangolo();
                            Console.WriteLine("premi un tasto qualsiasi per tornare al menu principale");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case Enums.Choices.quadrato:
                        {
                            aree.quadrato();
                            Console.WriteLine("premi un tasto qualsiasi per tornare al menu principale");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case Enums.Choices.cerchio:
                        {
                            aree.cerchio();
                            Console.WriteLine("premi un tasto qualsiasi per tornare al menu principale");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
                        #endregion

                } while (mnuChoice.Key.ToString() != "F") ;
                #region Uscita
                Console.Clear();
                Console.WriteLine("  _____               .__                 .___                   .__ \r\n  /  _  \\______________|__|__  __ ____   __| _/___________   ____ |__|\r\n /  /_\\  \\_  __ \\_  __ \\  \\  \\/ // __ \\ / __ |/ __ \\_  __ \\_/ ___\\|  |\r\n/    |    \\  | \\/|  | \\/  |\\   /\\  ___// /_/ \\  ___/|  | \\/\\  \\___|  |\r\n\\____|__  /__|   |__|  |__| \\_/  \\___  >____ |\\___  >__|    \\___  >__|\r\n        \\/                           \\/     \\/    \\/            \\/    ");
                Thread.Sleep(900);
                #endregion

        }
    }
}
