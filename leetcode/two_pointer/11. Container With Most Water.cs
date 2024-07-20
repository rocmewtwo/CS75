public class _11_Container_With_Most_Water {
    public int MaxArea(int[] height) {
        // Two pointer approach
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right) {
            maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

            // move the pointer with the smaller height
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }
        return maxArea;
    }
}