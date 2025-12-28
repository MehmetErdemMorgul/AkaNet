using System;
using System.Collections.Generic;

namespace AkaNet.Algorithms
{
    public class SimplePriorityQueue<T>
    {
        private List<(T item, double priority)> list =
            new List<(T item, double priority)>();

        public int Count
        {
            get { return list.Count; }
        }

        public void Enqueue(T item, double priority)
        {
            list.Add((item, priority));
        }

        public T Dequeue()
        {
            int bestIndex = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].priority < list[bestIndex].priority)
                    bestIndex = i;
            }

            T bestItem = list[bestIndex].item;
            list.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
