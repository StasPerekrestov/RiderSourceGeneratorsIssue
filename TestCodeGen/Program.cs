// See https://aka.ms/new-console-template for more information

namespace TestCodeGen;

partial class Program
{
    public static void Main(string[] args)
    {
        HelloFrom("Generated Code");
    }

    static partial void HelloFrom(string name);
}