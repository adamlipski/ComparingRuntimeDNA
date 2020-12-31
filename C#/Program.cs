using System;
using System.Text;

namespace ComparingSolutionsDNA
{
    /*
    Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7
    Articel by Naser Tamimi
    */
    class Program
    {
        public static char convert(char c)
        {
            if (c == 'A') return 'C';
            if (c == 'C') return 'G';
            if (c == 'G') return 'T';
            if (c == 'T') return 'A';
            return ' ';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7");
            Console.WriteLine("Articel by Naser Tamimi");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Start");
            string opt = "ACGT";
            string s = "";

            string s_last = "";
            int len_str = 14;
            bool change_next;
            
            for (int i = 0; i < len_str; i++)
                s += opt[0];

            for (int i = 0; i < len_str; i++)
                s_last += opt[opt.Length - 1];

            //int pos = 0;
            int counter = 1;
            StringBuilder sb = new StringBuilder(s);
            while (s != s_last)
            {
                counter++;
                // You can uncomment the next line to see all k-mers.
                //Console.WriteLine($"{s}"); ;
                change_next = true;
                for (int i = 0; i < len_str; i++)
                {
                    if (change_next)
                    {
                        if (s[i] == opt[opt.Length - 1])
                        {

                            sb[i] = convert(s[i]);
                            s = sb.ToString();
                            change_next = true;
                        }
                        else
                        {
                            sb[i] = convert(s[i]);
                            s = sb.ToString();
                            break;
                        }
                    }
                }
            }

            // You can uncomment the next line to see all k-mers.
            //Console.WriteLine($"{s}"); ;

            watch.Stop();
            var elapsedMs = (double)watch.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Time elapsed: {elapsedMs.ToString()} seconds");
            Console.WriteLine($"Number of generated k-mers: {counter}");

            Console.WriteLine("Finish");

            Console.ReadKey();

        }
    }
}
