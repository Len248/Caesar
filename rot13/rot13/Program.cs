using System;

namespace rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Um wie viel soll es verschoben werden");
            int tauschzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("type in a caesar Cipher word with a left shift of 3: ");

            string satz = Console.ReadLine();
            char[] buchstaben = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] b = new char[satz.Length];
            int index = 0;
            satz = satz.ToLower();
            b = satz.ToCharArray();

            for (int i = 0; i < b.Length; i++)
            {
                for (int y = 0; y < buchstaben.Length; y++)
                {
                    if (b[i] == buchstaben[y])
                    {
                        index = y;
                        index = index + tauschzahl;
                        if (index > 25)
                        {
                            index = index - 26;
                        }
                        b[i] = buchstaben[index];
                        index = 0;
                        y = buchstaben.Length;
                    }
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }

            Console.ReadKey();
        }
    }
}
