// 1- Faça um programa que crie uma matrix de números inteiros na quantidade de linhas e colunas que o usuário informar.
// Essa matriz deve ser populada automaticamente e ser exibida do primeiro ao ultimo e do ultimo para o primeiro.

using System.Security.Cryptography;

int[,] PopulaMatriz(int[,] matriz, int tamanho)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        }
    }

    return matriz;
}

void ExibeMatriz(int tamanho, int[,]matriz)
{
    for(int i = 0; i < tamanho; i++)
    {
        for(int j = 0;j < tamanho; j++)
        {
            Console.Write($"[{matriz[i,j]}] ");
        }
        Console.WriteLine(" ");
    }
}
void ExibeMatrizInversa(int tamanho, int[,] matriz)
{
    for (int i = tamanho-1; i > 0; i--)
    {
        for (int j = tamanho-1; j> 0; j--)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}

int tamanho;

Console.WriteLine("Digite o tamanho da matrix");
tamanho = int.Parse(Console.ReadLine());

int [,] matriz = new int[tamanho,tamanho];

PopulaMatriz(matriz, tamanho);
ExibeMatriz(tamanho, matriz);
Console.WriteLine("-------------------------");
ExibeMatrizInversa (tamanho, matriz);

