using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class countstring
    {
        public void cs()
        {
            String sentence = "india is my country";
            int wordCount = 0;

            for (int i = 0; i < sentence.Length - 1; i++)
            {
               
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
             
            wordCount++;

            Console.WriteLine("Total number of words: " + wordCount);
        }

    }
}
