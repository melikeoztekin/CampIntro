using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2,T3,T4>
    {
        T1[] _numbers;
        T2[] _names;
        T3[] _sizes;
        T4[] _weights;
        
        public MyDictionary()
        {
            _numbers = new T1[0];
            _names = new T2[0];
            _sizes = new T3[0];
            _weights = new T4[0];
        }
        public void Add(T1 _number,T2 _name,T3 _size,T4 _weight)
        {
            T1[] _tempNumbers = _numbers;
            T2[] _tempNames = _names;
            T3[] _tempSizes = _sizes;
            T4[] _tempWeights = _weights;

            _numbers = new T1[_numbers.Length + 1];
            _names = new T2[_names.Length + 1];
            _sizes = new T3[_sizes.Length + 1];
            _weights = new T4[_weights.Length + 1];

            for (int i = 0; i < _tempNumbers.Length; i++)
            {
                _numbers[i] = _tempNumbers[i];
                _names[i] = _tempNames[i];
                _sizes[i] = _tempSizes[i];
                _weights[i] = _tempWeights[i];
            }

            _numbers[_numbers.Length - 1] = _number;
            _names[_names.Length - 1] = _name;
            _sizes[_sizes.Length - 1] = _size;
            _weights[_weights.Length - 1] = _weight;
        }
        public int Length
        {
            get { return _numbers.Length; }
        }
        public T1[] Tnumber
        {
            get { return _numbers; }
        }

        public T2[] Tname
        {
            get { return _names; }
        }

        public T3[] Tsize
        {
            get { return _sizes; }
        }
        public T4[] Tweight
        {
            get { return _weights; }
        }
    }
}
