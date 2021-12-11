using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace My_Console_App;

public class Reverse
{
    public static string ReverseMyString(string stringToReverse)
    {
        char[] charArray = stringToReverse.ToCharArray();
        int size = charArray.Length;
        Stack stack = new Stack(size);
        
        int i;
        for (i = 0; i < size; ++i)
        {
            stack.Push(charArray[i]);
        }
        
        for ( i = 0; i < size; i++)
        {
            charArray[i] = (char)stack.Pop();
        }

        var reversedString = String.Join("", charArray);
        return reversedString;
    }
}