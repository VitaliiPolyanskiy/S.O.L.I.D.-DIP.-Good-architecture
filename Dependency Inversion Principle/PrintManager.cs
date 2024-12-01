namespace Dependency_Inversion_Principle
{
    class PrintManager
    {  
        public void Print(List<Human> list, ILog log)
        {
            if (list.Count == 0)
            {
                log.Write("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                log.Write(j.Name + "\t" + j.Age);
            }
        }
    }
}
