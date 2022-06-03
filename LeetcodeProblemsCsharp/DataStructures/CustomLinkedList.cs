using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CustomLinkedListItem<T>
        where T : class
    {
        public T? Previous { get; set; } = null;
        public T? Current { get; set; }
        public T? Next { get; set; } = null;
    }

    public class CustomLinkedList<T>
        where T : class
    {
        public List<CustomLinkedListItem<T>> List { get; set; } = new List<CustomLinkedListItem<T>>();

        public CustomLinkedList(List<CustomLinkedListItem<T>> items)
        {
            this.List = items;
        }

        public void Clear() => List = new List<CustomLinkedListItem<T>>();
        public void RemoveFirst()
        {
            var first = List.First(x => x.Previous == null);

            List.Remove(first);

            if (List.Count() > 0)
            {
                List.First().Previous = null;
            }
        }

        public void RemoveLast()
        {
            var last = List.ToArray()[List.Count - 1];

            List.Remove(last);

            if (List.Count() > 0)
            {
                List.ToArray()[List.Count - 1].Next = null;
            }
        }

        public CustomLinkedListItem<T> Add(CustomLinkedListItem<T> item)
        {
            List.Add(item);

            return item;
        }

    }

    public static class TestingLinkedList
    {
        class TestClass
        {
            public int Id { get; set; }
        }

        public static void ExampleOne()
        {
            var testclass1 = new TestClass { Id = 1 };
            var testclass2 = new TestClass { Id = 2 };
            var testclass3 = new TestClass { Id = 3 };
            var testclass5 = new TestClass { Id = 5 };

            var item1 = new CustomLinkedListItem<TestClass>
            {
                Previous = null,
                Current = testclass1,
                Next = testclass2
            };
            var item2 = new CustomLinkedListItem<TestClass>
            {
                Previous = testclass1,
                Current = testclass2,
                Next = testclass3
            };
            var item3 = new CustomLinkedListItem<TestClass>
            {
                Previous = testclass2,
                Current = testclass3,
                Next = testclass5
            };
            var item5 = new CustomLinkedListItem<TestClass>
            {
                Previous = testclass3,
                Current = testclass5,
                Next = null
            };
            var customLinkedList = new CustomLinkedList<TestClass>(new List<CustomLinkedListItem<TestClass>> { item1, item2, item3, item5 });

            foreach (var item in customLinkedList.List)
            {
                Console.WriteLine($"{item.Previous?.Id} <- {item.Current?.Id} -> {item.Next?.Id}");
            }

            // Remove first
            Console.WriteLine("--Remove first--");
            customLinkedList.Clear();
            customLinkedList = new CustomLinkedList<TestClass>(new List<CustomLinkedListItem<TestClass>> { item1, item2, item3, item5 });
            customLinkedList.RemoveFirst();
            foreach (var item in customLinkedList.List)
            {
                Console.WriteLine($"{item.Previous?.Id} <- {item.Current?.Id} -> {item.Next?.Id}");
            }
        }
    }
}
