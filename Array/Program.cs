using System;
using System.Xml.Linq;

namespace Array
{
    //class ArrayExample
    //{
    //    static void Main(string[] args)
    //    {
    //        //int[] num = new int[100];

    //        //for (int i = 0; i < num.Length; i++)
    //        //{
    //        //    num[i] = i+1;
    //        //}
    //        //Console.WriteLine("Array elements: " + string.Join(", ", num));


    //        //Console.WriteLine("Array elements:");
    //        //foreach (int number in num)
    //        //{
    //        //    Console.Write(number + " ");
    //        //}

    //        //string welcome = "Helllo world";
    //        //Console.WriteLine(welcome.ToUpper());
    //        //Console.WriteLine(welcome.Length);

    //        //string firstname = "Prashant";
    //        //string lastname = "Rai";
    //        //Console.WriteLine(firstname+" "+lastname);

    //        //string fullname = firstname + lastname;
    //        //Console.WriteLine("Full Name: {0}", fullname);

    //        //string str = "Last night I dreamt of San Pedro";
    //        //Console.WriteLine(str);
    //        //string substr = str.Substring(6,10);
    //        //Console.WriteLine(substr);

    //        //string[] starray = new string[]{"Down the way nights are dark",
    //        //"And the sun shines daily on the mountain top",
    //        //"I took a trip on a sailing ship",
    //        //"And when I reached Jamaica",
    //        //"I made a stop"};

    //        //string str = String.Join("\n", starray);
    //        //Console.WriteLine(str);


    //    }
    //}


    //struct Books
    //{
    //    public string title;
    //    public string author;
    //    public string subject;
    //    public int book_id;
    //};

    //public class testStructure
    //{
    //    public static void Main(string[] args)
    //    {
    //Books Book1;   
    //Books Book2;  

    ///* book 1 specification */
    //Book1.title = "C Programming";
    //Book1.author = "Nuha Ali";
    //Book1.subject = "C Programming Tutorial";
    //Book1.book_id = 6495407;

    ///* book 2 specification */
    //Book2.title = "Telecom Billing";
    //Book2.author = "Zara Ali";
    //Book2.subject = "Telecom Billing Tutorial";
    //Book2.book_id = 6495700;

    ///* print Book1 info */
    //Console.WriteLine("Book 1 title : {0}", Book1.title);
    //Console.WriteLine("Book 1 author : {0}", Book1.author);
    //Console.WriteLine("Book 1 subject : {0}", Book1.subject);
    //Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

    ///* print Book2 info */
    //Console.WriteLine("Book 2 title : {0}", Book2.title);
    //Console.WriteLine("Book 2 author : {0}", Book2.author);
    //Console.WriteLine("Book 2 subject : {0}", Book2.subject);
    //Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

    //Console.ReadKey();

    //}

    //}



    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }
}

