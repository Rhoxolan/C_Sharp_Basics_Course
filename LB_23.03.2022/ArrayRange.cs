namespace program
{
    using System.Collections;

    public class ArrayRange<T> : IEnumerable
    {
        int begin;
        int end;
        uint capacity;
        T[] array;

        public ArrayRange(int begin, int end)
        {
            if (begin > end)
            {
                int buf = begin;
                begin = end;
                end = buf;
            }
            this.begin = begin;
            this.end = end;
            capacity = (uint)(end - begin) + 1;
            array = new T[capacity];
        }
        public IEnumerator GetEnumerator() => array.GetEnumerator();

        public uint Capacity
        {
            get { return capacity; }
        }

        public int Begin
        {
            get { return begin; }
        }

        public int End
        {
            get { return end; }
        }

        public T this[int index]
        {
            get
            {
                if (index < begin && index > end)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return array[index - begin];
                }
            }
            set
            {
                if (index < begin && index > end)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    array[index - begin] = value;
                }
            }
        }
    }
}
