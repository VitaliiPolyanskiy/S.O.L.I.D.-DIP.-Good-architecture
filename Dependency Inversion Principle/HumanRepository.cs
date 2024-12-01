namespace Dependency_Inversion_Principle
{
    class HumanRepository
    {
        public void Save(List<Human> list, ISerializer serializer)
        {
            serializer.Save(list);
        }
        public List<Human> Load(ISerializer serializer)
        {
            List<Human> list = serializer.Load();
            return list;
        }
    }
}
