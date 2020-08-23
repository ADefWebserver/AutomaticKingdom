using System;
using System.Collections.Generic;
using IronBlock;
using IronBlock.Blocks;
using IronBlock.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace AutomaticKingdom.Classes
{
    public class ExecuteAnimation : IBlock
    {
        public List<string> Text { get; set; } = new List<string>();
        public override object Evaluate(Context context)
        {
            // Read field
            var AnimationSelection = this.Fields.Get("AnimationSelection");

            Console.WriteLine($"ExecuteAnimation({AnimationSelection})");

            return base.Evaluate(context);
        }

        public override SyntaxNode Generate(Context context)
        {
            var AnimationSelection = this.Fields.Get("AnimationSelection");

            SyntaxNode syntaxNode = LiteralExpression(
                    SyntaxKind.StringLiteralExpression,
                        Literal($"ExecuteAnimation({AnimationSelection})")
                    );

            var expression = syntaxNode as ExpressionSyntax;

            var invocationExpression =
                SyntaxGenerator.MethodInvokeExpression(IdentifierName(nameof(Console)), nameof(Console.WriteLine), expression);

            return Statement(invocationExpression, base.Generate(context), context);
        }
    }
}
