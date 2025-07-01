public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {                                         /// Step1 - Create an array to store the multiples of the supplied number
        double[] result = new double[length]; /// In this line I am creating an array that will store decimal numbers, including whole numbers and negatives.
                                              /// that's why I use "double" it can hold all of those. And I name the array "result", which will act as the variable that refers to this array,
                                              /// after the equals sign, I create a new array of type double with a size defined by "length". In this case my "result array"
                                              /// will be the new array that will have "length" number of elements.
                                              /// Step2 - Set up a loop to go through each position in the array
        for (int i = 0; i < length; i++)      /// Here we have a "for" loop, starting with the first line we have the for statement,
                                              /// with three components, the first one, creates a variable "i" (type int) and sets it to 0,
                                              /// and that will be the counter while we move through the array. The second one is a condition,
                                              /// and it checks before every loop, so it's saying as long as "i" is still less than length,
                                              /// the loop keeps going, and when the condition becomes false, the loop stops. And the third one
                                              /// is an increment, after each loop, "i" increases by 1. 
        {                                     /// Step 3 - Fill each array element with a multiple of the starting number
            result[i] = number * (i + 1);     /// In this line we have 2 parts, separated by the equal sign, the first one (result[i]) accesses the array element at
                                              /// index "i", and the value for the array element will get on the second part, which is after the equal sign and this is
                                              /// that the "number" given, we will multiply it by "i + 1", where i starts at 0 and in each loop it will increment its value by 1
                                              /// as we saw in the for stament, so the first time will be "number * (0 + 1)", the second time will be "number * (1 + 1)", etc. 
        }
        /// Step 4 - Return the array containing all calculated multiples to the variable result.
        return result; /// This line is really important, because it uses the "return" keyword to send back the final result.
                       /// The variable "result" is holding the array of calculated multiples, so by writing "return result;" 
                       /// we pass that array back to whoever called the method, and it can be used or stored in another 
                       /// variable outside this method if we need it.
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {                                                                       ///Step 1 - Normalize the rotation amount so it stays within the list's size
        amount = amount % data.Count;                                       /// Here I have the variable "amount", which stores the number of positions we want to rotate the list to the right,
                                                                            /// then I use the equals sign, which assigns a new value to "amount". On the right side, the first part is "amount" 
                                                                            /// which is the original number of positions to rotate, the "%" symbol is called the modulus operator, it gives us
                                                                            /// the remainder when dividing one number by another. and the "data.Count" is the total number of items in the list.
                                                                            /// So the whole thing together is like how many positions we ACTUALLY need to rotate, because rotating more positions
                                                                            /// than the list length just wraps around. And finally, we assign this result back to "amount", so it holds the corrected number
                                                                            /// of positions to rotate.
                                                                            /// Step 2 - Extract the tail segment that will be rotated to the front
        List<int> tailSegment = data.GetRange(data.Count - amount, amount); /// In this line, I am creating a new list that will store integers (<int>) called "tailSegment", and after the equals sign,
                                                                            /// I am calling the method "GetRange" on the original list "data", the "GetRange" method uses 2 parameters ("startIndex", "count") this will
                                                                            /// return a new list that starts from a specific index and includes a number of items. In my case I have "data.Count - amount" as the
                                                                            /// "startIndex" and the "amount" as the number of items or "count". So all together will be: from the original list "data" I will get a range of numbers
                                                                            /// where the starting index will be the result of "data.Count - amount" and how many numbers I will get will be "amount", and I will store those numbers
                                                                            /// in my new "tailSegment" list, so I can insert those numbers at the front of the original list later, making it rotate.
                                                                            /// Step 3 - Remove the elements from the end of the list that will be rotated to the front
        data.RemoveRange(data.Count - amount, amount);                      /// Here I am calling the method "RemoveRange" on the list "data", this method removes a group of elements from the list, starting at
                                                                            /// specific index and removing a certain number of items. So the starting index will be "data.Count - amount" which calculates where the part to rotate begins.
                                                                            /// and "amount" is how many items will remove the method. So in short this code will remove the exact set of items that we are planning to insert at the front of the list.
                                                                            /// without this code, those numbers that we are adding at the beginning of the list will stay at the end and we do not want them to appear twice.
                                                                            /// Step 4 - Insert the rotated tail segment at the beginning of the original list.
        data.InsertRange(0, tailSegment);                                   /// Here I call the method "InsertRange" on the list "data". This method will take the numbers we have store in the "tailSegment" list and will insert them in the
                                                                            /// "data" list starting at index 0 (at the beginning).
    }
}
