HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int[] kassa = new int[n];
        int[] min = new int[2];
        int max = 0;
        for (int i = 0; i < n; i++) kassa[i] += customers[i];
        for(int i = n; i < customers.Length; i++)
        {
            min[0] = 0;
            min[1] = kassa[0];
            for (int j = 1; j < n; j++)
            {
                if (kassa[j] < min[1])
                {
                    min[1] = kassa[j];
                    min[0] = j;
                }
            }
            kassa[min[0]] += customers[i];
        }
        for(int i = 0; i < n; i++)
            if (kassa[i] > max) max = kassa[i];
        Console.WriteLine(max);
        return 0;
    }    
}