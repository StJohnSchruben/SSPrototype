using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAnalysisPrototype
{
    public class CompilationPrototype
    {
        private Compilation compilation;

        public CompilationPrototype(Task<Compilation> c)
        {
            this.compilation = c.Result;
        }

        public Compilation Compilation
        {
            get { return this.compilation; }
        }
    }
}
