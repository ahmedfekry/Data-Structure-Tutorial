using System.Collections;

public class SingleNumber{
    public int Single(int[] nums){
        Hashtable hashtable = new Hashtable();
        foreach(int x in nums){
            if(hashtable.Contains(x)){
                hashtable[x] = 2;
            }else{
                hashtable[x] = 1;
            }
        }

        foreach (DictionaryEntry item in hashtable)
        {
            if((int)item.Value == 1){
                return (int)item.Key;
            }
        }
        return 0;
    }

}