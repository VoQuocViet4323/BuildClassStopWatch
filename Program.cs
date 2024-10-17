internal class Program
{
    //Sử dụng thuật toán Selection Sort để sắp xếp mảng theo thứ tự tăng dần
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int[] numbers = new int[100000];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 100000);
        }

        StopWatch stopwatch = new StopWatch();

        stopwatch.Start();

        SelectionSort(numbers);

        stopwatch.Stop();

        Console.WriteLine("Thời gian đã trôi qua: " + stopwatch.GetElapsedTime() + " milliseconds");
    }
}