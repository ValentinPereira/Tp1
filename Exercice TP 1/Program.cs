using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_TP_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Veuiller nous donner votre poid "); // demande à l'utilisateur son poid.
            bool trueWeight; // Utilise la variable pour déterminer une valeur indéterminé.
            /* tryparse = nom de ta variable bool suivis du tryparse, en entrée le console readline récupère l'entrée utilisateur
             * suivi d'une virgule, le out dit au programme de faire une sortie 
             */
            trueWeight = double.TryParse(Console.ReadLine(), out double weights); 
            Console.WriteLine(weights);
            
            //double weight = double.Parse(Console.ReadLine());
            //double.TryParse(weight, out trueweight);

            Console.WriteLine(" Veuiller nous indique votre taille "); // demande à l'utilisateur sa taille.
            bool trueLeight; // Utilise la variable pour déterminer une valeur indéterminé
            trueLeight = double.TryParse(Console.ReadLine(), out double heights);
            Console.ReadKey();
            
            double imc = weights / (heights * heights) * 10000; // imc = Math.Round(imc, 2); 2 chiffre après la virgule

            Console.WriteLine(imc);
            
              if (imc < 16.5)
            {
                Console.WriteLine("vous êtes en dénutrition");
            }            
            else if ((imc < 16.5) && (imc < 18.5))
            {
                Console.WriteLine("vous êtes en maigreur");
            }

            else if ((imc < 18.5) && (imc < 25))
            {
                Console.WriteLine("vous êtes en corpulence normal");
            }

            else if ((imc < 25) && (imc < 30))
            {
                Console.WriteLine("vous êtes en surpoids");
            }

            else if ((imc < 30) && (imc < 35))
            {
                Console.WriteLine("vous êtes en obésité modérée");
            }

            else if ((imc < 35) && (imc < 40))
            {
                Console.WriteLine("vous êtes en obésité sévére");
            }

            else if (imc > 40)
            {
                Console.WriteLine("vous êtes en obésité massive");
            }

        }
    }
}
