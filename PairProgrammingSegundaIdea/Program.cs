using System;

namespace PairProgrammingSegundaIdea
{
    class InvertMatrix
    {
        static void Main(string[] args)
        {
            InvertMatrix inversorMatrix = new InvertMatrix();
            int[,] matrizAInvertir = new int[2, 4];
            int x = 0, y = 0;
            Console.WriteLine("Vamos a llenar una matriz con numeros enteros y luego invertir las posiciones de sus columnas");
            for (y = 0; y < 4; y++)
            {
                for (x = 0; x <= 1; x++)
                {
                    matrizAInvertir[x,y] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Asi es como se ve la matriz que acabamos de ingresar:");
           
            inversorMatrix.EscribirUnaMatrizEnPantalla(matrizAInvertir);

           

            int numeroAuxiliar;
                for(y = 0; y < 4; y++)
                {
                    numeroAuxiliar = matrizAInvertir[0, y];
                    matrizAInvertir[0,y] = matrizAInvertir[1, y];
                    matrizAInvertir[1, y] = numeroAuxiliar;
                }

            Console.WriteLine("Y asi se ve ordenada:");
            inversorMatrix.EscribirUnaMatrizEnPantalla(matrizAInvertir);


            Console.ReadLine();
        }

        public void EscribirUnaMatrizEnPantalla(int[,] matrizAEscribir)
        {
            int x = 0;
            int y = 0;
            
            
                for (y = 0; y < 4; y++)
                    {
                    for (x = 0; x < 2; x++)
                        {
                        Console.Write(matrizAEscribir[x, y] + " ");
                        }
                Console.WriteLine();
                    }
                
        }

        
    }
}

