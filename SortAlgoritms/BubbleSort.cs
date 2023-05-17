public class BubbleSort<T> : AlgoritmBase<T> 
    where T : IComparable
{
    public BubbleSort()
    {
        
    }

    public BubbleSort(List<T> items) : base(items) { }

    public override void Sort()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            for (int j = 0; j < Items.Count; j++)
            {
                if (Items[j].CompareTo(Items[i]) == 1)
                {
                    Swap(i, j);
                }
            }
        }
    }
}