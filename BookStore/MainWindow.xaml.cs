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
using BookStore.DataBase;

namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books =  App.dbcontext.Book.ToList();
        public MainWindow()
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Image == null || books[i].Image.Length == 0)
                    books[i].Image = "Resourses/picture.png";
            }
            InitializeComponent();
            ListBook.ItemsSource = books;

            
        }
    }
}
