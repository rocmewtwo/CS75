// 435. Non-overlapping Intervals
// url: https://leetcode.com/problems/non-overlapping-intervals/
// Difficulty: Medium

public class _435_Non_overlapping_Intervals
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return 0;
        }

        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        // Array.Sort(intervals, (a, b) => a[1] < b[1] ? -1 : 1);

        var res = 0;
        var last = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < last[1])
            {
                res++;
            }
            else
            {
                last = intervals[i];
            }
        }

        return res;
    }
}