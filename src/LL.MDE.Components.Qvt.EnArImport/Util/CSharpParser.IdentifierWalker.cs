using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace LL.MDE.Components.Qvt.EnArImport.Util
{
    public static partial class CSharpParser
    {
        private class IdentifierWalker : CSharpSyntaxWalker
        {
            public readonly ISet<string> Result = new HashSet<string>();

            /// <summary>Called when the visitor visits a IdentifierNameSyntax node.</summary>
            public override void VisitIdentifierName(IdentifierNameSyntax node)
            {
                bool addResult = true;

                // check if the expressing is a method invocation
                SyntaxNode currentNode = node;
                while (currentNode.Parent != null)
                {
                    if (currentNode.Parent is InvocationExpressionSyntax || currentNode.Parent is MemberAccessExpressionSyntax)
                    {
                        addResult = false;
                        break;
                    }
                    currentNode = currentNode.Parent;
                }

                if (addResult)
                {
                    Result.Add(node.Identifier.Text);
                }
            }
        }
    }

}