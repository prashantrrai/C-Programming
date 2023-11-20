using System;
using System.IO;

/*string dummyText = "Hello,World";

*//*File.WriteAllText("hello.txt", dummyText);

string ReadText = File.ReadAllText("hello.txt");
Console.WriteLine(ReadText);

File.Delete("hello.txt");*//*

if (File.Exists("hello.txt"))
{
    Console.WriteLine("File Already Exists");
}
else
{
    File.WriteAllText("hello.txt", dummyText);
}

string displayfile = File.ReadAllText("hello.txt");
Console.WriteLine(displayfile);*/

/*File.Delete("hello.txt");*/

/*string dummyText = "welcome to my sea sharp";
try
{
    File.WriteAllText("index.txt", dummyText);

    string ReadText = File.ReadAllText("index.txt");
    Console.WriteLine(ReadText);
}
catch(Exception error)
{
    Console.WriteLine($"This is Error .... {error.Message}");
}*/

t/*ry
{
    int[] nums = { 1, 2, 3 };
    Console.WriteLine(nums[21]);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("try catch is finished");
}*/


/*
static void votingRight(int Age)
{
    if(Age >= 18)
    {
        throw new ArithmeticException("You are a Minot");
    }
    else
    {
        Console.WriteLine("You can Vote to Modiji");
    }
}

static void Main(string[] args)
{
    votingRight(20);
}*/