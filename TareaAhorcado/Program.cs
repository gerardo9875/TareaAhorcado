using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAhorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al juego de ahorcado");

            
                string[] palabras = { "perro", "gato", "leon", "renacuajo" };
                Random random = new Random();
                int random_num = random.Next(0, 4);
                char[] letras = palabras[random_num].ToCharArray();
                int word_lenght = letras.Length;
                int[] flagletras = new int[word_lenght];
                int intentos = 10;

                for (int i = 0; i < word_lenght; i++)
                {
                    flagletras[i] = 0;
                }

            bool game = true;

            do
            {
                int letrascheck = 0;
                Console.WriteLine("Intentos restantes: " + intentos);
                for (int j = 0;j < word_lenght; j++)
                {
                    if (flagletras[j] == 0)
                    {
                        Console.Write(" _ ");
                    }

                    else
                    {
                        Console.Write(" " + letras[j] + " ");
                        letrascheck++;

                    }
                }

                if (letrascheck == word_lenght)
                {

                    Console.WriteLine("Has ganado el juego");
                    game = false;
                    Console.ReadLine();

                }

                else
                {

                    Console.WriteLine("Ingresa una letra:");
                    char letr = Convert.ToChar(Console.ReadLine());
                    bool flagcheck = false;
                    for (int x = 0; x < word_lenght; x++)
                    {
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;
                            flagcheck = true;
                        }
                    }
                    if (flagcheck == false)
                    {
                        intentos--;
                    }

                    if (intentos == 0)
                    {
                        game = false;
                        Console.WriteLine("Fin del juego");
                        Console.ReadLine();
                    }

                }

            }

               
            while (game == true);


            

        }
    }
}
