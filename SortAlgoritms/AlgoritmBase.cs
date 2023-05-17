public abstract class AlgoritmBase<T> 
    where T : IComparable
{
    public List<T> Items { get; set; } = new List<T>();

    public event EventHandler<Tuple<int, T>> SetEvent;

    public AlgoritmBase(List<T> items)
    {
        Items = items;
    }

    public AlgoritmBase()
    {
        
    }

    protected void Set(int position, T item)
    {
        if (position < Items.Count)
        {
            SetEvent?.Invoke(this, new Tuple<int, T>(position, item));
            Items[position] = item;
        }
    }

    protected void Swap(int a, int b)
    {
        if (a < Items.Count && b < Items.Count)
        {
            var temp = Items[a];
            Items[a] = Items[b];
            Items[b] = temp;
        }
    }

    public virtual void Sort()
    {
        Items.Sort();
    }
}
