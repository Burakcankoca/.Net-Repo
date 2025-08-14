using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3__Grup_calismasi___08._08_.Validations
{
    public static class Validations
    {
        public static bool CheckLetterValidation(string sentence, int length)
        {
            if (string.IsNullOrEmpty(sentence) || sentence.Length > length)
            {
                return false;
            }

            return true;
        }

        public static bool CheckHasNumber(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            int x;
            bool result = int.TryParse(word, out x);
            if (result)
            {
                return false;
            }

            return true;
        }
    }
}
