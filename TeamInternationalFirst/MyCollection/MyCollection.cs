using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst
{
    public class MyCollection<T>: IEnumerable<T>
    {
        private int length = 0;
        private int iter = 0; // the actual number of elements
        private T[] contents = null;

        public int Length { get => iter; }

        public MyCollection()
        {
            length = 10;
            contents = new T[length];
        }

        public MyCollection(int size)
        {
            this.length = size;
            contents = new T[length];
        }

        public void pushBack(T cht)
        {
            if (contents.Length == iter)
            {
                length = (int) (length * 1.5);
                int cnt = 0;
                T[] tmp = new T[length];
                foreach (T one in contents)
                    tmp[cnt++] = one;
                tmp[cnt++] = cht;
                iter = cnt;
                contents = tmp;
            }
            else
            {
                contents[iter++] = cht;
            }
        }

        public void printAll()
        {
            foreach(T one in contents)
                Console.WriteLine(one);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < iter; index++)
            {
                yield return contents[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
