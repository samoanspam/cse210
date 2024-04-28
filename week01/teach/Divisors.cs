public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        Random random = new Random();

        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}

        var randomNumber = random.Next(1, 101);    
        List<int> list2 = FindDivisors(randomNumber);
    
        Console.WriteLine($"The list for the random number {randomNumber} is:");    
        Console.WriteLine("{" + string.Join(", ", list2) + "}");


    
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new List<int>();
        
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                results.Add(i);
            }
        }
        return results;
    }
}