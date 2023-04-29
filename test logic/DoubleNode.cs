using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_logic
{
   
        public class DoubleNode<T>
        {
            public T? Data { get; set; }

            public DoubleNode<T>? Previous { get; set; }

            public DoubleNode<T>? Next { get; set; }

            public DoubleNode(T data)
            {
                Data = data;
                Previous = null;
                Next = null;
            }
        }
    
}
