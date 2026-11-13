// 2- Faça um programa que gere o boletim escolar de um aluno. Critérios: as linhas são as matérias, as colunas são as notas de cada bimestre + a media e a situação do aluno em cada matéria
void PreencheNotas(string[] materias, double[,] notas, int bimestres)
{
    for (int i = 0; i < materias.Length; i++)
    {
        Console.WriteLine($"Digite o nome da matéria {i + 1}");
        materias[i] = Console.ReadLine();

        for (int j = 0; j < bimestres; j++)
        {
            Console.WriteLine($"Digite a nota do {j + 1}º bimestre de {materias[i]}");
            notas[i, j] = Random.Shared.Next(1,10);
        }
    }
}
void CalculaMedias(double[,] notas, int qtdMaterias, int bimestres)
{
    for (int i = 0; i < qtdMaterias; i++)
    {
        double soma = 0;

        for (int j = 0; j < bimestres; j++)
        {
            soma += notas[i, j];
        }

        notas[i, bimestres] = soma / bimestres;
    }
}
string DefineSituacao(double media)
{
    if (media >= 6)
    {
        return "Aprovado";
    }

    if (media >= 4)
    {
        return "Recuperação";
    }

    return "Reprovado";
}
void ExibeBoletim(string aluno, string[] materias, double[,] notas, int bimestres)
{
    Console.WriteLine($"===== BOLETIM ESCOLAR - {aluno} =====");
    Console.Write("Matéria");

    for (int j = 0; j < bimestres; j++)
    {
        Console.Write($"{j + 1}º Bim");
    }

    Console.WriteLine("Média" + "Situação");

    for (int i = 0; i < materias.Length; i++)
    {
        Console.Write(materias[i]);

        for (int j = 0; j <= bimestres; j++)
        {
            Console.Write($"{notas[i, j]:F1}");
        }

        Console.WriteLine(DefineSituacao(notas[i, bimestres]));
    }
}

string aluno;
int qtdMaterias;
int bimestres = 4;

Console.WriteLine("Digite o nome do aluno");
aluno = Console.ReadLine();

Console.WriteLine("Digite a quantidade de matérias");
qtdMaterias = int.Parse(Console.ReadLine());

string[] materias = new string[qtdMaterias];
double[,] notas = new double[qtdMaterias, bimestres + 1];

PreencheNotas(materias, notas, bimestres);
CalculaMedias(notas, qtdMaterias, bimestres);

Console.WriteLine("-------------------------");
ExibeBoletim(aluno, materias, notas, bimestres);