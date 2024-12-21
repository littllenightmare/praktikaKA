using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace praktikaKA
{
    internal class functions
    {
        public static bool IsGeometricProgression(int[] numbers)
        {
            if (numbers.Length < 2) return false;

            double ratio = numbers[1] / numbers[0];
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] / numbers[i] != ratio)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Draw(int[] numbers, Canvas graph)
        {
            try
            {
                double xlast = 0, ylast=300;
                double height = 0, width = 0;
                graph.Children.Clear();

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    double x1 = xlast;
                    double y1 = ylast;
                    double x2 = xlast + 100;
                    double y2 = ylast - numbers[i+1] - 30;

                    height += y1-y2;
                    width += x2-x1;
                    Line line = new Line
                    {
                        X1 = x1,
                        Y1 = y1,
                        X2 = x2,
                        Y2 = y2,
                        Stroke = Brushes.Blue,
                        StrokeThickness = 2
                    };

                     if (width <= 800 & height <= 450)
                        graph.Children.Add(line);
                    xlast = x2;
                    ylast = y2;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
