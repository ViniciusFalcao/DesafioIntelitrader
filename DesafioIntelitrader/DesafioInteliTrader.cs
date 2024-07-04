using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DesafioIntelitrader
{
    public class DesafioInteliTrader
    {
        public string BitsToAscii(string bits)
        {
            StringBuilder result = new StringBuilder();

            // Iterar pela string de bits em incrementos de 8
            for (int i = 0; i < bits.Length; i += 8)
            {
                string eightBits = bits.Substring(i, 8); // Pegar o próximo grupo de 8 bits

                // Converter os 8 bits para um número inteiro
                int decimalValue = Convert.ToInt32(eightBits, 2);

                // Converter o número inteiro para o caractere ASCII correspondente
                char asciiChar = Convert.ToChar(decimalValue);

                // Adicionar o caractere ASCII ao resultado
                result.Append(asciiChar);
            }

            return result.ToString();
        }
        
        public string Desafio1(string str )
        {
            var index = 0;
            var txt=str.Replace(" ","");
            //var txt = "abcdefghijklmnop";
            Console.WriteLine(txt.Length);
            var charA = txt.ToCharArray();
            //subistituindo ultimo e penultimo
            var rep = txt.Length / 8;
            Console.WriteLine("repetições: " + rep);
            
            for (int i = 0; i < rep; i++)
            {
                if (i == 0)
                {
                    index += 7;
                    
                    var a = charA[index];
                    if (a.Equals('0'))
                    {
                        a = '1';
                    }
                    else
                    {
                        a = '0';
                    }
                    var b = charA[index - 1];

                    if (b.Equals('0'))
                    {
                        b = '1';
                    }
                    else
                    {
                        b = '0';
                    }

                    charA[index] = a;
                    charA[index - 1] = b;
                    //Console.WriteLine("mudou");
                    //Console.WriteLine(charA);
                }
                else
                {

                    index += 8;
                    var a = charA[index];
                    if (a.Equals('0'))
                    {
                        a = '1';
                    }
                    else
                    {
                        a = '0';
                    }
                    var b = charA[index - 1];

                    if (b.Equals('0'))
                    {
                        b = '1';
                    }
                    else
                    {
                        b = '0';
                    }

                    charA[index] = a;
                    charA[index - 1] = b;
                    //Console.WriteLine(charA);





                }
                

            }

            //separando as string em 4 bits
            var txt2=new String(charA);
            //Console.WriteLine(txt2);
            rep = 0;
            index = 0;

            rep = txt2.Length / 4;

            List<string> list = new List<string>();
            for (int i = 0; i < rep; i++)
            {
                if (i==0)
                {
                    index += 4;
                    list.Add(txt2.Substring(0, index));

                   

                }
                else
                {
                    var antes = index;
                    index += 4;

                    var subs = txt2.Substring(antes,4);
                    list.Add(subs);
                   // Console.WriteLine(subs);



                }
            }

            //trocando 4 bits pelos proximos
            var list2 = new List<string>();
            index = 0;
            for (int i = 0; i < list.Count/2; i++)
            {

                var prim=list.ElementAt(index);
                var seg= list.ElementAt(index+1);
                list2.Add(seg);
                list2.Add(prim);
                index += 2;

            }
            //criando string bin
            String bin ="";
            
            list2.ForEach((i) =>bin+=i);
            //Console.WriteLine(bin=="efhgabcdmnpoijkl");
            //------------------------
            Console.WriteLine(BitsToAscii(bin));
            Console.WriteLine(BitsToAscii(txt));


            //var data = GetBytesFromBinaryString(bin);
            //var text = Encoding.ASCII.GetString(data);
            //Console.WriteLine(text);
            return bin;
        }

    }
}
