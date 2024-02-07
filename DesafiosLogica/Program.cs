using DesafiosLogica.Exercicios;

int acao;

while (true)
{
    Console.WriteLine("0- SAIR");
    Console.WriteLine("1- Criptografia na rede do navio");
    Console.WriteLine("2- Menor distância de dois arrays");
    Console.WriteLine();

    Console.Write("Ação: ");

    acao = int.Parse(Console.ReadLine());

    switch (acao)
    {
        case 0: return;
        case 1: new CriptografiaNavio().Iniciar(); break;
        case 2: new MenorDistancia().Iniciar(); break;
    }

    Console.WriteLine();
}
