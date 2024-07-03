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

        public string Desafio1(StringBuilder str )
        {   
            var msg=str.ToString().Trim();
            var txt = "abcdefghijklmnop";
            Console.WriteLine(txt.Length);
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
                    var b = charA[index - 1];
                    charA[index] = b;
                    charA[index - 1] = a;
                    //Console.WriteLine("mudou");
                    //Console.WriteLine(charA);
                }
                else
                {

                    index += 8;
                    var a = charA[index];
                    var b = charA[index - 1];
                    charA[index] = b;
                    charA[index - 1] = a;
                    //Console.WriteLine(charA);



                   

                }
                

            }
            var txt2=new String(charA);
            Console.WriteLine(txt2);
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
            var list2 = new List<string>();
            index = 0;
            for (int i = 0; i < list.Count/2; i++)
            {

                var prim=list.ElementAt(i);
                var seg= list.ElementAt(i+1);
                list2.Add(seg);
                list2.Add(prim);
                index += 2;

            }
            
            //list.ForEach((i) =>Console.WriteLine(i));


            return "";
        }

    }
}
