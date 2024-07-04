using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntelitrader

// sistema de livro de ofertas de vendas e compras


//o cliente vai entrar no sistema digitar quantas requisições ele quer fazer

//cada repetição o sistema vai oferecer 4  inputs (posição,ação,quantidade,valores)


//inserir algo no registro vai mudar todo o registro existente
//não pode inserir valores com parametros vazios

//modificar o registro so vai alterar as propriedades com valores diferentes de 0 


//deletar o resgistro faz com que os proximos registros desçam de posição

//deletar so precisa da posicao 
{
    internal class Livro
    {
        public int _quantidade{get;set;}

        public int _valor { get; set; }

    }

    internal class Notificacao
    {
        public int _posicao { get; set; }

        public int _acao { get; set; }

        public int _quantidade { get; set; }

        public int _valor { get; set; }


        public Notificacao(int pos,int acao,double valor,int quantidade) {
            _posicao = pos;
            _acao = acao;
            _quantidade = quantidade;
            _valor = valor; 
        
        }
    }
    internal class LivroDeOfertas
    {
        private List<Livro> _listaLivros { get; set; }

        public LivroDeOfertas() {
            _listaLivros = new List<Livro>();
        }

        public int getNotificacoes(){

            Console.WriteLine("Digite o número de registros que deseja fazer :");
            var notificacoes=Console.ReadLine();
            return Convert.ToInt32(notificacoes);
        }

        public void iniciarNotificacoes()
        {
            var repeticoes = getNotificacoes();
            var lista_not=new List<Notificacao>();
            
            for (int i = 0; i < repeticoes; i++)
            {


                Console.WriteLine("Digite a posição do produto na lista:");
                var pos=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o tipo de ação : \n" +
                    "(0 - INSERIR 1 - MODIFICAR 2 - DELETAR )");
                var acao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite os valores  do livro : ");
                var valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de livros :");
                var quantidade = Convert.ToInt32(Console.ReadLine());


                var notificacao=new Notificacao(pos,acao,valor,quantidade);  




            }


        }
        public  void Main()
        {

            Console.WriteLine("Olá, bem vindo ao InteliBooks.");

            Thread.Sleep(2000);
            Console.Clear();
            
            Console.WriteLine("1 - Ver Ofertas de livros ");

            Console.WriteLine("2 - Notificar atualizações ");

            var keyinfo=Console.ReadKey();
            Console.Clear();


            if (keyinfo.Key==ConsoleKey.NumPad2|| keyinfo.Key==ConsoleKey.D2)
            {
                iniciarNotificacoes();
            }else if (keyinfo.Key==ConsoleKey.D1 || keyinfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("vou implementar ");
            }
            else
            {
                Console.WriteLine("ERRO: (Digite um a tecla 1 ou 2)");
            }





        }
    }


    
}
