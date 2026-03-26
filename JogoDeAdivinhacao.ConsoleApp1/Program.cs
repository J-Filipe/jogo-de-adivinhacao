using System.Security.Cryptography;


bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{

    Console.Clear();
    Console.WriteLine("-------------------------");
    Console.WriteLine("---Jogo de Adivinhação---");
    Console.WriteLine("-------------------------");
    Console.WriteLine();
    System.Console.WriteLine("Escolha o nível de dificuldade:");
    Console.WriteLine("1- Fácil (10 tentativas)");
    Console.WriteLine("2- Médio (5 tentativas)");
    Console.WriteLine("3- Difício (3 tentativas)");
    Console.WriteLine("-------------------------");
    System.Console.Write("Digite sua escolha -> ");
    string dificuldadeEscolhida = Console.ReadLine();
    int numAleatorio;
    int tentativasMaximas;

    switch (dificuldadeEscolhida)
    {
        case "1":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break;

        case "2":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;
        case "3":
            numAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;
        default:
            Console.WriteLine("-------------------------");
            Console.WriteLine("Digite uma opção vávilda.");
            Console.Write("Aperte ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int pontuacao = 1000;

    int[] nrsDig = new int[tentativasMaximas];
    int contNrsDig = 0;

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("---Jogo de Adivinhação---");
        Console.WriteLine("-------------------------");
        System.Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("-------------------------");

        Console.Write("Informe um número ->");
        int numDig = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();

        bool numRep = false;

        for (int i = 0; i < nrsDig.Length; i++)
        {
            if (nrsDig[i] == numDig)
            {
                numRep = true;
                break;
            }
        }

        if (numRep == true)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Você já digitou esse número tente novamnete. ");
            Console.WriteLine("-------------------------");

            Console.Write("Aperte ENTER para continuar...");
            Console.ReadLine();
            tentativaAtual--;
            continue;
        }
        if (contNrsDig < nrsDig.Length)
        {
            nrsDig[contNrsDig] = numDig;
            contNrsDig++;
        }
        else
        {
            nrsDig = new int[tentativasMaximas];
            contNrsDig = 0;

            nrsDig[contNrsDig] = numDig;
            contNrsDig++;
        }

        if (numDig == numAleatorio)
        {
            System.Console.WriteLine("Parabéns, você acertou! O número era " + numAleatorio);
            break;
        }
        else if (numDig > numAleatorio)
        {
            System.Console.WriteLine("O número digitado foi maior que o número secreto.");
        }
        else if (numDig < numAleatorio)
        {
            System.Console.WriteLine("O número digitado foi menor que o número secreto.");
        }

        int difNumerica = Math.Abs(numAleatorio - numDig);

        if (difNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (difNumerica <= 9 && difNumerica >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("Sua potuação é -> " + pontuacao);
        Console.WriteLine("-------------------------");
        Console.Write("Aperte ENTER para continuar...");
        Console.ReadLine();
    }
    System.Console.WriteLine();
    System.Console.Write("Deseja continuar? (s/n): ");
    string opcCont = Console.ReadLine();

    if (opcCont != "S" && opcCont != "s")
    {
        jogoDeveContinuar = false;
    }

}