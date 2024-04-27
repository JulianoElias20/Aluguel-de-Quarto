using System;
using VetorAluguel;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vect = new Aluguel[9];

            for(int i=1; i <=n; i++)
            {
                Console.WriteLine("Alguel #"+i);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o número do quarto (0 a 9)");
                int numero = int.Parse(Console.ReadLine());

                vect[numero] = new Aluguel(nome, email, numero);
                
            }

            for(int i=0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].ToString());
                }
            }
        }
    }
}