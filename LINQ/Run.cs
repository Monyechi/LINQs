using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Run
    {

       public Run()
        {
            Console.ReadLine();
        }


        public void Question1()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var th = words.Where(w => w.Contains("th"));
            var wordsWithTh = th.ToArray();

            for (int i = 0; i < wordsWithTh.Count(); i++)
            {
                Console.WriteLine(wordsWithTh[i]);

            }

        }
        public void Question2()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };



        }

       
    }

    
}
