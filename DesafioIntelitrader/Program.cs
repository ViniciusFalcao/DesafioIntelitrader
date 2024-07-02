// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

Console.WriteLine("Hello, World!");
 var msg=new StringBuilder("10010110 11110111 01010110 00000001 " +
     "00010111 00100110 01010111 00000001 00010111 01110110 01010111" +
     " 00110110 11110111 11010111 01010111 00000011").ToString().Trim();

var txt = "abcdefghijklmnopq";
var charA=txt.ToCharArray();

var num=(txt.Length/4)+1;
Console.WriteLine("repetições: "+num);
var num2 = 0;
for (int i = 0; i < num; i++)
{
   Console.WriteLine(txt[num2]);
    if (i == 0)
    {
        num2 += 3;

        var a = charA[num2 ];
        var b =charA[num2 + 1];
        charA[num2] = charA[num2 + 1];
    }
    else
    {
        num2 += 4;

        var a = charA[num2];
        var b = charA[num2 + 1];
        charA[num2] = charA[num2 + 1];
    }


}


Console.ReadLine();