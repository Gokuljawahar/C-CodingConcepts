using System;
namespace ArrayMaxValueMinValue
{

    public class ArrayMaxandMin
    {

        public static int ArrayMax(int[] array)
        {

            int Max = array[0];
            foreach (int num in array)
            {
                if (array[num] > Max)
                {

                    Max = array[num];
                }
            }
            return Max;

        }
        public static int ArrayMin(int[] array)
        {

            int Min = array[0];
            foreach (int num in array)
            {
                if (array[num] < Min)
                {

                    Min = array[num];
                }
            }

            return Min;

        }

    }

}