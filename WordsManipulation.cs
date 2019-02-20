using System.Text;
using System;
using System.Collections.Generic;

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
            //text += " ";
            string text2 = "";
            string word ;
            int i = 0;
            List<string> words = new List<string>();
            while (i < text.Length)
            {
                bool wordEnd = false;
                for(int j = 0; j < symbols.Length; j++)
                    if(text[i] == symbols[j])
                    {
                        wordEnd = true;
                        break;
                    }
                if (i == text.Length - 1)
                    wordEnd = true;
                if (wordEnd)
                {
                    word = i == text.Length - 1 ? text : text.Remove(i);
                    if (word != "")
                    {
                        if (IsWord(word))
                        {
                            if (CheckNewWord(word, words))
                                text2 += i == text.Length - 1 ? text : text.Remove(i + 1);
                            else
                                if (!(i == text.Length - 1))    
                                    text2 +=  text[i];
                        }
                        else
                            text2 += i == text.Length - 1 ? text : text.Remove(  i + 1);
                    }
                    else
                        text2 += text.Remove(1);
                    text = text.Substring(i + 1);
                    i = 0;
                }
                else
                    i++;
            }
            text = text2;
            
        }

        private static bool IsWord(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z')))
                    return false;
            return true;
        }

        private static bool CheckNewWord(string word, List<string> mas)
        {
            foreach(string s in mas)
                if (s == word)
                    return false;
            mas.Add(word);
            return true;
        }
    }
}