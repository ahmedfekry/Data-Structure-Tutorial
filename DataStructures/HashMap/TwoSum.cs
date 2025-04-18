using System.Collections;
using System.Linq;

public class TwoSum{
    public int[] FindTwoSum(int[] nums, int target){
        Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
        int temp = nums[0];

        keyValuePairs.Add(temp,0);
        for(int x =1;x < nums.Count(); x++){
            
            temp = nums[x];
            if(keyValuePairs.ContainsKey(target - temp)){
                return new int[2]{keyValuePairs[(target-temp)],x};
            }else{
                keyValuePairs[nums[x]] = x;
            }
        }
        return new int[2];
    }
}