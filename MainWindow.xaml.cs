using System.Windows;
using ToDoApp.ViewModels;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e) { }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e) { }

        private void Description_GotFocus(object sender, RoutedEventArgs e)
        {
            viewModel.ToDoTitle = viewModel.TitlePlaceHolderText;

            viewModel.ToDescription = viewModel.DescriptionPlaceHolderText;
        }

        private void Description_LostFocus(object sender, RoutedEventArgs e) { }
    }
}
