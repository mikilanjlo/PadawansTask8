using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            char[] symbols = new char[] { '.', ',', '!', '?' ,'-', ':', ';', ' '};
            if (text == null)
                throw new ArgumentNullException();
            if (text == "")
                throw new ArgumentException();
            text += " ";
            string text2 = "";
            string word ;
            int i = 0;
            while(i < text.Length)
            {
                bool wordEnd = false;
                for(int j = 0; j < symbols.Length; j++)
                    if(text[i] == symbols[j])
                    {
                        wordEnd = true;
                        break;
                    }

                if (wordEnd)
                {
                    word = text.Remove(i);
                    text2 += text.Remove(i == text.Length - 1 ? i : i + 1);
                    text = text.Substring( i + 1);
                    if (word != "")
                        text = text.Replace(word, "");
                    i = 0;
                }
                else
                    i++;
            }
            text = text2;
            
        }
    }
}