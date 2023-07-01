namespace Iterator
{
    public interface IMenu
    {
        // IEnumerator: Supports a simple iteration over a non-generic collection. 
        IEnumerator<MenuItem> CreateIterator();
    }
}
