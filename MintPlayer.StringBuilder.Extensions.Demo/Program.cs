using MintPlayer.StringBuilder.Extensions;
using System.Text;

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