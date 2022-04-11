using System;
using System.Collections.Generic;
using System.Text;


namespace GuMBoxX.Models
{
    internal class Indexer<T> : IEnumerable<T>
    {
        private T[] _arr;

        public int Length { get => _arr.Length; }

        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }




        public Indexer()
        {
            _arr = new T[0];
        }




        public void CustomAdd(T item)
        {
            T[] resizedList = Resize(_arr, _arr.Length + 1);
            resizedList[^1] = item;
            _arr = resizedList;
        }



        public void CustomRemove(T index)
        {
            bool isTrue = false;
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                if (index.Equals(_arr[i]))
                {
                    isTrue = true;
                }
                if (isTrue)
                {
                    _arr[i] = _arr[i + 1];
                }
            }
            if (index.Equals(_arr[^1]));
            {
                isTrue = true;
            }
            if (isTrue)
            {
                T[] resizedList = Resize(_arr, _arr.Length - 1);
                _arr = resizedList;
            }


        }

        static T[] Resize(T[] arr, int newlength)
        {
            T[] resizedList = new T[newlength];
            int loopCount = newlength > arr.Length ? arr.Length : newlength;
            for (int i = 0; i < loopCount; i++)
            {
                resizedList[i] = arr[i];
            }
            return resizedList;


        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }    }
