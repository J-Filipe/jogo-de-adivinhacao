using System.Security.Cryptography;

/*
v1
    Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório 
    decidido pelo sistema.

    Input (Entrada de Dados)O usuário digita número inteiro
    Processamento
    O sistema compara o número digitado com um número inteiro aleatório
    Output (Saída de Dados)
    O sistema informará o usuário se o mesmo acertou ou não, podendo incluir 
    dicas sobre a proximidade do "chute"
*/
bool jogoDeveContinuar = true;
int numAleatorio = RandomNumberGenerator.GetInt32(1, 21);
Console.WriteLine("-------------------------");
Console.WriteLine("---Jogo de Adivinhação---");
Console.WriteLine("-------------------------");
Console.WriteLine();
while (jogoDeveContinuar == true)
{
    Console.Write("Informe um número ->");
    int numDig = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();

    if (numDig == numAleatorio)
    {
        System.Console.WriteLine("Parabéns, você acertou! O número era " + numAleatorio);
        jogoDeveContinuar = false;
    }
    else if (numDig > numAleatorio)
    {
        System.Console.WriteLine("O número digitado foi maior que o número secreto.");
    }
    else if (numDig < numAleatorio)
    {
        System.Console.WriteLine("O número digitado foi menor que o número secreto.");
    }

    System.Console.WriteLine();
    System.Console.Write("Deseja continuar? (s/n): ");
    string opcCont = Console.ReadLine().ToUpper();

    if (opcCont == "S")
    {
        jogoDeveContinuar = true;
    }
    else if (opcCont == "N")
    {
        jogoDeveContinuar = false;
    }


}