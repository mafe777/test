using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            Count = 0;

        }
        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $" - {pointer.Data}\n";
                pointer = pointer.Next;
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
                node.Previous = _last;
                _last!.Next = node;
                _last = node;
            }
            Count++;
        }
        public DoubleList<Cars> GetBrand(string brand)
        {
            var BrandList = new DoubleList<Cars>();
            var pointer = _first;
            while (pointer != null)
            {
                 Cars cars = (Cars)Convert.ChangeType(pointer.Data, typeof(Cars))!;
                if (cars!.Brand!.Equals(brand))
                {
                    BrandList.Add(cars);
                }
                pointer = pointer.Next;
            }
            return BrandList;
        }

        public DoubleList<Cars> GetYear(int lower, int upper)
        {
            var YearList = new DoubleList<Cars>();
            var pointer = _first;
            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Data, typeof(Cars))!;
                if (cars.Year > lower && cars.Year <= upper)
                {
                    YearList.Add(cars);
                }
                pointer = pointer.Next;
            }
            return YearList;
        }

        public DoubleList<Cars> GetPrice(decimal lower, decimal upper)
        {
            var PriceList = new DoubleList<Cars>();
            var pointer = _first;
            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Data, typeof(Cars))!;
                if (cars.Price > lower && cars.Price <= upper)
                {
                    PriceList.Add(cars);
                }
                pointer = pointer.Next;
            }
            return PriceList;
        }
        public Cars[] GetMinMaxPrice(DoubleList<Cars> list)
        {
            var minMax = new Cars[2];
            var pointer = _first;
            Cars min = (Cars)Convert.ChangeType(pointer!.Data, typeof(Cars))!;
            Cars max = (Cars)Convert.ChangeType(pointer.Data, typeof(Cars))!;
            pointer = pointer.Next;
            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Data, typeof(Cars))!;
                if (cars.Price > max.Price)
                {
                    max = cars;
                }
                else if (cars.Price < min.Price)
                {
                    min = cars;
                }
                pointer = pointer.Next;
            }
            minMax[0] = min;
            minMax[1] = max;
            return minMax;
        }



    }
}
