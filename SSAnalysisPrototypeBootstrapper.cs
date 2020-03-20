using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Threading;

namespace SSAnalysisPrototype
{
    public class SSAnalysisPrototypeBootstrapper
    {
        private WorkspacePrototype ws;

        public SSAnalysisPrototypeBootstrapper()
        {
            const string solutionPath = @"C:\Projects\Lwi.Wst.Parser\Lwi.Wst.Parser.sln";

            this.ws = new WorkspacePrototype(solutionPath);
        }

        public WorkspacePrototype WorkspacePrototype
        {
            get { return this.ws; }
        }
    }
}
