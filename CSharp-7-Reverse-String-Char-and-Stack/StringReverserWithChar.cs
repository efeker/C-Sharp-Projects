using System;

namespace ReverseString
{
    public class StringReverserWithChar
    {
        public string Reverse(String item)
        {
            char[] charArray = item.ToCharArray();
            string itemReverse = "";

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                itemReverse = itemReverse + charArray[i];
            }
            return itemReverse;
        }
    }
}