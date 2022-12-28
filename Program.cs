using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Calculadora Simples do hx";
            Console.WriteLine("Insira o seu nome abaixo:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Olá, {nome} seja muito bem-vindo(a) a calculadora!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Qual seu primeiro número selecionado?");
            decimal numero1 = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ótimo, {nome}! O Seu primeiro número é {numero1}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Qual será o seu segundo número?");
            decimal numero2 = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Otímo! Quase lá, o que você deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Multiplicação");
            Console.WriteLine("2. Adição");
            Console.WriteLine("3. Subtração");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.Clear();
                decimal resultado = numero1 * numero2;
                Console.WriteLine($"Seu resultado é: {resultado}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


            }
            if (escolha == 2)
            {
                Console.Clear();
                decimal resultado = numero1 + numero2;
                Console.WriteLine($"Seu resultado é: {resultado}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


            }
            if (escolha == 3)
            {
                Console.Clear();
                decimal resultado = numero1 - numero2;
                Console.WriteLine($"Seu resultado é: {resultado}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


            }


        }
    }
}