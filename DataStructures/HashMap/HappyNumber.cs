public class HappyNumber{
    public bool IsHappy(int n){

        HashSet<int> ints = new HashSet<int>();
        while(n != 1){
            if(ints.Contains(n)){
                return false;
            }else{
                ints.Add(n);
            }
            n = computeHappy(n);
        }

        return true;
    }

    public int computeHappy(int x){

        int reminder = x%10;
        x = x/10;

        int result = 0;
        while(x > 0){
            result += (reminder*reminder);

            reminder = x%10;
            x = x/10;
        }
        result += (reminder*reminder);
        return result;
    }
}


/*
    123
    1*1 + 2*2 + 3*3 = 1+4+9 = 14;

*/