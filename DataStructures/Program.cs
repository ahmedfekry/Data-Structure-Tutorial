namespace DataStructures;

class Program
{
    static void Main(string[] args)
    {
        // MyHashSet myHashSet = new MyHashSet();
        // myHashSet.Add(1);      // set = [1]
        // myHashSet.Add(2);      // set = [1, 2]
        // System.Console.WriteLine(myHashSet.Contains(1)); // return True
        // System.Console.WriteLine(myHashSet.Contains(3)); // return False, (not found)
        // myHashSet.Add(2);      // set = [1, 2]
        // System.Console.WriteLine(myHashSet.Contains(2)); // return True
        // myHashSet.Remove(2);   // set = [1]
        // System.Console.WriteLine(myHashSet.Contains(2)); // return False, (already removed)
        // MyHashMap obj = new MyHashMap();
        // obj.Put(1000000,1);
        // int param_2 = obj.Get(1000);
        // obj.Remove(key);

        // HappyNumber happyNumber = new HappyNumber();

        // Console.Write(happyNumber.IsHappy(2));

        TwoSum twoSum = new TwoSum();

        var result = twoSum.FindTwoSum([3,3],6);

        foreach(var t in result){
            Console.WriteLine(t);
        }
    }
}
