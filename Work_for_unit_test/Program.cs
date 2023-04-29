using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_for_unit_test
{
    public class Program
    {
        public static int work_with_file()
        {
            int x = 1 + 1;
            return x;
        }
        public static Boolean MethodTrue()
        {
            return true;
        }
        public static Boolean MethodFalse()
        {
            return false;
        }

        public static object MethodNull()
        {
            object a = null;
            return a;
        }

        public static int[] MethodArray()
        {
            int[] arr = new int[3];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        static void Main(string[] args)
        {
        }
    }
}
