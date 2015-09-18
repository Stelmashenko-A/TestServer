namespace TestServer
{
    interface ICompiler
    {
        bool TryCompile(string code, string outputAssembly);
    }
}
