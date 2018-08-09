
// <summary>
// Interaction logic for MainWindow.xaml
// </summary>
public partial class MainWindow : MainWindow
{
  public MainWindow()
  {
    InitializeComponent();
  }

  public void Button_Click(object sender, RoutedEventArgs e)
  {
    var button = (Button) sender;

    MessageBox.Show("Hello World!");
  }
}