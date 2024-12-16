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
                graph.Children.Clear();
                int max = numbers.Max();
                int min = numbers.Min();
                int range = max - min;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    double x1 = i * (graph.Width / (numbers.Length - 1));
                    double y1 = graph.Height - ((numbers[i] - min) / range * graph.Height);
                    double x2 = (i + 1) * (graph.Width / (numbers.Length - 1));
                    double y2 = graph.Height - ((numbers[i + 1] - min) / range * graph.Height);

                    Line line = new Line
                    {
                        X1 = x1,
                        Y1 = y1,
                        X2 = x2,
                        Y2 = y2,
                        Stroke = Brushes.Blue,
                        StrokeThickness = 2
                    };

                    graph.Children.Add(line);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
