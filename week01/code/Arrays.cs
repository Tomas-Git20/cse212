public static class Arrays
{
    /// <summary>
    /// This function produces an array of size 'length' starting with
    /// 'number' followed by multiples of 'number'.
    /// </summary>
    /// <returns>Array of doubles that are multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new double array with the specified length.
        // 2. Use a for loop to go through each position in the array.
        // 3. Multiply the starting number by the current position plus one.
        // 4. Store the result in the corresponding array position.
        // 5. Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotates the data to the right by the specified amount.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Create a temporary list to store the elements that
        //    will move to the beginning of the original list.
        // 2. Find the starting position by subtracting amount
        //    from the total number of elements.
        // 3. Copy the last 'amount' elements into the temporary list.
        // 4. Copy the remaining elements from the original list
        //    into the temporary list, starting from position zero.
        // 5. Clear the original list.
        // 6. Add all elements from the temporary list back
        //    into the original list in their new order.

        List<int> rotated = new List<int>();

        int start = data.Count - amount;

        for (int i = start; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        for (int i = 0; i < start; i++)
        {
            rotated.Add(data[i]);
        }

        data.Clear();

        data.AddRange(rotated);
    }
}
