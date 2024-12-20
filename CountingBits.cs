using System;

public class Program
{
    public static void Main()
    {
        Program solution = new Program();
        int n = 5;
        int[] result = solution.CountBits(n);

        Console.WriteLine("Output: [" + string.Join(",", result) + "]");
        // Output: [0,1,1]
    }
    int[] CountBits(int n)
    {
        // Initialize the result array with size n+1
        int[] ans = new int[n + 1];

        // Iterate from 1 to n
        for (int i = 1; i <= n; i++)
        {
            // If i is even, ans[i] = ans[i / 2]
            // If i is odd, ans[i] = ans[i / 2] + 1
            ans[i] = ans[i / 2] + (i % 2);
        }

        return ans;
    }
}

Algorithm:-

Step 1:- Start
Step 2:- Initialize an empty array to store Output size of (n+1)
          int[] ans=new int[n+1]
Step 3:- For:
              till i<=n
            ans[i]=ans[i/2]+i%2]
            return ans;
Step 4:- Print ans as ouput
Step 5:- Stop.
