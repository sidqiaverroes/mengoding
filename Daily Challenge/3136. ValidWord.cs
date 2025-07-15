public class Solution {
    public bool IsValid(string word) {
        bool vowel = false, consonant = false;
        
        if(word.Length<3) return false;
        foreach(var ch in word)
            if(Char.IsDigit(ch) || Char.IsLetter(ch))
            {
                if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || 
                        ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
                   vowel = true;
                else if(Char.IsLetter(ch))
                    consonant = true;
            }
            else return false;
        
        return vowel && consonant;
    }
}