using System;
using System.Collections;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main(string[] args)
    {
        ArrayList primes = new ArrayList();
        ArrayList nonPrimes = new ArrayList();
        
        for(int i = 0; i < 20; i++){
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
            if(IsPrime(n))
                primes.Add(n);
            else
                nonPrimes.Add(n);
        }
        
        primes.Sort();
        primes.Reverse();
        nonPrimes.Sort();
        nonPrimes.Reverse();
        
        Console.WriteLine($"There are {primes.Count} prime numbers, and avg is {getAverage(primes)}");
        foreach(int num in primes)
            Console.Write(num + " ");
            
        Console.WriteLine();
        
        Console.WriteLine($"There are {nonPrimes.Count} non-prime numbers, and avg is {getAverage(nonPrimes)}");
        foreach(int num in nonPrimes)
            Console.Write(num + " ");
            
    }
    
    public static int getAverage(ArrayList arr){
        int sum = 0;
        foreach(int i in arr)
            sum += i;
            
        return sum / arr.Count;
    }
    
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
    
        var boundary = (int)Math.Floor(Math.Sqrt(number));
              
        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;
        
        return true;        
    }
}
