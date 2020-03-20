using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAnalysisPrototype
{
    public class WorkspacePrototype
    {
        private MSBuildWorkspace ws;

        private SolutionPrototype currentSolution;

        public WorkspacePrototype(string solutionPath)
        {
            this.ws = MSBuildWorkspace.Create();
            this.currentSolution = new SolutionPrototype(ws.OpenSolutionAsync(solutionPath));
        }

        public IEnumerable<ProjectPrototype> Projects
        {
            get { return this.currentSolution.Projects; }
        }


    }
}
