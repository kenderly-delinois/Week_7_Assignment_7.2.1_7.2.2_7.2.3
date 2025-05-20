using Microsoft.VisualBasic;

namespace Week_7_Assignment_7._2._3
{
    internal class Program
    {
        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
        //typically using all the original letters exactly once.
        //Example 1:
        //Input: s = "anagram", t = "nagaram"
        //Output: true

        // O(n)
        static bool Rearranging(string s, string t)
        {
            if(s.Length != t.Length) return false; // edge case if both length does not equal

            char[] charsS = s.ToCharArray(); // convert to char array to iterate over each char
            char[] charsT = t.ToCharArray(); // convert to char array to iterate over each char
            int left = 0;
            int right = s.Length;

            Array.Sort(charsS); //sort to future compare if they have the same char
            Array.Sort(charsT); // sort to future compare if they have the same char

            // Looking if they have the same char
            for (int i = 0; i < charsS.Length; i++)
            {
                if (charsS[i] != charsT[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";

            Console.WriteLine(Rearranging(s, t));  
        }
    }
}
