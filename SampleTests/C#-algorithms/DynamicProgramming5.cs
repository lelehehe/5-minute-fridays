using System;
using NUnit.Framework;

//note: 
//https://www.geeksforgeeks.org/dynamic-programming-set-5-edit-distance/
///Given two strings str1 and str2 and below operations that can performed on str1. Find minimum number of edits (operations) required to convert ‘str1’ into ‘str2’.
//a. Insert
//b. Remove
//c. Replace

//Examples:
//Input:   str1 = "geek", str2 = "gesek"
// Output:  1
// We can convert str1 into str2 by inserting a 's'.

// Input:   str1 = "cat", str2 = "cut"
// Output:  1
// We can convert str1 into str2 by replacing 'a' with 'u'.

// Input:   str1 = "sunday", str2 = "saturday"
// Output:  3
// Last three and first characters are same.  We basically
// need to convert "un" to "atur".  This can be done using
// below three operations. 
// Replace 'n' with 'r', insert t, insert a


class DynamicPrograming5
{
    static public int AddInts(int x, int y)
    {
        return x + y;
    }
    public int replaceCost(string st1, string st2) {
        return 0;
    }
}

[TestFixture]
class DynamicPrograming5Tests
{
    [TestCase("sunday", "saturday", 3)]
    [TestCase("geek", "gesek", 1)]
    [TestCase("cat", "cut", 1)]
    public void Should_Return_Sum_Given_Ints(int x, int y, int z)
    {
        var result = DynamicPrograming5.AddInts(x, y);
        Assert.AreEqual(z, result);
    }
}