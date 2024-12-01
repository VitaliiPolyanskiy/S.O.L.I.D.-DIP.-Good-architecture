
namespace Dependency_Inversion_Principle
{
    public class FileLog : ILog
    {
        public void Write(string str)
        {
            StreamWriter sw = new StreamWriter("User.log", true);
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
