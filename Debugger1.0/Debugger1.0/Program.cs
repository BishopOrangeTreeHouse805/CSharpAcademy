
Console.WriteLine(BetterCardUtilization(0.5, 0.6));
Console.WriteLine(BetterCardUtilization(0.6, 0.5));


BetterCardUtilization(0.5, 0.6);
BetterCardUtilization(0.6, 0.5);


string BetterCardUtilization(double card1Util, double card2Util)
{
    if (card1Util == card2Util)
    {
        return "Both cards have equal utilization.";
    }

    bool card1IsBetter = card1Util > card2Util;
    
    return card1IsBetter
        ? "Card 1 is better utilized." 
        : "Card 2 is better utilized.";
}


// //
// //
// // public static class StringHelper
// // {
// //     public static string ToTitleCase(this string stringSet)
// //     {
// //         if (string.IsNullOrEmpty(stringSet)) //handles null and empty strings
// //         {
// //             return stringSet;
// //         }
// //         
// //         char[] stringSetArray = stringSet.ToLower().ToCharArray(); //avoids creating a separate string variable for the first word to attach later.
// //
// //         if (char.IsLetter(stringSetArray[0]))//char has special methods for checking if a character is a letter.
// //         {
// //             stringSetArray[0] = char.ToUpper(stringSetArray[0]);//char has special methods for uppercasing and lowercasing characters.
// //         }
// //
// //         for (int i = 1; i < stringSetArray.Length; i++)//loops through the char in the array
// //         {
// //             if (stringSetArray[i - 1] == ' ' && char.IsLetter(stringSetArray[i]))
// //             {
// //                 stringSetArray[i] = char.ToUpper(stringSetArray[i]);
// //             }
// //         }
// //         
// //         return new string(stringSetArray);
// //         
// //     }
// //
// //
// //
// //
//
// //     public static bool IsPalindrome(this string stringSet)
// //     {
// //         if (string.IsNullOrEmpty(stringSet))
// //         {
// //             return false;
// //         }
// //
// //         char[] stringSetArray = stringSet.ToCharArray();
// //
// //         return stringSetArray.Reverse().ToString() == stringSetArray.ToString();//This is wrong.
// //
// //     }
// //     
// //     
// // }
// //
// //