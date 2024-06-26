
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    private static readonly char[] separator = new char[] { ' ' };
    public static int Solution(string s)
    {

        // sentence separators
        char[] sentenceSplit = ['.', '?', '!'];
        //split using the seperators and remove whie spaces
        string[] sentences = s.Split(sentenceSplit, StringSplitOptions.RemoveEmptyEntries);

        int maxWordCount = 0;
        foreach (string sentence in sentences)
        {
            //split each sentence to words 
            string[] words = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //check if word contains a letter
            int wordCount = words.Count(x => x.Any(char.IsLetter));

            if (wordCount > maxWordCount) { maxWordCount = wordCount; }
        }
        //return maximum word count
        return maxWordCount;

    }

}
