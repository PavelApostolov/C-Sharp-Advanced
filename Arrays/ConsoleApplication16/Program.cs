﻿/*  Problem 15. Prime numbers
    Write a program that finds all prime numbers in the range [1 ... N]. 
    Use the Sieve of Eratosthenes algorithm. 
    The program should print the biggest prime number which is <= N.
    Input: On the first line you will receive the number N
    Output: Print the biggest prime number which is <= N
    Constraints: 2 <= N <= 10 000 000
 */

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];

        // Find all prime numbers in the range [1...n]
        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            // Skip those numbers that are not prime
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        for (int i = primes.Length - 1; i >= 2; i--)
        {
            if (!primes[i])
            {
                Console.WriteLine(i);
                break;
            }
        }

        // Print all prime numbers in the range [1...n]
        //for (int i = 2; i < primes.Length; i++)
        //{
        //    // the numbers remaining not marked in the list are all the primes below n
        //    if (!primes[i])
        //    {
        //        Console.Write(i + " ");
        //    }
        //}

    }
}

/*
 * using System;

public class PrimeNumbers
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        var isPrime = new byte[length + 1];
        var result = 0;

        for (int i = 2; i <= length; i++)
        {
            if (isPrime[i] == 0)
            {
                result = i;

                for (int j = i * 2; j <= length; j += i)
                {
                    isPrime[j] = 1;
                }
            }
        }

        Console.WriteLine(result);
    }
}
*/