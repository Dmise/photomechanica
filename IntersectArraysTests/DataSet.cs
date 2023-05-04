using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectArraysTests
{
    internal class DataSet<T> 
    {
        public IEnumerable<T> set1;
        public IEnumerable<T> set2;
        public IEnumerable<T> rightValue;
    }
}
