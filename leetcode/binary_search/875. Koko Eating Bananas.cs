// 872. Koko Eating Bananas
// https://leetcode.com/problems/koko-eating-bananas/

// var s = new _875_Koko_Eating_Bananas();
// Console.WriteLine(s.MinEatingSpeed([3, 6, 7, 11], 8)); // 4
// Console.WriteLine(s.MinEatingSpeed([30, 11, 23, 4, 20], 5)); // 30
// Console.WriteLine(s.MinEatingSpeed([30, 11, 23, 4, 20], 6)); // 23

public class _875_Koko_Eating_Bananas
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (CanEatAll(piles, h, mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private bool CanEatAll(int[] piles, int h, int k)
    {
        int hoursNeeded = 0;
        foreach (int pile in piles)
        {
            hoursNeeded += (pile - 1) / k + 1;
        }
        return hoursNeeded <= h;
    }
}