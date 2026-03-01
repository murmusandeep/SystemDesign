namespace CountHomogenous
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = CountHomogenous("abbcccaa");
            Console.WriteLine(result);
        }

        public static int CountHomogenous(string s)
        {
            int mod = 1_000_000_007; // As result can be large, take modulo 10^9 + 7
            long result = 0;         // Use long to prevent overflow during calculation
            int count = 1;           // Start with count = 1 because first character is at least one homogenous substring

            // Loop from second character to end
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    // If current char is same as previous, extend the homogenous sequence
                    count++;
                }
                else
                {
                    // Calculate number of substrings for the previous homogenous sequence
                    // Formula: n * (n + 1) / 2
                    result += (long)count * (count + 1) / 2;
                    result %= mod; // Apply modulo to avoid overflow

                    // Reset count for new character
                    count = 1;
                }
            }

            // Don't forget to process the last group after loop ends
            result += (long)count * (count + 1) / 2;
            result %= mod;

            return (int)result;
        }
    }
}
