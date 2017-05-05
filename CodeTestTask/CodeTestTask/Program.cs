using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

        }



        static void Test()
        {
            string[] questions = { "Qonsu olmayan olke?", "Azerbaycanin sahesi?", "Sahesine gore en boyuk olke", "En boyuk yarimada", "Hem ehalisine, hem de erazisine gore 4-cu olke" };
            string[] answers = { "Turkiye", "Iraq", "Iran", "Qazaxistan", "86.6", "90", "82.6", "80.1","ABŞ","Kanada","Çin","Rusiya","Seudiyye Erebistan",
                "Hindistan", "Malayzia", "Indoneziya","ABŞ","Argentina","Braziliya","Kanada"};
            int[] a = new int[4];

            Random rand = new Random();
            int l = 0, m = 0, point = 0; string h = null, n = null,y=null; string[] p = new string[4];
            
            List<int> randomAnswers = new List<int>();




            for (int i = 0; i < 20; i++)
            {
                if (i % 4 == 0)
                {
                    for (int j = i; j < i + 4; j++)
                    {
                        l = rand.Next(i, i + 4);
                        if (i == 0 && j == 0)
                        {
                            randomAnswers.Add(l);
                        }

                        else
                        {
                            while (randomAnswers.Contains(l))
                            {
                                l = rand.Next(i, i + 4);
                                if (!randomAnswers.Contains(l))
                                {
                                    break;
                                }
                            }

                            randomAnswers.Add(l);
                        }
                    }
                }
            }

            

            for (int i = 0; i < questions.Length; i++)
            {
                m = 0; y = null;
                Console.WriteLine(questions[i]);
                for (int j = i * 4; j < i * 4 + 4; j++)
                {
                    p[m] = (char)(m + 97) + ") " + answers[randomAnswers[j]];
                    Console.WriteLine(p[m]);

                    m++;

                }
                switch (i)
                {
                    case 0: h = answers[1]; break;
                    case 1: h = answers[4]; break;
                    case 2: h = answers[11]; break;
                    case 3: h = answers[12]; break;
                    case 4: h = answers[18]; break;
                }

                Console.Write("Variantı daxil edin: ");
                n = Console.ReadLine();


                for (int j = 0; j < 4; j++)
                {

                    if (p[j][0].ToString() == n)
                    {

                        for (int z = 3; z < p[j].Length; z++)
                        {
                            y += p[j][z].ToString();

                        }

                    }
                }

                if (y == h)
                {
                    point += 10;
                }

            }

            Console.WriteLine("Point: "+point);


        }
    }
}
