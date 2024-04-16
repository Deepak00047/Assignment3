using System;

namespace Assignment3
{
    public interface ILinkedListADT
    {
        void Add(object item);
        void AddLast(object item);
        void AddFirst(object item);
        void Replace(int index, object item);
        int Count();
        object GetValue(int index);
        int IndexOf(object item);
        bool Contains(object item);
        bool IsEmpty();
        void Clear();
        void Remove(object item);
        void RemoveFirst();
        void RemoveLast();
    }
}
