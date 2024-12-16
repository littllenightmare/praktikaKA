using System.Windows;
using System.Windows.Controls;

namespace praktikaKA
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

        private void tbTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var posledovat = posled.Text.Split(' ').Select(n => int.Parse(n.Trim())).ToArray();
                graph.Children.Clear();
                if (functions.IsGeometricProgression(posledovat))
                {
                    functions.Draw(posledovat, graph);
                }
            }
            catch (FormatException)
            {
            }
            catch
            {
                MessageBox.Show("А?");
            }
        }
    }
}