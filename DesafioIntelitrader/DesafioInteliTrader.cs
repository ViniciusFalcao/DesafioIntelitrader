using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntelitrader
{
    public class DesafioInteliTrader
    {

        public string Desafio1(StringBuilder str )
        {   
            var msg=str.ToString().Trim();
            var txt = "abcdefghijklmnopq";
            var charA = txt.ToCharArray();

            var rep = txt.Length / 8;
            Console.WriteLine("repetições: " + rep);
            var index = 0;
            for (int i = 0; i < rep; i++)
            {
                if (i == 0)
                {
                    index += 7;

                    var a = charA[index];
                    var b = charA[index + 1];
                    charA[index] = b;
                    charA[index + 1] = a;
                    Console.WriteLine("mudou");
                    Console.WriteLine(charA);
                }
                else
                {

                    index += 8;
                    var a = charA[index];
                    var b = charA[index + 1];
                    charA[index] = b;
                    charA[index + 1] = a;
                    Console.WriteLine(charA);


                }


            }

            //tranformar array de char em string
            var txt2=txt;
            rep = 0;
            index = 0;

            rep = txt.Length / 4;
            for (int i = 0; i < rep; i++)
            {
                if (i==0)
                {
                    index += 4;

                    Console.WriteLine(txt2.Substring(0,index));

                }
                else
                {
                    var antes = index;
                    index += 4;
                    var depois=index;

                    var subs = txt2.Substring(antes,depois);
                    Console.WriteLine(subs);



                }
            }



            return "";
        }

    }
}
