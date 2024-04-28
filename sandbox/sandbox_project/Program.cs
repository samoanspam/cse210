using System;

public class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[3];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        var index = 0;

        // this is shorthand for initializing an array
        // var numbers = new[] {1, 2, 3};

        var numbersarray = new List<int> { 1, 2, 3};

        // This is longhand of the above line 
        // var numbersarray = new List<int>();
        // numbersarray.Add(1);
        // numbersarray.Add(2);
        // numbersarray.Add(3);

        //How to look up and check a certain index.
        var thisvalue = numbersarray[2];

        //How to append things to the list.
        numbersarray.Add(thisvalue);

        //How to insert a certain value in a specific index.
        numbersarray.Insert(index, 0);

        //How to remove an item from a specific index.
        numbersarray.Remove(index);

        //How to count the size of the array, not the capacity.
        var arraysize = numbersarray.Count;
        Console.WriteLine(arraysize);

        //How to check capacity of an array
        var arraycapacity = numbersarray.Capacity;
        Console.WriteLine(arraycapacity);

        //Why I would check if the array length is zero? Idk but here's how.
        bool isempty = numbersarray.Count == 0;
        Console.WriteLine(isempty);

        //Now to access everything in the list using the foreach loop
        foreach(var item in numbersarray)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine(thisvalue);


        System.Console.WriteLine("This is cool");

        Console.WriteLine("Hello Sandbox World!");
    }
}