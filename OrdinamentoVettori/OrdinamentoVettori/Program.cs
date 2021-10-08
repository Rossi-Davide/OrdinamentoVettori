using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione vettore 
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //ordinamento vettore
            ordina(vettore);

            //stampa vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //metodo per ordinamento del vettore
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
