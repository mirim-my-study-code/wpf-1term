using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assignment
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

        private void btnClickEvent(string btnText)
        {
            MessageBox.Show("클릭 이벤트 알림 : " + btnText, "클릭 감지");
        }

        private void btnClickEvent1(object sender, RoutedEventArgs e)
        {
            btnClickEvent("입차");
        }

        private void btnClickEvent2(object sender, RoutedEventArgs e)
        {
            btnClickEvent("출차");
        }

        private void btnClickEvent3(object sender, RoutedEventArgs e)
        {
            btnClickEvent("정산");
        }

        private void btnClickEvent4(object sender, RoutedEventArgs e)
        {
            btnClickEvent("종료");
        }
    }
}