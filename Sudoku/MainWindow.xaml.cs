using System.Windows;

namespace Sudoku
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationBuilder applicationBuilder = new ApplicationBuilder(this.DataContext);
        }
    }
}
