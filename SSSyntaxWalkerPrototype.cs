using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace SSAnalysisPrototype
{
    public class SSSyntaxWalkerPrototype : CSharpSyntaxWalker
    {
        public override void Visit(SyntaxNode node)
        {
            base.Visit(node);
        }
    }
}
