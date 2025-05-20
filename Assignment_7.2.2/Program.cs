namespace Assignment_7._2._2
{
    internal class Program
    {
        //Given a string s, reverse only all the vowels in the string and return it.
        //The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower 
        //and upper cases, more than once.
        //Example 1:
        //Input: s = "hello"
        //Output: "holle"

       static string ReverseVowels(string s)
        {
            var vowels = new HashSet<char>
            {
                'a', 'e','i', 'o', 'u',
                'A', 'E', 'I', 'O', 'U'
            };

            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;

            while (left < right) {// go through the loop until condition is met meaning two pointers
                while(left < right && !vowels.Contains(chars[left])) // move left pointer until vowel is found
                {
                    left++; // increment 
                }
                while (left < right && !vowels.Contains(chars[right]))
                { // move right pointer until vowel is found
                    right--; // decrement 
                }
                    // swapping
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
              
                left++;
                right--;
            }
            return new string (chars); 
        }

        static void Main(string[] args)
        {
            string s = "hello";
            string result = ReverseVowels(s);
            Console.WriteLine(result);

        }
    }
}
