using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX
{
    internal class Indexer <T>
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
            Resize();
            _arr[^1] = item;
        }
        public void Resize()
        {
            T[] resizedList = new T[_arr.Length + 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                resizedList[i] = _arr[i];
            }
            _arr = resizedList;

        }
    }















}
