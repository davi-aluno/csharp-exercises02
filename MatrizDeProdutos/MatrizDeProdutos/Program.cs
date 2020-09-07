using System;

namespace MatrizDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] produtos = new string[3, 3];

            produtos[0, 0] = "samsung";
            produtos[1, 0] = "xiomi";
            produtos[2, 0] = "motorola";
            produtos[0, 1] = "fone bluetooth";
            produtos[1, 1] = "mouse razer";
            produtos[2, 1] = "chromecast";
            produtos[0, 2] = "teclado";
            produtos[1, 2] = "patinete xiaomi";
            produtos[2, 2] = "lampada xiaomi";

            foreach (string prods in produtos)
            {
                Console.WriteLine(prods);
            }
        }
    }
}