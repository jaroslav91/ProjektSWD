using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;

namespace ConsoleTest1
{
    public class PrologService : IPrologService
    {
        #region const

        string path = @"C:\Program Files (x86)\swipl";
        private string filename = "plik.txt";

        #endregion

        public PrologService()
        {
            BuildPrologFile();
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", path);  // or boot64.prc
            if (!InitializePrologEngine())
            {
                String[] param = { "-q", "-f", filename };
                PlEngine.Initialize(param);
            }

        }

        public bool IsInitialized { get; set; }


        public bool InitializePrologEngine()
        {
            return PlEngine.IsInitialized;
        }

        public void CleanPrologEngine()
        {
            PlEngine.PlCleanup();
        }

        public void AddPrologQuery(string query)
        {
            if (!InitializePrologEngine())
                return;
            try
            {
                PlQuery.PlCall(query);
            }
            catch (PlException ex)
            {
                Console.WriteLine(ex.MessagePl);
                Console.WriteLine(ex.Message);
                
            }
            

        }



        public void BuildPrologFile()
        {
            // Build a prolog source file 
            if (!File.Exists(filename))
            {
            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine("moze_leczyc(bol_glowy) :- ma(bol_glowy).");
            sw.WriteLine("moze_leczyc(bol_zeba) :- ma(bol_zeba).");
            sw.WriteLine("moze_leczyc(goraczka) :- ma(goraczka).");
            sw.WriteLine("moze_leczyc(bole_miesni) :- ma(bole_miesni).");
            sw.WriteLine("moze_leczyc(biegunka) :- ma(biegunka).");
            

            sw.Close();
        }
    }


        public IEnumerable<PlQueryVariables> GetPologSolutionVariableses(string query)
        {
            if (!InitializePrologEngine())
                return new List<PlQueryVariables>();
            try
            {
                using (PlQuery q = new PlQuery(query))
                {
                    return q.SolutionVariables;
                }
            }
            catch (PlException ex)
            {
                Console.WriteLine(ex.MessagePl);
                Console.WriteLine(ex.Message);
                return new List<PlQueryVariables>();
            }
            
        }
    }
}
