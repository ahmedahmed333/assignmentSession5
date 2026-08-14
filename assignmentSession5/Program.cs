namespace assignmentSession5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            Book book = new Book();
            Console.WriteLine(book.password);// cannot access password because it is private . 
            // Private members can only be accessed from inside the Book class.

            #endregion
        }
    }
}
