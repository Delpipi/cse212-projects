public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        //Perform "number * i" where 0 <= i < length and
        //add the result into array of size 'length'

        //create array of double number
        var results = new double[length];

        for (int i = 0; i < length; i++)
        {
            //add 1 to i and store the result
            int factor = i + 1;

            //multiply the previous result by 'number' and
            //store the result into array at index 'i'
            results[i] = number * factor;
        }

        //return the array of multiples of 'number'
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //GET Round in data.Count
        amount %= data.Count;

        //Get a list beginning of 'data.Count - amount' for 'amount' values
        List<int> amountList = data.GetRange(data.Count - amount, amount);

        //Insert previous list at index 0 of the data List
        data.InsertRange(0, amountList);

        //Previous operation increase the length and shift
        //content of array by 'amount' length to the right
        //Remove element from index 'amount' to 'data.Count - amount'
        data.RemoveRange(data.Count - amount, amount);
    }
}
