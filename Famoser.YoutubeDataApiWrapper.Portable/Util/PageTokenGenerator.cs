using System;

namespace Famoser.YoutubeDataApiWrapper.Portable.Util
{
    public class PageTokenGenerator
    {
        public int TokenToNumber(string token)
        {
            return new PageTokenObject(token).PageTokenInteger;
        }

        public string NumberToToken(int number)
        {
            return new PageTokenObject(number).PageToken;
        }

        public string NumberToPrevToken(int number)
        {
            return new PageTokenObject(number, isPrevious: true).PageToken;
        }

        public PageTokenObject GetTokenObject(int number, bool isPrevious = false)
        {
            return new PageTokenObject(number, isPrevious);
        }

        public PageTokenObject GetTokenObject(string token)
        {
            return new PageTokenObject(token);
        }
    }

    public class Base64Alphabet
    {
        public const string b64Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";

        public bool HasIllegalChars(string token)
        {
            var arr = token.ToCharArray();
            foreach (var item in arr)
            {
                if (!b64Symbols.Contains(item.ToString()))
                    return true;
            }
            return false;
        }

        public int GetIndexOf(char c)
        {
            return b64Symbols.IndexOf(c);
        }

        public char GetCharAt(int i)
        {
            if (i > b64Symbols.Length)
                throw new IndexOutOfRangeException();
            return b64Symbols[i];
        }

    }
}
