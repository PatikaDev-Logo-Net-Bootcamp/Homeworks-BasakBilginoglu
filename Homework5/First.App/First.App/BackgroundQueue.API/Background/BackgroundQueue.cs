using System;
using System.Collections.Concurrent;

namespace BackgroundQueue.API.Background
{
    public interface IBackgroundQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
    public class BackgroundQueue<T> : IBackgroundQueue<T> where T : class
    {
        private readonly ConcurrentQueue<T> _items = new ConcurrentQueue<T>();
        public T Dequeue()
        {
            var success = _items.TryDequeue(out var workItem);
            return success ? workItem : null;
        }

        public void Enqueue(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _items.Enqueue(item);
        }
    }
}
