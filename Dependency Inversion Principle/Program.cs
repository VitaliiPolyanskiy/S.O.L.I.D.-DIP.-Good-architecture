namespace Dependency_Inversion_Principle
{
    class Program
    {
        static void Client(ILog log, ISerializer serializer)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            PrintManager manager = new PrintManager();
            List<Human>? list = c.Get();
            manager.Print(list, log);
            HumanRepository repository = new HumanRepository();
            repository.Save(list, serializer);
            c.RemoveAll();
            list = c.Get();
            manager.Print(list, log);
            list = repository.Load(serializer);
            manager.Print(list, log);
        }
        static void Main(string[] args)
        {
            ILog log = new ConsoleLog();
            ISerializer serializer = new XmlFormatter();
            Client(log, serializer);
            log = new FileLog();
            serializer = new JSONSerializer();
            Client(log, serializer);
        }
    }
}
