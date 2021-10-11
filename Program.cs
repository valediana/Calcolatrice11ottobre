using System;

namespace Calcolatrice11ottobre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Questa è una calcolatrice!");
            Console.WriteLine("Come ti chiami?");
            string nomeUtente; //dichiarazione
            nomeUtente = Console.ReadLine();
            Console.WriteLine($"Ciao {nomeUtente}!");
            bool continua = false;

            do
            {
               
                int primoNumero;

                do
                {
                    Console.WriteLine("Inserisci il primo numero intero:");

                } while (!int.TryParse(Console.ReadLine(), out primoNumero));
                Console.WriteLine($"Il primo numero che hai inserito è: {primoNumero}");

                int secondoNumero;
                do
                {
                    Console.WriteLine("Inserisci il secondo numero intero:");

                } while (!int.TryParse(Console.ReadLine(), out secondoNumero));
                Console.WriteLine($"Il secondo numero che hai inserito è: {secondoNumero}");

                Console.WriteLine("\n--------------------Menu----------------------\n");
                Console.WriteLine("Scegli A per fare la somma dei 2 numeri inseriti");
                Console.WriteLine("Scegli B per fare la differenza dei 2 numeri inseriti");
                Console.WriteLine("Scegli C per fare il prodotto dei 2 numeri inseriti");
                Console.WriteLine("Scegli D per fare il quoziente dei 2 numeri inseriti");

                char sceltaUtente;

                do
                {

                    Console.WriteLine("\nFai la tua scelta");
                    sceltaUtente = Console.ReadKey().KeyChar;
                    //} while (sceltaUtente=='A' || sceltaUtente=='B' || sceltaUtente == 'C' || sceltaUtente == 'D'); //case sensitive
                } while (!(sceltaUtente.ToString().ToUpper() == "A" || sceltaUtente.ToString().ToUpper() == "B" || sceltaUtente.ToString().ToUpper() == "C" || sceltaUtente.ToString().ToUpper() == "D")); //case sensitive

                Console.WriteLine($"la tua scelta è {sceltaUtente}\n");

                switch (sceltaUtente.ToString().ToUpper())
                {
                    case "A":
                        int s=Somma(primoNumero, secondoNumero);
                        Console.WriteLine($"La somma è: {s}");
                        break;
                    case "B":
                        int sot=Sottrai(primoNumero, secondoNumero);
                        Console.WriteLine($"La differenza è: {sot}");
                        
                        break;

                    case "C":
                        int mol=Moltiplica(primoNumero, secondoNumero);
                        Console.WriteLine($"Il prodotto è: {mol}");
                        break;

                    case "D":
                        if (secondoNumero == 0)
                        {
                            Console.WriteLine("Impossibile");
                        }
                        else
                        {
                           double div= Dividi(primoNumero, secondoNumero);
                           Console.WriteLine($"Il quoziente è: {div}");
                        
                        }
                        break;
                }

                Console.WriteLine("Vuoi continuare? Inserisi si per continuare, qualsiasi altra cosa per uscire");
                string risposta = Console.ReadLine();


                if (risposta.ToLower() == "si")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }

            } while (continua);


        }
        private static int Somma(int m, int n)
        {
            int addizione = m + n;
            return addizione;
        }

        private static int Sottrai(int m, int n)
        {
            return m - n;
        }

        private static int Moltiplica(int m, int n)
        {
            return m * n;
        }

        private static double Dividi(int m, int n)
        {

            double quoziente = (double)m / n;
            return quoziente;
        }
    }
}
        

    






