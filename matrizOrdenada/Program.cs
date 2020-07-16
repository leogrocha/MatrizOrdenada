using System;


namespace VetorOrdenado
{
    class Program
    {
        const int tamanho = 2;
        static void Main(string[] args)
        {
            int[,] matriz = new int[tamanho, tamanho];


            criaMatriz(matriz);
            ordenaMatriz(matriz);

            Console.WriteLine();
            Console.WriteLine("Matriz Ordenada: ");
            Console.WriteLine();
            matrizOrdenada(matriz);


        }

        static void criaMatriz(int[,] matriz)
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write("Matriz[" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ordenaMatriz(int[,] matriz)
        {
            int aux = 0;

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {

                    for (int l = 0; l < tamanho; l++)
                    {
                        for (int c = 0; c < tamanho; c++)
                        {
                            if (matriz[i, j] < matriz[l, c])
                            {
                                aux = matriz[i, j];
                                matriz[i, j] = matriz[l, c];
                                matriz[l, c] = aux;
                            }
                        }
                    }
                }
            }
        }

        static void matrizOrdenada(int[,] matriz)
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.WriteLine("Matriz[" + i + "][" + j + "]: " + matriz[i, j]);
                }
            }

        }


    }
}
