using System.Runtime.InteropServices;

namespace ass1
{

    #region الكلاس داداخل ف حل اسئله كتير بقا
    class Book
    {
        public string title = default!;
        public int pages;
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
                Book b = new Book();
                object obj = b;
                Console.WriteLine(obj);
                Console.WriteLine(b.ToString());
                Console.WriteLine(b.Equals(b));
                Console.WriteLine(b.GetHashCode());
                Console.WriteLine(b.GetType());
                */
            #endregion
            #region q2
            //int pages="495" this is a logical error it should be int pages=495;

            #endregion
            #region q3
            /*
                try
                {
                    int x = 10;
                    int y = 0;
                    Console.WriteLine(x / y)

                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("cannot divide by zero");
                }
                finally
                {
                    Console.WriteLine("done");
                }
                */
            #endregion
            #region Q4
            /*
                int pages = 300;
                double v = pages;
                */
            #endregion
            #region Q5
            /*
               double price = 49.99;
               int p = Convert.ToInt32(price);
               string pagestext = "464";
               int pg = Convert.ToInt32(pagestext);
               string yeartext = "2023";

               int yr = int.Parse(yeartext);
               */
            #endregion
            #region Q5
            /*
                string badtext = "abc";
                if(int.TryParse(badtext,out int v))
                {
                    Console.WriteLine("validnumber");
                    Console.WriteLine(v);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                */
            #endregion
            #region Q6
            /*
               int pages = 464;
               string pg = pages.ToString();
               Console.WriteLine(pg);
               Console.WriteLine(pg.GetType());
               */
            #endregion
            #region Q7
            /*
                int copies = 100;
                object obj = copies;
                int z = (int)obj;
                Console.WriteLine(obj);
                Console.WriteLine(z);
                */
            #endregion
            #region Q8
            int? year = null;
            Console.WriteLine(year.HasValue);
            #endregion
            #region Q9
            year = 2023;
            Console.WriteLine(year.Value);
            #endregion
            #region Q10
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            #endregion
            #region Q11
            Book? book = null;
            Console.WriteLine(book?.title ?? "untitled");
            if (book == null)
            {
                book = new Book();
            }
            book.title ??= "untitled"; 
            #endregion
            #region Q12
            string? name = "ahmed";
            string confirmedname = name!;
            Console.WriteLine(confirmedname); 
            #endregion
        }
    }
}
