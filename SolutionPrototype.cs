using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAnalysisPrototype
{
    public class SolutionPrototype
    {
        private Solution solution;

        private List<ProjectPrototype> projects;

        public SolutionPrototype(Task<Solution> s)
        {
            this.solution = s.Result;
            this.projects = this.solution.Projects.Select(p => new ProjectPrototype(p)).ToList();
        }

        public IEnumerable<ProjectPrototype> Projects
        {
            get { return this.projects; }
        }
    }
}
