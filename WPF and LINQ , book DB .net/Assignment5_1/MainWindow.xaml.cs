using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Entity Framework DBContext
            BooksEntities dbcontext = new BooksEntities();

            // ------------------------------- Question 1 -----------------------------------------------

            // query for sorting books by titles.

            var titlesandAuthor =
               from book in dbcontext.Titles
               from author in book.Authors
               orderby book.Title1
               select new
               {
                   book.Title1,
                   author.FirstName,
                   author.LastName
               };

            output.AppendText("\r\n\r\nTitles and Authors:");

            // display titles and authors in tabular format
            foreach (var element in titlesandAuthor)
            {
                output.AppendText(String.Format("\r\r{0,-15} \t{1,-10} {2}",
                      element.Title1, element.FirstName, element.LastName));
            } // end foreach

            // -----------------------------------------Question 2 ------------------------------------------------
            // query for sorting title followed by sorting the author name alaphabetically for that particular title.

            var tASort =
              from book in dbcontext.Titles
              from author in book.Authors
              orderby book.Title1, author.LastName, author.FirstName ascending
              select new
              {
                  book.Title1,
                  author.FirstName,
                  author.LastName
              };

            output.AppendText(" \r\r--------------------------------------------------------------------------------------------");


            output.AppendText("\r\n\r\n Authors and titile with authors sortedfor each title:");

            // display titles and authors in tabular format
            foreach (var element in tASort)
            {
                output.AppendText(String.Format("\r\r{0,-10} \t{1,-10} {2}",
                      element.Title1, element.FirstName, element.LastName));
            } // end foreach

            // -----------------------------------------Question 3 --------------------------------------------------------------

            // query for sorting title followed by sorting the author  last name alaphabetically followed by lastName. for that particular title.

            var tASort_last =
                 from title in dbcontext.Titles
                 orderby title.Title1
                 select new
                 {
                     Title = title.Title1,
                     Name =
                       from author in title.Authors
                       orderby author.LastName, author.FirstName
                       select author.FirstName + " " + author.LastName
                 };


            output.AppendText(" \r\r--------------------------------------------------------------------------------------------");
            output.AppendText("\r\n\r\nTitles groupby author:");

            foreach (var element in tASort_last)
            {
                output.AppendText("\r\r" + element.Title);

                foreach (var element1 in element.Name)
                {
                    output.AppendText("\r"+ element1);

                }


            }

        }
    }
    }



