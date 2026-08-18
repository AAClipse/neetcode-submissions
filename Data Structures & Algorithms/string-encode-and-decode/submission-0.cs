public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder encoded = new StringBuilder();
        foreach (string str in strs)
        {
            //encoded.Append($"*{str.Length}#{str}") // создание строки в памяти и потом перенос в обьект стрингбилдера
            encoded.Append("*").Append(str.Length).Append("#").Append(str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) 
    {
        List<string> decoded = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == '*')
            {
                i++;
            }
            int j = i;
            while (s[j] != '#')
            {
                j++;
            } // "*6#abcdef"

            int count = int.Parse(s.Substring(i, j - i));
            string decString = s.Substring(j + 1, count);
            decoded.Add(decString);

            i = j + 1 + count;
        }
        return decoded;
    }
}
