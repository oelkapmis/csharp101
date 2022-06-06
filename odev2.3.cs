using System;
using System.Collections;

public static class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine();
        ArrayList vowels = new ArrayList();
    
        foreach(var c in s){
            if(isVowel(c))
                vowels.Add(c);
        }
        vowels.Sort();
        foreach(var c in vowels){
            Console.Write($"{c} ");
        }
        
    }
    
    public static bool isVowel(char c){
        return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
    }
        
}
