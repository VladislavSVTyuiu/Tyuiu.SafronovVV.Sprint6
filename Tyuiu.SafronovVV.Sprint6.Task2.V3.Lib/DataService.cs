using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafronovVV.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[-startValue + stopValue + 1];
            for (int i = 0, x = startValue; x <= stopValue; x++, i++)
            {
                array[i] = Math.Round(((Math.Sin(x)) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
            }

            return array;
        }
    }
}
