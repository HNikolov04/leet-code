namespace LeetCode.Challenges._0058_length_of_last_word;

public class _0058_length_of_last_word
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Trim().Split(' ');

        return words[words.Length - 1].Length;
    }
}
