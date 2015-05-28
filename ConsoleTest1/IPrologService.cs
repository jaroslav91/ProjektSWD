using System.Collections.Generic;
using SbsSW.SwiPlCs;

namespace PrologService
{
    public interface IPrologService
    {

        bool InitializePrologEngine();

        void AddPrologQuery(string query);

        IEnumerable<PlQueryVariables> GetPologSolutionVariableses(string query);
        IEnumerable<PlTermV> GetPologSolution(string query);
        
        void CleanPrologEngine();
    }
}
