using MintPlayer.StringBuilder.Extensions;
using System.Text;

var builder = new StringBuilder();
builder.AppendIndented("""
    namespace MyStringBuilder.Extensions
    {
        public class Demo
        {
    """);

builder.AppendIndented("""
        }
    }
    """);

var result = builder.ToString();
Console.Write(result);