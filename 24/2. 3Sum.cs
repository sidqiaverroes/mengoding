//leetcode

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = [];

        Array.Sort(nums);

        int start = 0;
        int left;
        int right;

        while(start < nums.Length - 2)
        {
            //skip if the value same
            if(start > 0 && nums[start] == nums[start-1])
            {
                start++;
                continue;
            }

            left = start+1;
            right = nums.Length-1;

            while(left<right)
            {
                //check triplets
                int sum = nums[start] + nums[left] + nums[right];

                if(sum > 0)
                {
                    right--;
                }
                else if(sum < 0)
                {
                    left++;
                }
                else //sum == 0
                {
                    IList<int> triplet = [];
                    triplet.Add(nums[start]);
                    triplet.Add(nums[left]);
                    triplet.Add(nums[right]);

                    res.Add(triplet);

                    while(nums[left] == triplet[1] && left<right) left++;
                    while(nums[right] == triplet[2] && left<right) right--;
                }
            }

            start++;
        }

        return res;
    }

    // public IList<IList<int>> ThreeSum(int[] nums) {
    //     IList<IList<int>> triplets = [];
    //     Dictionary<int, HashSet<int>> tracker = [];
    //     HashSet<int> visited = [];

    //     Array.Sort(nums);

    //     for(int i=0; i<nums.Length; i++)
    //     {
    //         int x = nums[i];
            
    //         if(visited.Contains(x)) continue;

    //         int target = 0 - x;

    //         List<int[]> pairs = TwoSum(nums, target, i);
    //         visited.Add(x);

    //         if(pairs.Count == 0) continue;
            
    //         foreach(var pair in pairs)
    //         {
    //             int y = nums[pair[0]];
    //             int z = nums[pair[1]];

    //             IList<int> triplet = [];
    //             triplet.Add(x);
    //             triplet.Add(y);
    //             triplet.Add(z);

    //             triplets.Add(triplet);

    //             //tracking
    //             if(!tracker.ContainsKey(x))
    //             {
    //                 var newSet = new HashSet<int>();
    //                 newSet.Add(y);
    //                 newSet.Add(z);
    //                 tracker.Add(x, newSet);
    //             }
    //             else
    //             {
    //                 if(!tracker[x].Contains(y)) tracker[x].Add(y);
    //                 if(!tracker[x].Contains(z)) tracker[x].Add(z);
    //             }
    //         }
    //     }

    //     return triplets;
    // }

    // public List<int[]> TwoSum(int[] numbers, int target, int start) {
    //     List<int[]> res = [];
    //     HashSet<int> visited = [];

    //     int l = start+1;
    //     int r = numbers.Length-1;

    //     while(l<r)
    //     {
    //         if(visited.Contains(numbers[l]))
    //         {
    //             l++;
    //             continue;
    //         }

    //         if(numbers[l] + numbers[r] == target)
    //         {
    //             res.Add(new int[] {l,r});
    //             visited.Add(numbers[l]);
    //             l++;
    //             r--;
    //         }

    //         if(numbers[l] + numbers[r] > target)
    //         {
    //             r--;
                
    //         }
    //         else if(numbers[l] + numbers[r] < target)
    //         {
    //             l++;
    //         }
    //     }

    //     return res;
    // }

    // public IList<IList<int>> ThreeSum(int[] nums) {
    //     var set = new HashSet(nums);

    //     Array.Sort(nums);

    //     IList<IList<int>> triplets = [];
    //     Dictionary<int, HashSet<int>> used = []; //map val to related pair

    //     for(int i=0; i<nums.Length-2; i++)
    //     {
    //         for(int j=i+1; j<nums.Length-1; j++)
    //         {
    //             for(int k=j+1; k<nums.Length; k++)
    //             {
    //                 if(nums[i] + nums[j] + nums[k] == 0)
    //                 {
    //                     int x = nums[i];
    //                     int y = nums[j];
    //                     int z = nums[k];

    //                     if(used.ContainsKey(x))
    //                     {
    //                         if(used[x].Contains(y) || 
    //                         used[x].Contains(z)) continue;
    //                     }

    //                     //tracking
    //                     if(!used.ContainsKey(x))
    //                     {
    //                         var newSet = new HashSet<int>();
    //                         newSet.Add(y);
    //                         newSet.Add(z);
    //                         used.Add(x, newSet);
    //                     }
    //                     else
    //                     {
    //                         if(!used[x].Contains(y)) used[x].Add(y);
    //                         if(!used[x].Contains(z)) used[x].Add(z);
    //                     }

    //                     IList<int> triplet = [];
    //                     triplet.Add(x);
    //                     triplet.Add(y);
    //                     triplet.Add(z);

    //                     triplets.Add(triplet);
    //                 }
    //             }
    //         }
    //     }

    //     return triplets;
    // }
}