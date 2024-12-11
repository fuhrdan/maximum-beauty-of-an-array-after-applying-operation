//*****************************************************************************
//** 2779. Maximum Beauty of an Array After Applying Operation      leetcode **
//*****************************************************************************

int compare(const void *a, const void *b)
{
    return (*(int *)a - *(int *)b);
}

int maximumBeauty(int *nums, int numsSize, int k)
{
    qsort(nums, numsSize, sizeof(int), compare);

    int left = 0;
    int max_beauty = 0;

    for (int right = 0; right < numsSize; right++)
    {
        while (nums[right] - nums[left] > 2 * k)
        {
            left++;
        }
        max_beauty = (right - left + 1 > max_beauty) ? (right - left + 1) : max_beauty;
    }

    return max_beauty;
}