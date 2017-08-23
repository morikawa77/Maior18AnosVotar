using System;

namespace Maior18AnosVotar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int idade;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
			Console.Write("Digite sua idade: ");
			idade = Convert.ToInt32(Console.ReadLine());
			if (idade < 18)
			{
                Console.Write("{0}, você é menor de 18 anos.", nome);
            } else {
                Console.Write("{0}, você é maior de 18 anos, já pode dirigir e é obrigado a votar.", nome);
            }
			Console.ReadLine();
        }
    }
}
