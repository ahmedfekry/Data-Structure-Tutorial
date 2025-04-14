public class ContainsDuplicate{
    public bool CheckDuplicate(int[] nums) {
        HashSet<int> shset = new HashSet<int>();
        foreach(int temp in nums){
            if(shset.Contains(temp)){
                return true;
            }
            shset.Add(temp);
        }
        return false;
    }
}