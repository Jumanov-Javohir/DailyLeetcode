namespace DailyLeetcode.Strings.TruncateSentence;
public class TruncateSentence
{
    public static string TruncateSentences(string s, int k)
    {
        var result = new List<string>();
        int index = 0;

        string[] words = s.Split(' ');

        while (k > 0)
        {
            result.Add(words[index].ToString());

            index++;
            k--;
        }
        return String.Join(" ", result.ToArray());
    }
}
