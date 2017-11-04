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
using System.Diagnostics;
namespace Wpf3d
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point pointMouseDown = new Point();
        double angle = 0;
        bool isMouseDown = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void viewport3D_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (isMouseDown)
            {
                isMouseDown = false;
                angle = 0;
                pointMouseDown = new Point();
            }
        }

        private void viewport3D_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point pointMouseMove = e.GetPosition(this.viewport3D);
                axisAngle.Angle = (angle + 360 + pointMouseMove.X - pointMouseDown.X) % 360;
                Debug.WriteLine(axisAngle.Angle.ToString());
            }
        }
        private void viewport3D_MouseDown(object sender,MouseButtonEventArgs e)
        {
            if (!isMouseDown)
            {
                pointMouseDown = e.GetPosition(this.viewport3D);
                angle = axisAngle.Angle;
                isMouseDown = true;
            }
        }
        private void viewport3D_MouseWheel(object sender,MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (camera.FieldOfView > 60)
                    camera.FieldOfView -= 10;
            }
            if (e.Delta < 0)
            {
                if (camera.FieldOfView < 200)
                    camera.FieldOfView += 10;
            }
        }
    }
}
