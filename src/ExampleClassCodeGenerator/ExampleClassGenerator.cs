using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace ExampleClassCodeGenerator
{
    [Generator]
    public class ExampleClassGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var src = new StringBuilder();
            src.AppendLine("namespace ExampleClassCodeGenerator");
            src.AppendLine("{");
            src.AppendLine("    public class ExampleClass");
            src.AppendLine("    {");

            foreach (var property in new [] { "I1", "I2", "I3" })
            {
                src.AppendLine($"        public int {property} {{ get; set; }}");
            }

            src.AppendLine("    }");
            src.AppendLine("}");

            context.AddSource("ExampleClass_Generated", SourceText.From(src.ToString(), Encoding.UTF8));
        }
    }
}