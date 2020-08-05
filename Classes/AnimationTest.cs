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
    public class AnimationTest : IBlock
    {
        public List<string> Text { get; set; } = new List<string>();
        public override object Evaluate(Context context)
        {
            // read a field
            var AnimationSelection = this.Fields.Get("AnimationSelection");

            //Console.WriteLine(AnimationSelection);

            //return base.Evaluate(context);
            return AnimationSelection;
        }

        public override SyntaxNode Generate(Context context)
        {
            var text = this.Fields.Get("AnimationSelection");

            return LiteralExpression(
                    SyntaxKind.StringLiteralExpression,
                        Literal($"Animation = {text}")
                    );
        }
    }
}
