using System;
using System.Collections.Generic;

namespace MeuPrograma
{
    class Program
    {
        static List<Funcionario> funcionarios = new List<Funcionario>();

        static void Main(string[] args)
        {
            bool Executar = true;

            Console.WriteLine("Sistema de cadastro de funcionarios!!");

            while (Executar)
            {
                Console.WriteLine("\nMenu de opções:");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção (0-4): ");

                string entrada = Console.ReadLine();
                int menu_opcao;

                if (!int.TryParse(entrada, out menu_opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                if (menu_opcao == 1)
                {
                    Cadastrar_Funcionarios();
                }
                else if (menu_opcao == 2)
                {
                    Atualizar_Funcionarios();
                }
                else if (menu_opcao == 3)
                {
                    Listar_Funcionarios();
                }
                else if (menu_opcao == 4)
                {
                    Deletar_Funcionarios();
                }
                else if (menu_opcao == 0)
                {
                    Executar = false;
                }
                else
                {
                    Console.WriteLine("Opção não reconhecida.");
                }
            }
        }

        public static void Cadastrar_Funcionarios()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("Digite o RH: ");
            funcionario.RH = Console.ReadLine();

            Console.Write("Digite o e-mail: ");
            funcionario.Email = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("Digite a data de admissão (dd/mm/aaaa): ");
            funcionario.Data_Admissao = DateTime.Parse(Console.ReadLine());

            funcionarios.Add(funcionario);
            Console.WriteLine("\nFuncionário cadastrado com sucesso!");
        }

        public static void Atualizar_Funcionarios()
        {
            Listar_Funcionarios();
            Console.Write("Digite o número do funcionário que deseja atualizar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice < 0 || indice >= funcionarios.Count)
            {
                Console.WriteLine("Funcionário não encontrado.");
                return;
            }

            Funcionario funcionario = funcionarios[indice];

            Console.Write("Novo nome (deixe vazio para manter): ");
            string nome = Console.ReadLine();
            if (!string.IsNullOrEmpty(nome)) funcionario.Nome = nome;

            Console.Write("Novo CPF: ");
            string cpf = Console.ReadLine();
            if (!string.IsNullOrEmpty(cpf)) funcionario.CPF = cpf;

            Console.Write("Novo RH: ");
            string rh = Console.ReadLine();
            if (!string.IsNullOrEmpty(rh)) funcionario.RH = rh;

            Console.Write("Novo Email: ");
            string email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email)) funcionario.Email = email;

            Console.Write("Novo Telefone: ");
            string telefone = Console.ReadLine();
            if (!string.IsNullOrEmpty(telefone)) funcionario.Telefone = telefone;

            Console.Write("Nova Data de admissão (deixe vazio para manter): ");
            string data = Console.ReadLine();
            if (!string.IsNullOrEmpty(data)) funcionario.Data_Admissao = DateTime.Parse(data);

            Console.WriteLine("Funcionário atualizado com sucesso!");
        }

        public static void Listar_Funcionarios()
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de Funcionários:");
            for (int i = 0; i < funcionarios.Count; i++)
            {
                var f = funcionarios[i];
                Console.WriteLine($"{i + 1}. {f.Nome} | CPF: {f.CPF} | RH: {f.RH} | Email: {f.Email} | Telefone: {f.Telefone} | Admissão: {f.Data_Admissao.ToShortDateString()}");
            }
        }

        public static void Deletar_Funcionarios()
        {
            Listar_Funcionarios();
            Console.Write("Digite o número do funcionário que deseja deletar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice < 0 || indice >= funcionarios.Count)
            {
                Console.WriteLine("Funcionário não encontrado.");
                return;
            }

            funcionarios.RemoveAt(indice);
            Console.WriteLine("Funcionário removido com sucesso!");
        }

        class Funcionario
        {
            public string Nome;
            public string CPF;
            public string RH;
            public string Email;
            public string Telefone;
            public DateTime Data_Admissao;
        }
    }
}