// 2- Faça um programa que gere uma matrix 3x5 populada automaticamente e baseada nela gere uma nova matrix inversa(5x3).

const int LINHA = 3;
const int COLUNA = 5;

int[,] matriz = new int[LINHA, COLUNA];
int[,] matrizInversa = new int[COLUNA, LINHA];
int[,] matrizEspelhada = new int[LINHA, COLUNA];


int[,] PopulaMatriz(int[,] matriz)
{
    for (int i = 0; i < LINHA; i++)
    {
        for (int j = 0; j < COLUNA; j++)
        {
            matriz[i, j] = Random.Shared.Next(1, 9);
        }
    }
    return matriz;
}
int[,] PopulaMatrizInversa(int[,] matriz, int[,] matrizInversa)
{
    for (int i = 0; i < LINHA; i++)
    {
        for (int j = 0; j < COLUNA; j++)
        {
            matrizInversa[j, i] = matriz[i, j];
        }
    }
    return matriz;
}
int[,] PopulaMatrizEspelhada(int[,] matriz)
{
    for (int i = 0; i < LINHA; i++)
    {
        for (int j = 0; j < COLUNA; j++)
        {
            matrizEspelhada[(LINHA - 1) - i, (COLUNA - 1) - j] = matriz[i, j];
        }
    }
    return matriz;
}
void ExibeMatrizInversa(int[,] matriz)
{
    for (int i = 0; i < COLUNA; i++)
    {
        for (int j = 0; j < LINHA; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}
void ExibeMatriz(int[,] matriz)
{
    for (int i = 0; i < LINHA; i++)
    {
        for (int j = 0; j < COLUNA; j++)
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