using System;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Programa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CronometroMetodo(() =>
            {
                try
                {
                    Console.WriteLine("ALGORITMO DE ORDENAMIENTO MAMALON");
                    Console.WriteLine("INGRESA UNA CADENA DE TEXTO PRRO");

                    //Obtener cadena de texto
                    string sTexto = Console.ReadLine();
                    //Crear un array con las palabras ingresadas
                    string[] sPalabrasArray = sTexto.Split(' ');

                    Console.WriteLine("Resultados de ordenamiento.");

                    //Tomar los 255 caracteres tipo char
                    for (int j = 0; j < 255; j++)
                    {
                        for (int i = 0; i < sPalabrasArray.Length; i++)
                        {
                            char[] palabra = sPalabrasArray[i].ToCharArray();

                            //verificar el primer caracter para ordenar
                            if (sPalabrasArray[i] != "" && palabra[0] == j)
                            {
                                string st = new string(palabra);
                                Console.WriteLine(st);
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("No existe ningun caracter a ordenar");
                }
            });




        }

        public static void CronometroMetodo(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action.Invoke();
            stopwatch.Stop();
            Console.WriteLine("\nTienpo de proceso " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}

