using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace ConsoleTest1
{
    public interface IPrologService
    {

        bool InitializePrologEngine();

        void AddPrologQuery(string query);

        IEnumerable<PlQueryVariables> GetPologSolutionVariableses(string query);
        
        void CleanPrologEngine();
    }
}
