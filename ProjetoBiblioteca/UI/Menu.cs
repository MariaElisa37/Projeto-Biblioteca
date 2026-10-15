using System;
using System.Collections.Generic;
using ProjetoBiblioteca.Negocios;
using ProjetoBiblioteca.Models;
using System.Reflection.Metadata;
using System.Collections;
namespace ProjetoBiblioteca.UI
{
    public class MenuConsole
    {
        private LivroServico _livroServico = new LivroServico();
        public void ExibirMenu()
        {
            bool rodando = true;
            while (rodando)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE BIBLIOTECA ESCOLAR");
                Console.WriteLine("1- Cadastrar Novo Livro");
                Console.WriteLine("2- Listar coleção");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Escolha uma opção:");

                string opcao = Console.ReadLine();
                switch(opcao){
                    case "1": 
                      ExecutarCadastro();
                      break;
                    case "2":
                      ExecutarListagem();
                      break;
                    case "0":
                      rodando = false;
                      Console.WriteLine("Encerrando o sistema...");
                      break;
                default:
            Console.WriteLine ("Opção invalida! Precione qualquer tecla para continuar.");
            Console.ReadKey();
                      break;

                }
            }
        }
    private void ExecutarCadastro()
        {
            Console.Clear();
            Console.WriteLine("--Cadastro de livro--");
            Console.Write("Titulo do livro");
            string titulo = Console.ReadLine();
            Console.Write("Autor do livro");
            string autor = Console.ReadLine();

    //chama a canada de negocio
        bool sucesso = _livroServico.CadastrarLivro(titulo, autor, out string mensagem);
        if (sucesso)
            {
                Console.WriteLine("Livro cadastrado com sucesso!");
            }



        }
    }
}
