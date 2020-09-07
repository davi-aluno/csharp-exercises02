using System;

namespace InsirirSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = new String[5] { "teste", "password", "esqueci", "acertou", "davi123" };
            bool altenticado = false;

            while (!altenticado)
            {
                Console.Write($"Insira o {vetor[1]}: ");
                String senha = Console.ReadLine();
                
                if (senha == vetor[4])
                {
                    Console.WriteLine($"[+] {vetor[3]}!\n" +
                        $"Acesso permitido");
                    altenticado = true;
                }
                else
                {
                    Console.WriteLine("Acesso negado");
                    altenticado = false;
                }
            }

            if (altenticado)
            {
                Console.WriteLine($"\nbem vindo ao nosso sistema, {vetor[0]}!");
            }
        }
    }
}
