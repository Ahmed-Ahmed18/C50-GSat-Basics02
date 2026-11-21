using C50_GSat_Basics02;

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
        int pages = 300;

        double bookPages = pages;

        Console.WriteLine(bookPages);
        #endregion
    }


}
