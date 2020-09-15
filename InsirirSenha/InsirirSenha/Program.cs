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
                
                status = vetor.Contains(senha) ? "Acesso permitido" : "Acesso negado";

                //foreach (string passwords in vetor)
                //{
                //    if (passwords == senha)
                //    {
                //        status = "Acesso permitido";
                //        break;
                //    }
                //    else
                //    {
                //        status = "Acesso negado";
                //    }
                //}
            
                Console.WriteLine(
                    status == "Acesso permitido"
                    ? $"{status}\nBem vindo ao sistema, {vetor[0]}"
                    : status
                );
            }
        }
    }
}
