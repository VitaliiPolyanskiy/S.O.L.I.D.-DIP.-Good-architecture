namespace Dependency_Inversion_Principle
{
    public class ConsoleLog : ILog
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
