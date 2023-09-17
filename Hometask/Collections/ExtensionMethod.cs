using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask.Collections
{
    public static class ExtensionMethod
    {
        public static void YangiExtensionMethod(this int[][] jaggedArray, int index, int value)
        {
            
            Array.Resize(ref jaggedArray[index], jaggedArray[index].Length+1);
            jaggedArray[index][jaggedArray[index].Length - 1] = value;
        }

        //returnsiz ishlatgan paytim reference ni qabul qilib olmadi
        public static int[][] YangiExtensionMethod(this int[][] jaggedArray, int value)
        {
            Array.Resize(ref jaggedArray, jaggedArray.Length+1);
            jaggedArray[jaggedArray.Length - 1] = new int[] { value };
            return jaggedArray;
        }
    }
}
