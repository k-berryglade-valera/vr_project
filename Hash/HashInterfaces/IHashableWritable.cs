namespace VRApp.Hash
{
    public interface IHashWritable : IHashable
    {
        string HashString(string defaultValue);
    }
}