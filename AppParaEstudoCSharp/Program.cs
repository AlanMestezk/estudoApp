

using System;

namespace EstudoHehe {

    class Program {
        static void Main(string[] args) {

            Estudohihi dados = new Estudohihi();

            Console.Write("Digite um usuário com mais de 4 dígitos: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Digite a sua idade (+18): ");
            dados.Idade = (int.Parse(Console.ReadLine()));
            Console.Write("Digite sua altura: ");
            dados.Altura = double.Parse(Console.ReadLine());
            Console.Write("Digite sua cor favorita: ");
            dados.CorFavorita = Console.ReadLine();

        }
    }

}