using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Area.Sol.Logic
{
    //RISOLVERE PROBLEMA NUMERI DECIMALI(VIRGOLA/PUNTO);CREARE VALIAZIONI IF\CICLO DO WHILE PER EVITARE L'USCITA DALL'OPERAZIONE CORRENTE IN CASO DI ERRORE.
    public class Aree
    {
        public float triangolo()
        {
            try 
            {
                Console.Write($"\ninserisci lunghezza base:");
                float b = float.Parse(Console.ReadLine());
                Console.Write($"\ninserisci lunghezza altezza:");
                float a = float.Parse(Console.ReadLine());
                float areaT;
                areaT = (b * a) / 2;
                Console.WriteLine($"base:{a}, altezza:{b}");
                Console.WriteLine($"l'area è: {areaT}");
                return areaT;

            } catch  (Exception ex)
            {
                Console.WriteLine($"Attenzione, inserire un numero valido: ({ex.Message})");
            }
        
        return 0;
        }
        public float quadrato()
        {
            try
            {
                Console.Write($"\ninserisci lunghezza lato:");
                float lato = float.Parse(Console.ReadLine());
                float areaQ;
                areaQ = lato * lato;
                Console.WriteLine($"lato:{lato}");
                Console.WriteLine($"l'area è: {areaQ}");
                return areaQ;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attenzione, inserire un numero valido: ({ex.Message})");
            }
        
        return 0;
        }
        public double cerchio()
        {
            try
            {
                Console.Write($"\ninserisci lunghezza raggio:");
                float raggio = float.Parse(Console.ReadLine());
                double r = Math.Pow(raggio, 2);
                //const double Pi = 3.14159;
                double areaC;
                areaC = r * Math.PI;
                Console.WriteLine($"raggio:{raggio}");
                Console.WriteLine($"l'area è: {areaC}");
                return areaC;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attenzione, inserire un numero valido: ({ex.Message})");
            }
        
        return 0;
        }
    }
}
