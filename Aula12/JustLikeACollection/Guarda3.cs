using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T v1, v2, v3;

        public Guarda3()
        {
            v1 = default;
            v2 = default;
            v3 = default;
        }

        public void Add(T item)
        {
            if (Equals(v1, default(T)))
            {
                v1 = item;
            }
            else if (Equals(v2, default(T)))
            {
                v2 = item;
            }
            else if (Equals(v3, default(T)))
            {
                v3 = item;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return v1;
            yield return v2;
            yield return v3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return v1;
                case 1:
                    return v2;
                case 2:
                    return v3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    v1 = item;
                    break;
                case 1:
                    v2 = item;
                    break;
                case 2:
                    v3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
