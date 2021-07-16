using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace HelloWorldCodeGenerator
{
    [Generator]
    public class AnyOfCodeGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required
        }

        public void Execute(GeneratorExecutionContext context)
        {
            Generate(context);
        }

        private void Generate(GeneratorExecutionContext? context)
        {
            BuildEnum(context);
        }

        private static void BuildEnum(GeneratorExecutionContext? context)
        {
            var src = new StringBuilder();
            src.AppendLine("namespace HelloWorld");
            src.AppendLine("{");

            src.AppendLine("    public string SayHello()");
            src.AppendLine("    {");
            src.AppendLine($"        return \"Hello mStack\";");
            src.AppendLine("    }");
            src.AppendLine("}");

            context?.AddSource($"HelloWorld_Generated", SourceText.From(src.ToString(), Encoding.UTF8));
        }
    }
}