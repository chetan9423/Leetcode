public class Solution {
    public int Reverse(int x)
    {
        int rev=0;
        int rem;
        while(x!=0)
        {
            rem = x % 10;
            if((rev > int.MaxValue/10) || (rev < int.MinValue/ 10))
            {
                return 0;
            }
            rev= rev * 10 + rem;
            x = x / 10;
        }
        return rev;
        
    }
}
    
