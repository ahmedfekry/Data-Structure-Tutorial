public class MyHashMap {
    int[] array;
    public MyHashMap() {
        array = Enumerable.Repeat(-1, 1000000).ToArray();
    }
    
    public void Put(int key, int value) {
        array[key] = value;
    }
    
    public int Get(int key) {
        return array[key];
    }
    
    public void Remove(int key) {
        array[key] = -1;
    }
}