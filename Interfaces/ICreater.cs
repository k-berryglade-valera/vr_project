namespace VRApp
{
    public interface ICreater<EntityType>
    {
        bool CreateEntity<EntityType>();
    }
}