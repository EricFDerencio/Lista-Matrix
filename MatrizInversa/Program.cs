// 2- Faça um programa que gere uma matrix 3x5 populada automaticamente e baseada nela gere uma nova matrix inversa(5x3).

using System.Security.Cryptography;

int[,] matriz = new int[3, 5];
int[,] matrizInversa = new int[5 , 3];
int[,] matrizEspelhada = new int[3, 5];

int[,] PopulaMatriz(int[,] matriz)
{
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        }
    }

    return matriz;
}
int[,] PopulaMatrizInversa(int[,] matriz, int[,]matrizInversa)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrizInversa[j,i] = matriz[i,j];
        }
    }

    return matriz;
}

int[,] PopulaMatrizEspelhada(int[,] matriz)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrizEspelhada[(2-i),(4-j) ] = matriz[(i), (j)];
        }
    }
    return matriz;
}
void ExibeMatriz(int[,] matriz)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}
void ExibeMatrizInversa(int[,] matriz)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}

PopulaMatriz(matriz);
ExibeMatriz(matriz);
Console.WriteLine("----------------------------------------");
PopulaMatrizInversa(matriz, matrizInversa);
ExibeMatrizInversa(matrizInversa);
Console.WriteLine("----------------------------------------");
PopulaMatrizEspelhada(matriz);
ExibeMatriz(matrizEspelhada);