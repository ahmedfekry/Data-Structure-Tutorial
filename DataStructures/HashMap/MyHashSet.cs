public class MyHashSet {

    private readonly int Size = 1000;
    private LinkedList<int>[] keys ;
    public MyHashSet() {
        keys = new LinkedList<int>[Size];
        for(int i =0;i <Size;i++){
            keys[i] = new LinkedList<int>();
        }
    }
    
    public void Add(int key) {
        if(!Contains(key)){
            int hashValue = this.Hash(key);
            keys[hashValue].AddLast(key);
        }
    }
    
    public void Remove(int key) {

        if(Contains(key)){
            int hashValue = Hash(key);

            keys[hashValue].Remove(key);
        }
    }
    
    public bool Contains(int key) {

        int hashValue = Hash(key);
        if(keys[hashValue].Contains(key)){
            return true;
        }
        return false;
    }

    private int Hash(int key){
        return key % Size;
    }
}