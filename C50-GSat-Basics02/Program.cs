using C50_GSat_Basics02;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1  
        //1- Q01. Create a Book class with a Title (string) and Pages (int).
        //Create a Book object and store it in avariable of type object.Print it.

        //Book book1 = new Book();
        //book1.Title = "C# Book";
        //book1.Pages = 1200;

        //Object obj = book1;

        //Console.WriteLine(obj);
        #endregion
        #region Question2
        //2- Using the Book class above, print the result of calling ToString(), Equals() (compare book with
        //itself), GetHashCode(), and GetType() on book.

        //Book book1 = new Book();
        //book1.Title = "Flutter";
        //book1.Pages = 900;

        //Console.WriteLine(book1.ToString());
        //Console.WriteLine(book1.Equals(book1));
        //Console.WriteLine(book1.GetHashCode());
        //Console.WriteLine(book1.GetType());
        #endregion
        #region Question3
        //3- Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
        // int Pages="464"; is Compile Time Error
        // solution
        //int Pages = 464;

        #endregion
        #region Question4
        //4- Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
        //zero", and then prints "Done" in a finally block.

        //int x = 10;
        //int y = 0;
        //try
        //{
        //int z = x / y;
        //Console.WriteLine(z);

        //}
        //catch (Exception ex) 
        //{
        //Console.WriteLine("Cannot Divide By Zero");
        //}
        //finally
        //{
        //Console.WriteLine("Done");
        //}


        #endregion
        #region Question5
        //5- Declare an int pages = 300; then store it in a double variable without using a cast.
        //int pages = 300;
        //
        //double bookPages = pages;
        //
        //Console.WriteLine(bookPages);
        #endregion
        #region Question6
        //6- Declare a double price = 49.99; then convert it into an int using a cast.
        //double price = 49.99;
        //int priceInt =(int)price;
        //
        //Console.WriteLine(priceInt);
        #endregion
        #region Question7
        //7- Given string pagesText = "464";, convert it into an int using the Convert class.
        //string pagesText = "464";
        //int pages = Convert.ToInt32(pagesText);

        //Console.WriteLine(pages);
        #endregion
        #region Question8
        //8- Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
        //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

        //string yearText = "2023";
        //int yearTextInt= int.Parse(yearText);
        //Console.WriteLine(yearTextInt);

        //string badText = "abc";
        //if (int.TryParse(badText,out int badTextInt))
        //{
        //Console.WriteLine(badTextInt);
        //}
        //else
        //{
        //Console.WriteLine("Invalid Number");
        //}
        #endregion
        #region Question9
        //9- Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
        //to prove it's now a string.
        //int pages = 464;
        //string sPages = pages.ToString();
        //Console.WriteLine(sPages.GetType());
        #endregion
        #region Question10
        //10- Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
        //variable, and print both.
        //int copies = 100;

        //object obj = copies;

        //int newCopies = (int)obj;

        //Console.WriteLine(copies);
        //Console.WriteLine(newCopies);
        #endregion
        #region Question11
        //11- Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
        //int? year = null;

        //Console.WriteLine(year.HasValue);

        //year = 2023;

        //Console.WriteLine(year.Value);
        #endregion
        #region Question12
        // 12- Declare a string? reviewer = null;. Print whether it is null.
        //string ? reviewer = null;

        //Console.WriteLine(reviewer == null);
        #endregion
        #region Question13
        //13- Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
        //print the result.
        // Book? book= null;
        // Console.WriteLine(book?.Title);
        #endregion
        #region Question 14
        //14- Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to
        //assign title the value "Untitled" only if it's still null.
        //string? title = null;
        //
        //Console.WriteLine(title ?? "Untitled");
        //
        //title ??= "Untitled";
        //
        //Console.WriteLine(title);
        #endregion
        #region Question15
        //15- Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
        // confirmedName using the ! operator.

        string? name = "Ahmed";

        string confirmedName = name!;

        Console.WriteLine(confirmedName);
        #endregion
    }


}
