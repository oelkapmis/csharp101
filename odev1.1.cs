using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("n degerini girin: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[n];
        for(int i = 0; i < n; i++){
            Console.WriteLine($"{i+1}. pozitif sayiyi girin: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girdiginiz cift sayilar: ");
        for(int i = 0; i < n; i++){
            if(arr[i] % 2 == 0){
                Console.WriteLine(arr[i]);
            }
        }
    }
}
