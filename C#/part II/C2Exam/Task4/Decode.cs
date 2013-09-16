using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Decode
    {


        private static int CheckBeat(List<string> per, int found)
        {
            //get every permutation word
            for (int i = 0; i < per.Count; i++)
            {
                //read every char in every word
                int len = 0;
                for (int c = 0; c < per[i].Length - 1; c++)
                {
                    string word = per[i];

                    if (word[c] != word[c + 1])
                    {
                        len++;
                    }

                    //if all chars are not 2 consecutive equal chars
                    if (len == word.Length - 1)
                    {
                        found++;
                    }

                }
            }

            return found;
        }




        static void Main(string[] args)
        {
            string list = "xxxy";
            //var list = new List<char> { 'x','x','x','y'};
            var result = GetPermutations(list, list.Length);
            StringBuilder st = new StringBuilder();
            
            foreach (var perm in result)
            {
                foreach (var c in perm)
                {
                    st.Append(c);
                   //Console.Write(c + " ");
                }
                st.Append(" ");
                Console.WriteLine();
            }

           Console.WriteLine(st);
           string stt = st.ToString();
           string[] nst = stt.Split(' ');
           var slist = nst.ToList();



           int found = 0;
           found = CheckBeat(slist, found);
           Console.WriteLine(found);
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }
    }
}
