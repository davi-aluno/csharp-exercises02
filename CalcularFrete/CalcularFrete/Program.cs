using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalcularFrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Compras[] compras = new Compras[6];

            compras[0] = new Compras("mesa", "casa", "R$ 1,05");
            compras[1] = new Compras("tv samsung", "eletronico", "R$ 5,00");
            compras[2] = new Compras("cortina", "casa", "R$ 29,50");
            compras[3] = new Compras("celular", "eletronico", "R$ 15,00");
            compras[4] = new Compras("shampoo", "cuidados e beleza", "R$ 15,00");
            compras[5] = new Compras("iMac", "eletronico", "R$ 17,00");

            foreach (Compras compra in compras)
            {
                Console.WriteLine(
                    $"Nome do produto: {compra.nome}\n" +
                    $"Tipo do produto: {compra.tipo}\n" +
                    $"Preço do produto: {compra.preco}\n"
                );
            }

            Console.Write("\nInforme o tipo dos produtos: ");
            string tipoDoProduto = Console.ReadLine();

            var precoTotal = compras
                    .Where(compra => compra.tipo == tipoDoProduto)
                    .Select(compra => compra.preco.Replace(',', '.'))
                    .Select(preco => Regex.Replace(preco, @"[R$]", ""))
                    .Select(precoDobule => Convert.ToDouble(precoDobule))
                    .Sum();

            var frete = String.Empty;

            switch (tipoDoProduto)
            {
                case "casa":
                    precoTotal += 15.00 * 100;
                    frete = "15.00";
                    break;
                case "eletronico":
                    precoTotal += 20.00 * 100;
                    frete = "20.00";
                    break;
                case "cuidados e beleza":
                    precoTotal += 10.00 * 100;
                    frete = "10.00";
                    break;
                default:
                    Console.WriteLine("[!] Opção invalida\n");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"\nPreço total: {(precoTotal / 100).ToString("C", CultureInfo.CurrentCulture)}\n" +
                $"Tipo dos produtos: {tipoDoProduto}\n" +
                $"Frete dos produtos: {frete}");
        }
    }
}