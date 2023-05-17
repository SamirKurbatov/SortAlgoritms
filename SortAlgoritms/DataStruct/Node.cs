namespace SortAlgoritms.DataStruct
{
    public record Node<T> where T : IComparable
    {
        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public T Data { get; set; }

        public int Index { get; set; }

        public Node(T data, int i)
        {
            Data = data;
            Index = i;
        }
    }
}
