// See https://aka.ms/new-console-template for more information
using DesafioIntelitrader;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;





 var msg=new StringBuilder("10010110 11110111 01010110 00000001 " +
     "00010111 00100110 01010111 00000001 00010111 01110110 01010111" +
     " 00110110 11110111 11010111 01010111 00000011");
var desafio1 = new DesafioInteliTrader().Desafio1(msg);
Console.ReadLine();