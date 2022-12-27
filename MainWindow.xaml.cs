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

namespace Animation_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point offset = new Point();
        Point speed = new Point();
        Point prevPrevPos = new Point();
        Point prevPos = new Point();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).CaptureMouse();
            offset = e.GetPosition((IInputElement)sender);
        }

        private void MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).ReleaseMouseCapture();
            speed = e.GetPosition(canvas) - (Vector)prevPrevPos;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (elka.IsMouseCaptured)
            {
                Canvas.SetLeft(elka, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka2.IsMouseCaptured)
            {
                Canvas.SetLeft(elka2, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka2, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka3.IsMouseCaptured)
            {
                Canvas.SetLeft(elka3, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka3, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }

            if (elka4.IsMouseCaptured)
            {
                Canvas.SetLeft(elka4, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka4, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }

            if (elka5.IsMouseCaptured)
            {
                Canvas.SetLeft(elka5, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka5, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka6.IsMouseCaptured)
            {
                Canvas.SetLeft(elka6, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka6, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka7.IsMouseCaptured)
            {
                Canvas.SetLeft(elka7, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka7, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka8.IsMouseCaptured)
            {
                Canvas.SetLeft(elka8, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka8, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }
            if (elka9.IsMouseCaptured)
            {
                Canvas.SetLeft(elka9, e.GetPosition(canvas).X - offset.X);
                Canvas.SetTop(elka9, e.GetPosition(canvas).Y - offset.Y);
                prevPrevPos = prevPos;
                prevPos = e.GetPosition(canvas);
            }


        }
    }
}
