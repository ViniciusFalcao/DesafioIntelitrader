using System;
using System.Collections.Generic;
using System.Globalization;
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
        public double _valor { get; set; }

        public int _quantidade{get;set;}

        public Livro(double valor,int quantidade) {

            _valor = valor;
            _quantidade = quantidade;

        }  

      
    }

    internal class Notificacao
    {
        public int _posicao { get; set; }

        public int _acao { get; set; }
        public double _valor { get; set; }


        public int _quantidade { get; set; }

       

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
            Console.Clear();    
            return Convert.ToInt32(notificacoes);
        }

        public void iniciarNotificacoes()
        {
            var repeticoes = getNotificacoes();
            var lista_not=new List<Notificacao>();
            
            for (int i = 0; i < repeticoes; i++)
            {


                Console.WriteLine("Digite a posição do produto na lista:");
                var pos = Convert.ToInt32(Console.ReadLine());
                pos -= 1;
                Console.WriteLine("Digite o tipo de ação : \n" +
                    "(0 - INSERIR 1 - MODIFICAR 2 - DELETAR )");
                var acao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite os valores  do livro : ");
                var valor = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.WriteLine("Digite a quantidade de livros :");
                var quantidade = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                var notificacao=new Notificacao(pos,acao,valor,quantidade);
                lista_not.Add(notificacao);
            }

            

            for (int i = 0; i < repeticoes; i++)
            {
                var not = lista_not.ElementAt(i);


                switch (not._acao)
                {
                    case 0:
                        
                        try
                        {
                            //Console.WriteLine("value:" + not._valor);

                            var novol = new Livro(not._valor, not._quantidade);

                            _listaLivros[not._posicao] =novol;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            _listaLivros.Add(new Livro(not._valor, not._quantidade));
                        }
                        break;
                    case 1:
                        var registrolivro = _listaLivros.ElementAtOrDefault(not._posicao);

                        if (registrolivro != null)
                        {

                            if (not._valor!=0)
                            {
                                registrolivro._valor = not._valor;
                            }
                            if (not._quantidade != 0)
                            {
                                registrolivro._quantidade = not._quantidade;
                            }
                            _listaLivros[not._posicao] = registrolivro;
                        }

                        break;
                    case 2:
                        

                        try
                        {
                            _listaLivros.RemoveAt(not._posicao);

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("não existe esse registro para deletar");
                        }
                        break;

                    default:
                        break;
                }
            }
            //Console.WriteLine("Range" + _listaLivros.Count);
            var index = 0;
            _listaLivros.ForEach((i) => {
                var n = index + 1;
                Console.Write("{Posição:"+n+" , ");
                Console.Write("Valor:" + i._valor.ToString("F2").Replace(",",".")+" , ");
                Console.Write("Quantidade:" + i._quantidade+"}\n");
                index++;


            });
          


        }
        public  void Main()
        {

            Console.WriteLine("Olá, bem vindo ao InteliBooks.");

            Thread.Sleep(2000);
            Console.Clear();
            

            Console.WriteLine("1 - Notificar atualizações ");

            var keyinfo=Console.ReadKey();
            Console.Clear();


            if (keyinfo.Key==ConsoleKey.NumPad1|| keyinfo.Key==ConsoleKey.D1)
            {
                iniciarNotificacoes();
            }





        }
    }


    
}
