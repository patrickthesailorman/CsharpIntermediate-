
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
    var button = sender as Button;
    if (button != null)
    {
      MessageBox.Show(button.ActualHeight.ToString());
    }

    MessageBox.Show("Hello World!");
  }
}