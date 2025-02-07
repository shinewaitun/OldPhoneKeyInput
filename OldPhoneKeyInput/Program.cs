using System;
using System.Collections.Generic;

namespace OldPhoneKeyInput
{
    public class Program
    {
        static void Main(string[] args)
        {
            string result = OldPhonePad("4433555 555666#");
            Console.WriteLine(result);
        }

        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            Dictionary<char, string> keyList = new Dictionary<char, string>
            {
                {'1', "&'("},{'2', "ABC"}, {'3', "DEF"},
                {'4', "GHI"}, {'5', "JKL"}, {'6', "MNO"},
                {'7', "PQRS"}, {'8', "TUV"}, {'9', "WXYZ"},
                {'0', " "}
            };
            List<(char code, int count)> repeatedCount = new List<(char code, int count)>();
            char lastKey = input[0];
            int count = 0;
            int i = 0;
            do
            {
                if (lastKey == input[i])
                {
                    count++;
                }
                else
                {
                    repeatedCount.Add((lastKey, count));
                    lastKey = input[i];
                    count = 1;
                }
                i++;
            } while (input[i] != '#');

            repeatedCount.Add((lastKey, count));

            string resultString = "";
            foreach (var item in repeatedCount)
            {
                foreach (var key in keyList)
                {
                    if (item.code == '*')
                    {
                        resultString = resultString.Remove(resultString.Length - item.count);
                        break;
                    }
                    if (item.code == key.Key)
                    {
                        resultString += key.Value[item.count - 1];
                    }
                }
            }
            return resultString;
        }
    }
}
