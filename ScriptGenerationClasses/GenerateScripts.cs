using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomaticKingdom
{
    public static class GenerateScripts
    {
        public static Script<object> GenerateScript(string code)
        {
            var dynamicRuntimeReference = MetadataReference.CreateFromFile(typeof(System.Runtime.CompilerServices.DynamicAttribute).Assembly.Location);
            var runtimeBinderReference = MetadataReference.CreateFromFile(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo).Assembly.Location);

            var scriptOptions =
            ScriptOptions.Default
            .WithImports("System", "System.Linq", "System.Math", "System.Collections.Generic")
            .AddReferences(dynamicRuntimeReference, runtimeBinderReference);

            return CSharpScript.Create<object>
                (code, scriptOptions);
        }

        public static string ConvertScript(string code)
        {
            string FinalCode = "";

            // Remove existing opening bracket
            FinalCode = code.Substring(1, (code.Length - 1));

            string StartingCode =
                @"using System.Collections.Generic;
                using System.Linq;

                public class Script
                {";

            // Add a class around existing code
            FinalCode = StartingCode + FinalCode;

            // Make AnimationLoop Public
            FinalCode = FinalCode.Replace("dynamic AnimationLoop(dynamic WorldObject)", "public dynamic AnimationLoop(dynamic WorldObject)");

            return FinalCode;
        }
    }
}
