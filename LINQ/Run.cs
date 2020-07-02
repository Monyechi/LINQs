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

            var namelist = names.Distinct().ToList();

            for (int i = 0; i < namelist.Count(); i++)
            {
                Console.WriteLine(namelist[i]);
            }
        }
        public void Question3()
        {
            List<string> classGrades = new List<string>()
            {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
            };

            //var grade1 = classGrades[];

        }
        public static void Question4()
        {
            var text = "Terrill";

            var dict = new Dictionary<char, int>();

            foreach (var c in text)
                if (dict.ContainsKey(c))
                    dict[c]++;
            


        }

       
    }

    
}
