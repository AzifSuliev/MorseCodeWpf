using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeWpf
{
    internal class Morse
    {
        private Dictionary<char, string>? engToMorse;
        private Dictionary<string, char>? morseToEng;
        private void EngToMorseCodeAlphabet()
        {
            engToMorse = new Dictionary<char, string>
            {
                { 'A', ".-"},
                { 'B', "-..."},
                { 'C',"-.-."},
                { 'D',"-.."},
                { 'E',"."},
                { 'F',"..-."},
                { 'G',"--."},
                { 'H',"...."},
                { 'I',".."},
                { 'J',".---"},
                { 'K',"-.-"},
                { 'L',".-.."},
                { 'M',"--"},
                { 'N',"-."},
                { 'O',"---"},
                { 'P',".--."},
                { 'Q',"--.-"},
                { 'R',".-."},
                { 'S',"..."},
                { 'T',"-"},
                { 'U',"..-"},
                { 'V',"...-"},
                { 'W',".--"},
                { 'X',"-..-"},
                { 'Y',"-.--"},
                { 'Z',"--.."},
                { ' ',"/"},
                { '1',".----"},
                { '2',"..---"},
                { '3',"...--"},
                { '4',"....-"},
                { '5',"....."},
                { '6',"-...."},
                { '7',"--..."},
                { '8',"---.."},
                { '9',"----."},
                { '0',"-----"},
            };
        }

        private void MorseToEngCodeAlphabet()
        {
            morseToEng = new Dictionary<string, char>
            {
                {  ".-", 'A'},
                {  "-...", 'B'},
                { "-.-.", 'C'},
                { "-..", 'D'},
                { ".", 'E'},
                { "..-.", 'F'},
                { "--.", 'G'},
                {"....", 'H'},
                { "..", 'I'},
                { ".---", 'J'},
                { "-.-", 'K'},
                { ".-..", 'L'},
                { "--", 'M'},
                { "-.", 'N'},
                { "---", 'O'},
                { ".--.", 'P'},
                { "--.-", 'Q'},
                { ".-.", 'R'},
                { "...", 'S'},
                { "-", 'T'},
                { "..-", 'U'},
                { "...-", 'V'},
                { ".--", 'W'},
                { "-..-", 'X'},
                { "-.--", 'Y'},
                { "--..", 'Z'},
                { "/", ' '},
                { ".----", '1'},
                { "..---", '2'},
                { "...--", '3'},
                { "....-", '4'},
                { ".....", '5'},
                { "-....", '6'},
                { "--...", '7'},
                { "---..", '8'},
                { "----.", '9'},
                { "-----", '0'},
            };
        }

        public string TranslateEngToMorse(string inputChars)
        {
                EngToMorseCodeAlphabet();
                string result = "";
                try
                {
                    for (int i = 0; i < inputChars.Length; i++)
                    {
                        result += engToMorse[inputChars.ToUpper()[i]] + " ";
                    }
                }
                catch
                {
                    result = "Error in input! Try again.";
                }

            return result;
        }

        public string TranslateMorseToEng(string inputValue)
        {
            MorseToEngCodeAlphabet();
            List<string> values = new List<string>();
            string tempWord = "";
            string result = "";
            int k = 0;
            try
            {
                for(int i = k; i < inputValue.Length; i++)
                {
                    if (inputValue[i] != ' ')
                    {
                        tempWord += inputValue[i];
                    }
                    else
                    {
                        values.Add(tempWord);
                        k = i + 2;
                        tempWord = "";
                    }
                }

                for(int i = 0; i < values.Count; i++)
                {
                    result += morseToEng[values[i]];
                }
            }
            catch
            {
                result = "Error in input! Try again.";
            }
            return result;
        }
    }
}
