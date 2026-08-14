namespace assignmentSession5
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Question01
            //Book book = new Book();
            //Console.WriteLine(book.password);// cannot access password because it is private . 
            //// Private members can only be accessed from inside the Book class.

            #endregion
            #region Question02
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock); // print 5, It compiles because copiesInStock is internal,
            //                                       // and Main is in he same assembly
            #endregion
            #region Question03
            //Book book = new Book();
            //book.Title = "MyTitle";
            //Console.WriteLine(book.Title);
            #endregion
            #region Question04
            Book book = new Book();

            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre); //Science
            #endregion

        }
    }
}
