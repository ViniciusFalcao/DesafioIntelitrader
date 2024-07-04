// See https://aka.ms/new-console-template for more information
using DesafioIntelitrader;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
Console.WriteLine("Bem vindo a Resolução de Desafio");

Console.WriteLine("Escolha um desafio\n");
Console.WriteLine("1 - Desafio do navio ");
Console.WriteLine("2 - Desafio da venda de livros ");
var key=Console.ReadKey();
Console.Clear();
if (key.Key==ConsoleKey.D1 || key.Key==ConsoleKey.NumPad1)
{
    var msg= "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
    Console.WriteLine("Resolvendo criptografia...");
    Thread.Sleep(2000);

    var desafio1 = new CriptografiaNavio().Main(msg);

}
else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
{
    new LivroDeOfertas().Main();
}







Console.ReadLine();