
using System;

  
class Program{

     public static void Main(string[] args){


        int numeroGanador = 4;
        bool numeroAdivinado = false;


        
        while (!numeroAdivinado)
        {// el bucle while hace que el usuario vuelva a introducir un numero si el que introdujo no es el correcto// 

            Console.WriteLine("Introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());


            if (numero == numeroGanador)
            {

                Console.WriteLine("Haz adivinado el numero ganador");
                numeroAdivinado = true;

            }

            else {
                Console.WriteLine("No adivinaste el numero (Introduce otro numero)");
         
            }

        }
   
     }

}