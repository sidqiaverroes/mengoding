//190. Reverse Bits
//23 June 2025


public class Solution {
    public uint reverseBits(uint n) {
        uint[] arr = new uint[32];
        int index = 0;
        while(n!=0)
        {
            arr[index] = n%2;
            index++;
            n >>= 1;
        }
        
        uint res = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] == 1) res += (uint)Math.Pow(2, arr.Length-1-i);
        }

        return res;
    }

}