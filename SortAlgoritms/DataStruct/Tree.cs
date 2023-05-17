using System.Collections;

namespace SortAlgoritms.DataStruct
{
    public class Tree<T> : AlgoritmBase<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }

        private List<Node<T>> values = new List<Node<T>>();

        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Items.Add(item);

                var node = new Node<T>(item, i);

                Add(node);
            }
        }

        public void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Add(Root, node);
            Count++;
        }

        private void Add(Node<T> node, Node<T> newNode)
        {
            if (node.Data.CompareTo(newNode.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }

            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }

        public override void Sort()
        {
            var result = InfixOrder(Root).Select(r => r.Data).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }

        public List<Node<T>> InfixOrder()
        {
            values.Clear();
            InfixOrder(Root);
            return values;
        }

        private List<Node<T>> InfixOrder(Node<T> position)
        {
            if (position != null)
            {
                InfixOrder(position.Left);
                values.Add(position);
                InfixOrder(position.Right);
            }
            return values;
        }
    }
}
