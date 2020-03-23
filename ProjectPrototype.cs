using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAnalysisPrototype
{
    public class ProjectPrototype
    {
        private Project project;

        private CompilationPrototype compilation;

        public ProjectPrototype(Project p)
        {
            this.project = p;
            this.compilation = new CompilationPrototype(this.project.GetCompilationAsync());
        }

        public string Name
        {
            get { return this.project.Name; }
        }

        public IEnumerable<Tuple<string, int>> ChildrenNamesAndTypes
        {
            get { return this.GetChildNames(); }
        }

        private List<Tuple<string, int>> GetChildNames()
        {
            var tupleList = new List<Tuple<string, int>>();

            var compilation = this.CompilationPrototype;

            foreach (var tree in compilation.SyntaxTrees)
            {
                var notableObjects = tree.GetRoot().DescendantNodes().Where(x => x.IsKind(SyntaxKind.ClassDeclaration) || x.IsKind(SyntaxKind.InterfaceDeclaration));

                foreach(var obj in notableObjects)
                {
                    if (obj.IsKind(SyntaxKind.ClassDeclaration))
                    {
                        var classDec = (ClassDeclarationSyntax)obj;
                        tupleList.Add(new Tuple<string, int>(classDec.Identifier.Text, 1));
                    }
                    else if (obj.IsKind(SyntaxKind.InterfaceDeclaration))
                    {
                        var interfaceDec = (InterfaceDeclarationSyntax)obj;
                        tupleList.Add(new Tuple<string, int>(interfaceDec.Identifier.Text, 1));
                    }
                    else
                    {
                        tupleList.Add(new Tuple<string, int>("WTF Object", 0));
                    }
                }
            }

            return tupleList;
        }

        public Compilation CompilationPrototype
        {
            get { return this.compilation.Compilation; }
        }
    }
}
