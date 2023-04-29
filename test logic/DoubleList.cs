using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace test_logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;
        private DoubleNode<T>? _last;


        public DoubleList()
        {
            _first = null;
            _last = null;
            count = 0;

        }
        public int count { get; set; }

        public bool IsEmpty => count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer !=null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;

            }
            return output;
        }

        public void Add(T item)
        {
            var node = new DoubleNode<T>(item);

            if (IsEmpty) 
            {
                _first = node;
                _last = node;
            }
            else 
            {
                node.Left = _last;
                _last!.Right = node;
                _last= node;
            }
            count++;
        }
    }
}
