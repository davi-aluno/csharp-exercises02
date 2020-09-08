using System;

namespace InsirirSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[5] { "teste", "password", "esqueci", "acertou", "davi123" };
            string status = String.Empty;

            while (status != "Acesso permitido")
            {
                Console.Write($"Insira o {vetor[1]}: ");
                string senha = Console.ReadLine();

                status = senha == vetor[4] ? "Acesso permitido" : "Acesso negado";

                //status = senha == vetor[4]
                //      || senha == vetor[3]
                //      || senha == vetor[2]
                //      || senha == vetor[1]
                //      || senha == vetor[0]
                //         ? "Acesso permitido"
                //         : "Acesso negado";

                Console.WriteLine(
                    status == "Acesso permitido"
                    ? $"{status}\nBem vindo ao sistema, {vetor[0]}"
                    : status
                );
            }
        }
    }
}
