public class Solution {
    public bool IsPalindrome(int x) 
    {
        int rev=0;
        int rem;
        int temp=x;
        while(temp>0)
        {
        rem= temp % 10;
        rev= rev * 10 + rem;
        temp = temp/10;
        }
        if(x==rev)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
