public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

private static int[] ListSelector(int[] list1, int[] list2, int[] selector)
{
    int[] result = new int[list1.Length + list2.Length];
    int index1 = 0, index2 = 0, resultIndex = 0;

    for (int i = 0; i < selector.Length; i++)
    {
        if (selector[i] == 1)
        {
            result[resultIndex++] = list1[index1++];
        }
        else if (selector[i] == 2)
        {
            result[resultIndex++] = list2[index2++];
        }
    }

    return result;
}

}