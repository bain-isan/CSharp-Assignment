/*6.	Create a structure Book which contains the following members:
 *      bookId, title, price, bookType
 *      Type of the book should an enumerated data type with values as Magazine, Novel, ReferenceBook, 
 *      Miscellaneous. 
 *      
 *      Write a console based application to do the following tasks.
 *      a.	Accept the details of the book
 *      b.	Display the details of the book. The type of book should be displayed as a string e.g.:
 *      Magazine
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_6
{
    internal class Program
    {
        #region Book Structure
        internal struct Book
        {
            private int bookId;
            private string title;
            private double price;
            private int bookType;


            public int BookId { get { return this.bookId; } set { this.bookId = value; } }
            public string Title { get { return this.title; } set { this.title = value; } }
            public double Price { get { return this.price; } set { this.price = value; } }
            public int BookType { get { return (int)this.bookType; } set { this.bookType = value; } }
        }
        #endregion

        #region Enum for Book Type
        private enum BookTypeEnum
        {
            Magazine = 1, 
            Novel, 
            ReferenceBook, 
            Miscellaneous
        }
        #endregion

        #region Get Book Type In String Method
        private static string GetBookType(ref Book bk)
        {
            string bkType = null;

            Console.WriteLine("This " +  bk.BookType);

            
            switch (bk.BookType)
            {
                case (int)BookTypeEnum.Magazine: bkType = "Magazine";
                    break;

                case (int)BookTypeEnum.Novel: bkType = "Novel";
                    break;

                case (int)BookTypeEnum.ReferenceBook: bkType = "Reference Book";
                    break;

                case (int)BookTypeEnum.Miscellaneous: bkType = "Miscellaneous";
                    break;

                default: Console.WriteLine("Enter a Valid type");
                    break;
            }
            return bkType;
        }
        #endregion

        #region Get Valid integer Method
        private static int GetValidInteger(string msg = null)
        {
            int value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid integer number...Try Again...");
                        continue;
                    }
                    break;
                }while (true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Get Valid Double Method
        private static double GetValidDouble(string msg = null)
        {
            double value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid integer number...Try Again...");
                        continue;
                    }
                    break;
                }while (true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Set Book Details Method
        public static bool SetBookDetails(ref Book bk, int id)
        {
            bk.BookId = id;

            Console.Write("Enter Book Title: ");
            bk.Title = Console.ReadLine();

            bk.Price = Program.GetValidDouble("Enter Book Price (Rs.): ");
            int type = Program.GetValidInteger("\n1.Magazine\n2.Novel\n3.Reference Book\n4.Miscellaneous\nBook Type:");
            if (type > 0  && type < 5)
            {
                bk.BookType = type;
            }
            else
            {
                Console.WriteLine("Something went Wrong...Insert again...");
                return false;
            }

            Console.WriteLine("\nSuccessfully Inserted...");
            return true;
        }
        #endregion

        #region Display Book Details Method
        public static void DisplayBookDetails(ref Book[] books)
        {
            try
            {
                for(int i = 0; i<books.Length;i++)
                {
                    Console.WriteLine("\n----------------Book Details {0}----------------", books[i].BookId);
                    Console.WriteLine("Book Id: {0}", books[i].BookId);
                    Console.WriteLine("Book Title: {0}", books[i].Title);
                    Console.WriteLine("Book Price: {0}", books[i].Price);
                    Console.WriteLine("Book Type: {0}", Program.GetBookType(ref books[i]));
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                int size = Program.GetValidInteger("Enter the number of Books: ");
                Book[] bk = new Book[size];

                for (int num = 0; num < size; num++)
                {
                    Console.WriteLine("\n------------------Enter Book Details No {0}------------------", num + 1);
                    bk[num] = new Book();
                    if (!Program.SetBookDetails(ref bk[num], num + 1))
                    {
                        num--;
                    }
                        

                    
                }

                Program.DisplayBookDetails(ref bk);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }  
        #endregion
    }
}
