using System;
using System.Collections;
using System.Text.RegularExpressions;

public static class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = new int[4];
        
        for(int i = 0; i < 4; i++){
            bool valid = false;
            string input = "";
            Console.WriteLine($"### Enter {i+1}. number ###");
            while(!valid){
                Console.WriteLine("Please enter a non-negative numeric value: ");
                input = Console.ReadLine();
                
                if(Regex.IsMatch(input, @"^\d+$"))
                    valid = true;
            }
            int n = Int32.Parse(input);
            arr[i] = n;
        }
        
        Array.Sort(arr);
        
        foreach(int i in arr)
            Console.Write($"{i}, ");
        Console.WriteLine();
        
        int avg = getAverage(arr, 0, 3);
        Console.WriteLine($"Min avg is: {avg}");
        
        avg = getAverage(arr, arr.Length - 3, 3);
        Console.WriteLine($"Max avg is: {avg}");
        
    }
    
    public static int getAverage(int[] arr, int start, int len){
        int sum = 0;
        for(int i = 0; i < len; i++)
            sum += arr[start + i];
            
        return sum / len;
    }
}
