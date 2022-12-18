using System;
using System.Xml.Serialization;

namespace b3_dev_tu_flamant_benoit_armand_lelio
{
    public class Program
    {
        //Calculator main program 

        static int AskNumberInt(int min, int max)
        {
            // Force to input an integer between min and max
            Console.Write($"Rentrez un nombre compris entre {min} et {max}: ");
            bool nb_mauvais = true;
            int nb = 0;
            while (nb_mauvais)
            {
                try
                {
                    string saisie = Console.ReadLine();
                    if (!(int.TryParse(saisie, out nb)))
                    {
                        Console.WriteLine("Saisie incorrecte, veuillez ressaisir un nombre.");
                    }
                    else if ((nb < min) || (nb > max))
                    {
                        Console.WriteLine($"Saisie incorrecte, veuillez ressaisir un nombre compris entre {min} et {max}.");
                    }
                    else
                    {
                        nb_mauvais = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    nb_mauvais = false;
                }
            }
            return nb;
        }

        static double AskNumberDouble()
        {
            //Force to input a double
            bool nb_mauvais = true;
            double nb = 0;
            while (nb_mauvais)
            {
                try
                {

                    string saisie = Console.ReadLine();
                    if (!(double.TryParse(saisie, out nb)))
                    {
                        Console.WriteLine("Saisie incorrecte, veuillez ressaisir un nombre.");
                    }
                    else
                    {
                        nb_mauvais = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    nb_mauvais = false;
                }
            }
            return nb;
        }
        static void Main(string[] args)
        {
            //Display different choices
            Console.WriteLine("Quelle opération souhaitez-vous faire?");
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Soustraction");
            Console.WriteLine("3 : Multiplication");
            Console.WriteLine("4 : Division");
            Console.WriteLine("5 : Pourcentage");
            Console.WriteLine("6 : Carré");
            Console.WriteLine("7 : Racine carrée ");
            Console.WriteLine("8 : Puissance");

            //Do your choice
            int operatorChoice = AskNumberInt(1, 8);

            if (operatorChoice <= 5 || operatorChoice == 8)
            {
                //Ask numbers for operations 1 to 5 and 8
                Console.Write("Choisir le premier nombre: ");
                double numberA = AskNumberDouble();
                Console.Write("Choisir le second nombre: ");
                double numberB = AskNumberDouble();
                switch (operatorChoice)
                {
                    case 1:
                        Console.WriteLine($"Le résultat est {Arithmetic.Addition(numberA, numberB)}");
                        break;
                    case 2:
                        Console.WriteLine($"Le résultat est {Arithmetic.Substraction(numberA, numberB)}");
                        break;
                    case 3:
                        Console.WriteLine($"Le résultat est {Arithmetic.Multiplication(numberA, numberB)}");
                        break;
                    case 4:
                        while(numberB == 0)
                        {
                            Console.Write("Division par 0 impossible, veuillez ressaisir un nombre: ");
                            numberB = AskNumberDouble();
                        }
                        Console.WriteLine($"Le résultat est {Arithmetic.Division(numberA, numberB)}");
                        break;
                    case 5:
                        while(numberB < 0 || numberB > 100)
                        {
                            Console.Write("Un pourcentage doit être entre 0 et 100, veuillez ressaisir un nombre : ");
                            numberB = AskNumberDouble();
                        }
                        Console.WriteLine($"Le résultat est {Arithmetic.Percentage(numberA, numberB)}");
                        break;
                    case 8:
                        Console.WriteLine($"Le résultat est {Scientific.Power(numberA, numberB)}");
                        break;
                }
            }
            else
            {
                //Ask number for square and square root
                Console.Write("Choisir un nombre:");
                double number = AskNumberDouble();
                switch (operatorChoice)
                {
                    case 6:
                        Console.WriteLine($"Le résultat est {Scientific.Square(number)}");
                        break;
                    case 7:
                        while(number < 0)
                        {
                            number = AskNumberDouble();
                        }
                        Console.WriteLine($"Le résultat est {Scientific.SquareRoot(number)}");
                        break;
                }
            }            
        }
    }
}
