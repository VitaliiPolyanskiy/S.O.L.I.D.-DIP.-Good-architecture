namespace Dependency_Inversion_Principle
{
    public interface ISerializer
    {
        void Save(List<Human> collection);
        List<Human> Load();
    }
}
