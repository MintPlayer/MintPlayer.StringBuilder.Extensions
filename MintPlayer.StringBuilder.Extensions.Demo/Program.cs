using MintPlayer.StringBuilder.Extensions;
using System.Text;

Test1.Run();
Test2.Run();

static class Test1
{
    public static void Run()
    {
        var builder = new StringBuilder();
        builder.AppendIndented("""
    namespace MyStringBuilder.Extensions
    {
    """);

        builder.Indent(EIndentationType.Space, 4);
        builder.AppendIndented("""
    public class Demo
    {
    """);

        builder.Indent(EIndentationType.Space, 4);

        builder.AppendIndented("""
    public void Log(string message, LogLevel level)
    {
        Console.WriteLine(message, level);
    }
    """);

        builder.Unindent();

        builder.AppendIndented("""
    }
    """);

        builder.Unindent();

        builder.AppendIndented("""
    }
    """);

        var result = builder.ToString();
        Console.Write(result);
    }
}

static class Test2
{
    public static void Run()
    {
        var test =
            @"<!DOCTYPE html>
              <html>
                  <head>
                      <meta charset=""UTF-8"">
                      <title>Dedent</title>
                  </head>
                  <body>
                      <h1>Dedent</h1>
                  </body>
              </html>
              ".Dedent();
        Console.Write(test);
    }
}