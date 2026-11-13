// 1- Desenvolva um programa que preencha uma matriz quadrada que será informada pelo usuário. Mostre os cálculos somando os valores de cada linha, cada coluna, da diagonal principal e a diagonal inversa

void PreencheMatriz(int[,] matriz, int tamanho)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = Random.Shared.Next(10, 99);
        }
    }
}

void ExibeMatriz(int tamanho, int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}

void SomaLinhas(int tamanho, int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        int soma = 0;
        string calculo = "";

        for (int j = 0; j < tamanho; j++)
        {
            soma += matriz[i, j];
            calculo += matriz[i, j];
            if (j < tamanho - 1)
            {
                calculo += " + ";
            }
        }

        Console.WriteLine($"Linha {i}: {calculo} = {soma}");
    }
}

void SomaColunas(int tamanho, int[,] matriz)
{
    for (int j = 0; j < tamanho; j++)
    {
        int soma = 0;
        string calculo = "";

        for (int i = 0; i < tamanho; i++)
        {
            soma += matriz[i, j];
            calculo += matriz[i, j];
            if (i < tamanho - 1)
            {
                calculo += " + ";
            }
        }

        Console.WriteLine($"Coluna {j}: {calculo} = {soma}");
    }
}

void SomaDiagonalPrincipal(int tamanho, int[,] matriz)
{
    int soma = 0;
    string calculo = "";

    for (int i = 0; i < tamanho; i++)
    {
        soma += matriz[i, i];
        calculo += matriz[i, i];
        if (i < tamanho - 1)
        {
            calculo += " + ";
        }
    }

    Console.WriteLine($"Diagonal principal: {calculo} = {soma}");
}

void SomaDiagonalInversa(int tamanho, int[,] matriz)
{
    int soma = 0;
    string calculo = "";

    for (int i = 0; i < tamanho; i++)
    {
        int j = tamanho - 1 - i;
        soma += matriz[i, j];
        calculo += matriz[i, j];
        if (i < tamanho - 1)
        {
            calculo += " + ";
        }
    }

    Console.WriteLine($"Diagonal inversa: {calculo} = {soma}");
}

int tamanho;

Console.WriteLine("Digite o tamanho da matriz quadrada");
tamanho = int.Parse(Console.ReadLine());

int[,] matriz = new int[tamanho, tamanho];

PreencheMatriz(matriz, tamanho);

Console.WriteLine("-------------------------");
ExibeMatriz(tamanho, matriz);
Console.WriteLine("-------------------------");
SomaLinhas(tamanho, matriz);
Console.WriteLine("-------------------------");
SomaColunas(tamanho, matriz);
Console.WriteLine("-------------------------");
SomaDiagonalPrincipal(tamanho, matriz);
SomaDiagonalInversa(tamanho, matriz);