using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractURL
{
    class ExtractFromURL
    {
        static void Main()
        {
            string url = @"http://www.devbg.org/forum/index.php ";
            Console.WriteLine("URL: {0}", url);

            FindInfo(url);
        }

        private static void FindInfo(string url)
        {
            int indexDots = 0;
            int indexSlashes = 0;
            int indexSlash = 0;

            for (int i = 0; i < url.Length - 2; i++)
            {
                if (url.Substring(i, 1) == ":")
                {
                    indexDots = i;
                }
                else if ((url.Substring(i, 2) == "//"))
                {
                    indexSlashes = i;
                    for (int k = i + 2; k < url.Length; k++)
                    {
                        if (url.Substring(k, 1) == "/")
                        {
                            indexSlash = k;
                            break;
                        }
                    }
                }
            }

            PrintResult(url, indexDots, indexSlash, indexSlashes);
        }

        private static void PrintResult(string url, int indexDots, int indexSlash, int indexSlashes)
        {
            int protokolLen = indexDots;
            int serverLen = indexSlash - indexSlashes;
            int resourceLen = url.Length - 1 - indexSlash;

            string protokolStr = url.Substring(0, protokolLen);
            string serverStr = url.Substring(indexSlashes + 1, serverLen);
            string resourceStr = url.Substring(indexSlash + 1, resourceLen);

            Console.WriteLine(@"[protokol] = ""{0}""", protokolStr);
            Console.WriteLine(@"[server] = ""{0}""", serverStr);
            Console.WriteLine(@"[resource] = ""{0}""", resourceStr);

        }
    }
}
