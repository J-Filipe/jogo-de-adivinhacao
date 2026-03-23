using System.Security.Cryptography;

/*
v1
    Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório 
    decidido pelo sistema.

    Input (Entrada de Dados)O usuário digita número inteiro
    Processamento
    O sistema compara o número digitado com um número inteiro aleatório
    Output (Saída de Dados)
    O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/

Console.WriteLine("-------------------------");
Console.WriteLine("---Jogo de Adivinhação---");
Console.WriteLine("-------------------------");
Console.WriteLine();

Console.Write("Informe m número ->");
string strNumDig = Console.ReadLine();

int numAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("O número digitado é " + numAleatorio);
