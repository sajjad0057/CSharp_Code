using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolations;

public class StringInterpolation
{
    public static string MaskMiddlePart(string input)
    {
        var length = input.Length;
        var unmasked = input;
        string masked = string.Empty;
        if (length == 4)
            masked = $"{unmasked.Substring(0,1)}{new string('X', length - 2)}{unmasked.Substring(length - 1)}";
        else if (length == 5)
            masked = $"{unmasked.Substring(0, 2)}{new string('X', length - 3)}{unmasked.Substring(length - 1)}";
        else if (length == 6 || length == 7)
            masked = $"{unmasked.Substring(0, 2)}{new string('X', length - 4)}{unmasked.Substring(length - 2)}";
        else if (length == 8)
            masked = $"{unmasked.Substring(0, 3)}{new string('X', length - 5)}{unmasked.Substring(length - 2)}";
        else if (length > 8 && length < 11)
            masked = $"{unmasked.Substring(0, 3)}{new string('X', length - 6)}{unmasked.Substring(length - 3)}";
        else if (length > 10)
            masked = $"{unmasked.Substring(0, 4)}{new string('X', length - 7)}{unmasked.Substring(length - 3)}";
        else
            masked = input;
        
        return masked;
        
    }

    public static string MaskMiddlePart1(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 4)
            return input;

        int length = input.Length;
        int prefixLength, suffixLength;

        if (length <= 4) { prefixLength = 1; suffixLength = 1; }
        else if (length == 5) { prefixLength = 2; suffixLength = 1; }
        else if (length <= 7) { prefixLength = 2; suffixLength = 2; }
        else if (length == 8) { prefixLength = 3; suffixLength = 2; }
        else if (length < 11) { prefixLength = 3; suffixLength = 3; }
        else { prefixLength = 4; suffixLength = 3; }

        string masked = input[..prefixLength] + new string('X', length - (prefixLength + suffixLength)) + input[^suffixLength..];
        return masked;
    }

}
