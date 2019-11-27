using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGenericSwapMethod
{
    public class StringSwapClass
    {
        /// <summary>
        /// To swap two string method
        /// </summary>
        /// <typeparam name="T">method type</typeparam>
        /// <param name="firstParameter">first T type parameter. Can be any type.</param>
        /// <param name="secondParameter">second T type parameter. Can be any type.</param>
        public static void StringSwap<T>(ref T firstParameter,ref T secondParameter)
        {


            T temp;
            temp = firstParameter;
            firstParameter = secondParameter;
            secondParameter = temp;
        }
    }
}
