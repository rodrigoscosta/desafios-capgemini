using System;
using System.Collections.Generic;

namespace Desafio3
{
    class Program
    {
        static void Substring(string s)
        {
            Dictionary<string, int> mapa = new Dictionary<string, int>();

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i; j < s.Length; j++)
                {
                    char[] arrayEmChar = s.Substring(i, j+1-i).ToCharArray();
                    Array.Sort(arrayEmChar);

                    string val = new string(arrayEmChar);
                    if (mapa.ContainsKey(val)) {mapa[val] = mapa[val]+1;}

                    else {mapa.Add(val, 1);}
                }
            }
            
            int contarParAnagrama = 0;
            foreach(string k in mapa.Keys)
            {
                int valor = mapa[k];
                
                contarParAnagrama += (valor * (valor-1))/2;
            }
            Console.WriteLine(contarParAnagrama);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Digite a string: ");
            var stringDoUsuario = Console.ReadLine();
            Substring(stringDoUsuario);
        }
    }
}