using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgoritms;
using SortAlgoritms.DataStruct;

namespace SortAlgoritmsTests
{
    [TestClass()]
    public class SortTest
    {
        private Random rnd = new Random();

        private List<int> Items = new List<int>();

        private List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSort()
        {
            // Arrange
            var bubbleSort = new BubbleSort<int>();

            bubbleSort.Items.AddRange(Items);
            // Act
            bubbleSort.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubbleSort.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSort()
        {
            // Arrange
            var insertSort = new InsertSort<int>();

            insertSort.Items.AddRange(Items);
            // Act
            insertSort.Sort();
            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ChoiceSort()
        {
            // Arrange
            var choiceSort = new ChoiceSort<int>();

            choiceSort.Items.AddRange(Items);
            // Act
            choiceSort.Sort();
            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], choiceSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSort()
        {
            // Arrange
            var shellSort = new ShellSort<int>();

            shellSort.Items.AddRange(Items);
            // Act
            shellSort.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shellSort.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSort()
        {
            // Arrange
            var treeSort = new Tree<int>(Items);

            // Act
            treeSort.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], treeSort.Items[i]);
            }
        }
    }
}
