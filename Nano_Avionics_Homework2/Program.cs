using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Avionics_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileContent = new WebClient().DownloadString("https://celestrak.com/NORAD/elements/active.txt");
            StringReader reader = new StringReader(fileContent);
            string line;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "M6P.txt")))
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("M6P"))
                {
                        outputFile.WriteLine(reader.ReadLine());
                        outputFile.WriteLine(reader.ReadLine());
                }
            }

        }
    }
}
