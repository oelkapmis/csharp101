using System;

public class Solution
{
    public static void Main(string[] args)
    {
        string str;
        int letterNum = 0;
        int wordNum = 0;
        Console.WriteLine("Bir cumle girin: ");
        str = Console.ReadLine();
        string str_trimmed = str.Trim();
        
        foreach(char c in str_trimmed){
            if(c.ToString() != " ") letterNum++;
            else wordNum++;
        }
        
        Console.WriteLine($"Girdiginiz cumle {wordNum + 1} sozcuk ve {letterNum} harf icermektedir");
        
    }
}
