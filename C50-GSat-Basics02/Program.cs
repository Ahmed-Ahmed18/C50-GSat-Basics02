using C50_GSat_Basics02;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1  

        Book book1 = new Book();
        book1.Title = "C# Book";
        book1.Pages = 1200;

        Object obj= book1;

        Console.WriteLine(obj);
        #endregion

    }
}