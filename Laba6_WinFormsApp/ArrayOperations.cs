namespace WinFormsApp1
{
    public static class ArrayOperations
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (var value in array)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public static int FindMin(int[] array)
        {
            int min = array[0];
            foreach (var value in array)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        public static double Average(int[] array)
        {
            double sum = 0;
            foreach (var value in array)
            {
                sum += value;
            }
            return sum / array.Length;
        }
    }
}
