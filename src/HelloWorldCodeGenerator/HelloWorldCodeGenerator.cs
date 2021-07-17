using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace HelloWorldCodeGenerator
{
    [Generator]
    public class HelloWorldGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }
#endif
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var src = new StringBuilder();
            src.AppendLine("public class HelloWorld");
            src.AppendLine("{");

            src.AppendLine("    public void SayHello()");
            src.AppendLine("    {");
            src.AppendLine("        System.Console.WriteLine(\"Hello mStack!\");");
            src.AppendLine("    }");
            src.AppendLine("}");

            context.AddSource("HelloWorld_Generated", SourceText.From(src.ToString(), Encoding.UTF8));
        }
    }
}