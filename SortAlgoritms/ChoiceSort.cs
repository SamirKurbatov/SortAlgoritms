namespace SortAlgoritms
{
    public class ChoiceSort<T> : AlgoritmBase<T> 
        where T : IComparable
    {
        public ChoiceSort(List<T> items) : base(items)
        {
            
        }

        public ChoiceSort()
        {
            
        }

        public override void Sort()
        {
            int minPos;
            for (int i = 0; i < Items.Count; i++)
            {
                minPos = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[j].CompareTo(Items[minPos]) == -1)
                    {
                        minPos = j;
                    }
                }
                Swap(i, minPos);
            }
        }
    }
}
