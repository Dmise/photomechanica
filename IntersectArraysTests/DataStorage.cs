using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectArraysTests
{
    internal static class DataStorage
    {
        public static DataSet<string> data1 = new DataSet<string>
        {
            set1 = new string[] { "one", "two", "hello", "world", "OOP", "data", "calculator", "OOP", "two", "one" },
            set2 = new string[] {  "open", "WebRTC", "array" , "one", "" ,"two", "car" ,"two"},
            rightValue = new string[] { "one", "two" }
        };

        public static DataSet<string> data2 = new DataSet<string>
        {
            set1 = new string[] { "one", "two", "hello", "world", "OOP", "data", "calculator", "OOP" },
            set2 = new string[] { "hello", "open", "OOP", "WebRTC", "array" },
            rightValue = new string[] { "hello", "OOP" }
        };

        public static DataSet<string> data3 = new DataSet<string>
        {
            set1 = new string[] { "one", "two", "hello", "world", "data", "calculator" },
            set2 = new string[] {  },
            rightValue = new string[0] 
        };

        public static DataSet<string> data4 = new DataSet<string>
        {
            set1 = new string[] { "one", "two", "2" ,"hello", "world", "data", "3", "calculator", "1", },
            set2 = new string[] { "1", "2", "3" },
            rightValue = new string[] { "1", "2", "3" },
        };
    }    
}
