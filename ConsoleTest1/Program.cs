using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace ConsoleTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Program Files (x86)\swipl\boot32.prc";
            var pathToFile = @"C:\temp\cycki.pl";
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", path);  // or boot64.prc
            if (!PlEngine.IsInitialized)
            {
                String[] param = { "-q", "-f", pathToFile }; // suppressing informational and banner messages
                PlEngine.Initialize(param);
                
                PlQuery.PlCall("assert(father(martin, inka))");
                PlQuery.PlCall("assert(father(uwe, gloria))");
                PlQuery.PlCall("assert(father(uwe, melanie))");
                PlQuery.PlCall("assert(father(uwe, ayala))");
                using (var q = new PlQuery("father(P, C), atomic_list_concat([P,' is_father_of ',C], L)"))
                {
                    foreach (PlQueryVariables v in q.SolutionVariables)
                        Console.WriteLine(v["L"].ToString());

                    Console.WriteLine("all children from uwe:");
                    q.Variables["P"].Unify("uwe");
                    foreach (PlQueryVariables v in q.SolutionVariables)
                        Console.WriteLine(v["C"].ToString());
                }
                PlEngine.PlCleanup();
                Console.WriteLine("finshed!");
                Console.ReadLine();
            }
        }
    }
}
