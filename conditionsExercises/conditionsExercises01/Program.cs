using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace conditionsExercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            Compras[] compras = new Compras[6];
            compras[0] = new Compras("pizza", "R$ 1,05");
            compras[1] = new Compras("coxinha", "R$ 5,00");
            compras[2] = new Compras("arroz", "R$ 29,50");
            compras[3] = new Compras("cookies", "R$ 15,00");
            compras[4] = new Compras("maçãs", "R$ 15,00");
            compras[5] = new Compras("morango", "R$ 17,00");

            foreach (Compras compra in compras)
            {
                Console.WriteLine(
                    $"Nome do produto: {compra.Name}\n" +
                    $"Preço do produto: {compra.Preco}\n"   
                );
            }
            
            var precoTotal = compras
                                .Select(compra => compra.Preco.Replace(',', '.'))
                                .Select(preco => Regex.Replace(preco, @"[R$]", ""))
                                .Select(precoDouble => Convert.ToDouble(precoDouble))
                                .Sum();

            var frete = String.Empty;

            if (precoTotal / 100 >= 300)
            {
                frete = " (Frete gratuito)";
            }
            else
            {
                frete = " (Frete incluso de R$ 15,00)";
                precoTotal += 15.00;
            }

            Console.WriteLine("\n" + (precoTotal / 100).ToString("C", CultureInfo.CurrentCulture) + frete);
        }
    }
}