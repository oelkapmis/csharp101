using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("n degerini girin: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        string[] arr = new string[n];
        for(int i = 0; i < n; i++){
            Console.WriteLine($"{i+1}. kelimeyi girin: ");
            arr[i] = Console.ReadLine();
        }
        
        Console.WriteLine($"Girdiginiz kelimeler: ");
        for(int i = n-1; i >= 0; i--){
                Console.WriteLine(arr[i]);
        }
    }
}
